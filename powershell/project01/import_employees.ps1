function Import-Employees {
    # $input_file = Read-Host "Enter file path of employees to import"
    # $share_folder = Read-Host "Enter folder to create employee shares"
    $input_file = 'D:\test\NewHires.txt'
    $share_path = 'D:\test\shares'

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
            -FullAccess 'Everyone' -Description "Employee share" | Out-Null

        ## comment out the above 3 lines and uncomment below to remove created directories
        # Remove-SmbShare -Name $share_name -ErrorAction 0 -Force
        # Remove-Item -Path $share_path\* -ErrorAction 0 -Recurse -Force


        # create colour coded output with: Employee name, Full path, and UNC Path
        Write-Host "Employee Name: `t`t$emp" -ForegroundColor 'Green'
        Write-Host "Full Path: `t`t$share_path\$share_name" -ForegroundColor 'Magenta'
        Write-Host "UNC Path: `t`t\\$env:COMPUTERNAME\$share_name" -ForegroundColor 'Blue'
        Write-Host "_______________________________________________" -ForegroundColor 'White'
    }
}
Import-Employees
