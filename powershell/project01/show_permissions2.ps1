# $path = Read-Host "Enter path to check Permissions and Activity"
$path = 'D:\test'
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
        Write-Host "`t`t -->$($item_ace.FileSystemRights)`t$($item_ace.IdentityReference)" -ForegroundColor White
    }

    # check flag if admin has fullcontrol on each file
    if ($admin_has_fullcontrol -eq $false) {
        Write-Host "`t`t NOTICE: Administrators don't have 'FullControl'!" `
            -ForegroundColor Red
        $admin_fullcontrol_files += $item
    }
}

# display results in table
Write-Host "`n`n`nAll Files and folders where Adminstrators don't have 'FullControl':" -ForegroundColor Red
$admin_fullcontrol_files `
| Select-Object -Property FullName, LastAccessTime, LastWriteTime | ft

Write-Host "Results saved in $path`n" -ForegroundColor Red
# export to csv
# $admin_fullcontrol_files `
# | Select-Object -Property FullName, Last*Time `
# | Export-Csv $path\files_without_adminFullControl.csv -NoTypeInformation

# Invoke-Item $path\files_without_adminFullControl.csv

