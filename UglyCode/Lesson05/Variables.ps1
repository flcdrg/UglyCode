# Quiz - 2014-05-02

# Set-StrictMode -Version Latest
Set-StrictMode -Off

function Interesting
{
    $s

    $s = "The clock struck one"

    $t = "The mouse ran down"

    $s, $t
}

$files = Get-ChildItem | ForEach-Object -Process { 
    if ( $_.Extension -eq ".doc" )
    {
        $_
    }
}

Write-Host "Results"
Write-Host "-------"

if ($files.Count -eq 0)
{
    Write-Host "The mouse ran up the clock"
}

$s = "Hickory, dickory, dock"

Interesting

$s

$t