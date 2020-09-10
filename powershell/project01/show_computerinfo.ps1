function Show-ComputerInfo {
    $computer_file = 'D:\test\computers.txt'
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


        Write-Host "Hostname: `t$computer" -ForegroundColor Blue
        Write-Host "IPv4 Adress: `t$ipv4" -ForegroundColor Yellow
        # round for readability
        Write-Host("C Drive Size: `t{0} GB" -f ([Math]::Round($disk.Size / 1GB))) -ForegroundColor Cyan
        # divide freespace by total space for percentage
        Write-Host("C Drive Free %: {0:P0}" -f ($c_drive.freespace / $c_drive.size)) -ForegroundColor Magenta
        Write-Host "Ram:`t`t$ram GB" -ForegroundColor Green
        Write-Host "_____________________________________________________" -ForegroundColor White
    }
}
Show-ComputerInfo
