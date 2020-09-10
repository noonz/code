function Show-Files {
    $path = 'D:\test'

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
    | Export-Csv $path\recent_10_accessed.csv -NoTypeInformation
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
Show-Files
