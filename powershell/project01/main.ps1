<#
.SYNOPSIS
Project01 for CET1014 for Prof. Dan Lowe
.DESCRIPTION
Displays a menu in a loop to execute four seperate tasks.
-All paths should be entered without leading \. "d:\test" instead of "d:\test\"
-Show permissions of files at a path, then determine which files/folders don't have administrators access
-Import employees from a txt file, then create shares with permissions for everyone
-Shows computer info such as: disk space, ram amounts, hostname and IPv4 addresses
-Shows file data such as: 25 newest, 20 largest, 10 recently accessed
.NOTES
Author: Dave Nunez
Credit: stackoverflow.com, old.reddit.com/r/powershell, Dan Lowe, Nathan Abourbih
#>

# default menu
function Show-Menu {
    Write-Host "=============== Main Menu ===============" -ForegroundColor 'Magenta'
    Write-Host "1: Show Permissions" -ForegroundColor 'Yellow'
    Write-Host "2: Import Employees" -ForegroundColor 'Yellow'
    Write-Host "3: Retrieve Computer Information" -ForegroundColor 'Yellow'
    Write-Host "4: Inspect Path" -ForegroundColor 'Yellow'
    Write-Host "Q: Quit" -ForegroundColor 'Red'
}

# function to get permissions and activity recursively in a directory
function Show-Permissions {
    $path = Read-Host "Enter path to check Permissions and Activity"
    $admin_fullcontrol_files = @()
    $path_items = Get-ChildItem $path -Recurse

    # iterate through all files and folders at path provided
    foreach ($item in $path_items) {
        # retrieve access control list for each item
        $item_acl = Get-Acl -path $item.FullName
        # retrieve permissions assigned to each file
        $item_access = $item_acl.Access | Where-Object { $_.FileSystemRights -like 'FullControl' }

        # create boolean if admin has full access, default false
        [bool]$admin_has_fullcontrol = $false

        # determine if content is a file or folder
        [bool]$is_folder = $item.PSIsContainer

        # create a seperater
        Write-Host "`t _______________________________________________________________"`
            -ForegroundColor White

        # output filename preceded with colour coded file or folder
        Write-Host "`n`t $(&{`
        If($is_folder) {"Folder: "} `
            Else {"File:`t "}})$($item.FullName)" -ForegroundColor "$(&{ `
        If($is_folder) {"Magenta"} `
            Else {"Blue"}})"

        # retrieve users with 'FullControl' permissions for each file *BONUS*
        Write-Host "`t`t Users/Groups with 'FullControl': " -ForegroundColor Green

        # nested loop to determine 'fullcontrol' per item
        foreach ($item_ace in $item_access) {

            # determine if admin has 'fullcontrol' on each file or folder using conditional statement
            # and change the fullcontrol boolean appropriately
            if ($item_ace.IdentityReference -like "*Administrators") {
                $admin_has_fullcontrol = $true
            }
            Write-Host "`t`t -$($item_ace.FileSystemRights)`t$($item_ace.IdentityReference)" -ForegroundColor White
        }

        # check flag if admin has fullcontrol on each file
        if ($admin_has_fullcontrol -eq $false) {
            Write-Host "`t`t NOTICE: Administrators' don't have 'FullControl'!" `
                -ForegroundColor Red
            $admin_fullcontrol_files += $item
        }
    }

    # display results in table
    Write-Host "`n`n`nAll Files and folders where Adminstrators' don't have 'FullControl':" -ForegroundColor Red
    $admin_fullcontrol_files `
    | Select-Object -Property FullName, LastAccessTime, LastWriteTime | ft

    Write-Host "Results saved in $path`n" -ForegroundColor Red

    # export to csv
    $admin_fullcontrol_files `
    | Select-Object -Property FullName, Last*Time `
    | Export-Csv $path\files_without_adminFullControl.csv -NoTypeInformation

    # uncomment to automatically open the file after execution
    # Invoke-Item $path\files_without_adminFullControl.csv

}

# import employees from a .txt file and create shares for each item
function Import-Employees {
    $input_file = Read-Host "Enter file path of employees to import"
    $share_path = Read-Host "Enter folder to create employee shares"
    # $input_file = 'D:\test\NewHires.txt'
    # $share_path = 'D:\test\shares'

    [string[]]$emp_array = Get-Content -path $input_file

    foreach ($emp in $emp_array) {
        # replace space with hypen for share name, and convert to lowercase
        Write-Host "Creating share for: `t$emp"
        $share_name = $emp -replace " ", "_"
        $share_name = $share_name.ToUpper()

        # create directory for employee in share path
        # pipe in Out-Null to dismiss console output
        # create smb share with the same folder name, giving Everyone 'FullControl'
        New-Item -Path $share_path -Name $share_name -ItemType 'directory' | Out-Null
        New-SmbShare -Name $share_name -Path $share_path\$share_name `
            -FullAccess 'Everyone' -Description 'Employee share' | Out-Null

        ## comment out the above 2 lines and uncomment below to remove created shares
        # Remove-SmbShare -Name $share_name -ErrorAction 0 -Force
        # Remove-Item -Path $share_path\* -ErrorAction 0 -Recurse -Force


        # create colour coded output with: Employee name, Full path, and UNC Path
        Write-Host "Employee Name: `t`t$emp" -ForegroundColor 'Green'
        Write-Host "Full Path: `t`t$share_path\$share_name" -ForegroundColor 'Magenta'
        Write-Host "UNC Path: `t`t\\$env:COMPUTERNAME\$share_name" -ForegroundColor 'Blue'
        Write-Host "_______________________________________________" -ForegroundColor 'White'
    }
}

# retrieve computer information such as: name,ipv4,drive size,used,free and RAM
# from a txt file
function Show-ComputerInfo {
    $computer_file = Read-Host "Enter path to a text file with computer names"
    $computers = Get-Content -path $computer_file

    foreach ($computer in $computers) {
        # calculate ram and round to a full number
        $ram = (Get-WmiObject -class 'Win32_PhysicalMemory' `
                -namespace "root\CIMV2" -ComputerName $computer `
            | Measure-Object -Property capacity -Sum | % { [Math]::Round(($_.sum / 1GB), 2) } )

        # determine ipv4 address
        $ipv4 = Get-NetIPAddress -AddressFamily IPv4

        # determine c:drive size and freespace in GB
        $c_drive = Get-WmiObject Win32_LogicalDisk -ComputerName $computer `
            -Filter "DeviceID='C:'" | Select-Object Size, FreeSpace


        Write-Host "Hostname:`t$computer" -ForegroundColor Blue
        Write-Host "IPv4 Adress:`t$ipv4" -ForegroundColor Yellow
        # round for readability
        Write-Host("C Drive Size:`t{0} GB" -f ([Math]::Round($c_drive.Size / 1GB))) -ForegroundColor Cyan
        # divide freespace by total space for percentage
        Write-Host("C Drive Free:`t{0:P0}" -f ($c_drive.freespace / $c_drive.size)) -ForegroundColor Magenta
        Write-Host "Ram:`t`t$ram GB" -ForegroundColor Green
        Write-Host "_____________________________________________________" -ForegroundColor White
    }
}

# show and export 25 newest files, 20 largest, 10 recently accessed from path
function Show-Files {
    $path = Read-Host "Enter path to inspect"

    # determine 25 newest files at path by sorting CreationTime and export
    $newest_files = @(Get-ChildItem $path -recurse -file `
        | Sort-Object CreationTime -Descending `
        | Select-Object FullName, @{Name = "Length(MB)"; Expression = { [math]::Round($_.Length / 1mb, 2) } }, LastAccessTime, LastWriteTime -First 25) `
    | Export-Csv $path\newest_25_files.csv -NoTypeInformation
    Write-Host "Top 25 Newest:" -ForegroundColor Blue
    Write-Host "`t$path\newest_25_files.csv" -ForegroundColor Cyan

    # determine 20 largest files at path by sorting length and export
    $largest_files = @(Get-ChildItem $path -recurse -file `
        | Sort-Object Length -Descending `
        | Select-Object FullName, @{Name = "Length(MB)"; Expression = { [math]::Round($_.Length / 1mb, 2) } }, LastAccessTime, LastWriteTime -First 20) `
    | Export-Csv $path\largest_20_files.csv -NoTypeInformation
    Write-Host "`nTop 20 Largest:" -ForegroundColor Blue
    Write-Host "`t$path\largest_20_files.csv" -ForegroundColor Cyan

    # determine 10 recently accessed files at path by sorting LastAccessTime and export
    $recent_access = @(Get-ChildItem $path -recurse -file `
        | Sort-Object LastAccessTime -Descending `
        | Select-Object FullName, @{Name = "Length(MB)"; Expression = { [math]::Round($_.Length / 1mb, 2) } }, LastAccessTime, LastWriteTime -First 10) `
    | Export-Csv $path\recent_10_files.csv -NoTypeInformation
    Write-Host "`nTop 10 Recent:" -ForegroundColor Blue
    Write-Host "`t$path\recent_10_files.csv" -ForegroundColor Cyan

    # search path for csv files created
    $csvs = Get-ChildItem $path\* -Include *files.csv
    $output_filename = "combined_data.xlsx"

    Write-Host "`nCombined:" -ForegroundColor Blue
    Write-Host "`t$output_filename" -ForegroundColor Cyan

    # create new excel workbook and sheet counter
    $excelapp = new-object -comobject Excel.Application
    $excelapp.sheetsInNewWorkbook = $csvs.Count
    $xlsx = $excelapp.Workbooks.Add()
    $sheet = 1

    # create sheets for each csv file found at path
    foreach ($csv in $csvs) {
        $row = 1
        $column = 1
        $worksheet = $xlsx.Worksheets.Item($sheet)
        $worksheet.Name = $csv.Name
        $file = (Get-Content $csv)
        foreach ($line in $file) {
            $linecontents = $line -split ',(?!\s*\w+")'
            foreach ($cell in $linecontents) {
                $worksheet.Cells.Item($row, $column) = $cell
                $column++
            }
            $column = 1
            $row++
        }
        $sheet++
    }
    $output = "$path\$output_filename"
    $xlsx.SaveAs($output)
    $excelapp.quit()
    Invoke-Item $path\$output_filename

}

# loop to display menu with options
do {
    Clear-Host
    Show-Menu
    $UserInput = Read-Host "Choose an option"

    switch ($UserInput) {
        '1' {
            Clear-Host
            Show-Permissions
            Pause
        }
        '2' {
            Clear-Host
            Import-Employees
            Pause
        }
        '3' {
            Clear-Host
            Show-ComputerInfo
            Pause
        }
        '4' {
            Clear-Host
            Show-Files
            Pause
        }
    }
} until ($UserInput -eq 'Q')
