param($installPath, $toolsPath, $package, $project)
$path = [System.IO.Path]
$readmefile = $path::Combine($installPath, "Readme.md") 
$DTE.ItemOperations.OpenFile($readmefile)
