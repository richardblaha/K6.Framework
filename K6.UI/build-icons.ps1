# Define the path to the JSON file
$jsonFilePath = Join-Path -Path "node_modules\bootstrap-icons\font" -ChildPath "bootstrap-icons.json"

# Check if the JSON file exists
if (-Not (Test-Path -Path $jsonFilePath))
{
    Write-Host "JSON file not found."
    exit
}

# Read the JSON file content
$jsonContent = Get-Content -Path $jsonFilePath -Raw

# Initialize StringBuilders for the enum and switch cases
$enumBuilder = New-Object -TypeName System.Text.StringBuilder
$switchBuilder = New-Object -TypeName System.Text.StringBuilder

# Use regular expressions to extract icon names and values
$regex = [regex]'"([^"]+)":\s*(\d+)'
$matchesResult = $regex.Matches($jsonContent)

foreach ($match in $matchesResult)
{
    $iconName = $match.Groups[1].Value
    $iconValue = $match.Groups[2].Value

    # Convert iconName to PascalCase
    $enumName = ($iconName -split '-').ForEach({ $_.Substring(0, 1).ToUpper() + $_.Substring(1) }) -join ''

    # Add prefix _ if enumName starts with a number
    if ($enumName -match '^\d')
    {
        $enumName = "_$enumName"
    }

    $enumBuilder.AppendLine("    $enumName = $iconValue,") | Out-Null
    $switchBuilder.AppendLine("            IconType.$enumName => `"bi bi-$iconName`",") | Out-Null
}

# Build and write the enum code to IconType.cs
$iconTypeBuilder = New-Object -TypeName System.Text.StringBuilder
$iconTypeBuilder.AppendLine("// generated code") | Out-Null
$iconTypeBuilder.AppendLine() | Out-Null
$iconTypeBuilder.AppendLine("namespace K6.UI.Enums;") | Out-Null
$iconTypeBuilder.AppendLine() | Out-Null
$iconTypeBuilder.AppendLine("public enum IconType") | Out-Null
$iconTypeBuilder.AppendLine("{") | Out-Null
$iconTypeBuilder.Append($enumBuilder.ToString()) | Out-Null
$iconTypeBuilder.AppendLine("}") | Out-Null
$iconTypeBuilder.AppendLine() | Out-Null

$iconTypeBuilder.ToString() | Set-Content -Path "Enums/IconType.cs"

# Build and write the extension method code to IconTypeExtensions.cs
$iconTypeBuilder = New-Object -TypeName System.Text.StringBuilder
$iconTypeBuilder.AppendLine("// generated code") | Out-Null
$iconTypeBuilder.AppendLine() | Out-Null
$iconTypeBuilder.AppendLine("using K6.UI.Enums;") | Out-Null
$iconTypeBuilder.AppendLine() | Out-Null
$iconTypeBuilder.AppendLine("namespace K6.UI.Extensions;") | Out-Null
$iconTypeBuilder.AppendLine() | Out-Null
$iconTypeBuilder.AppendLine("public static class IconTypeExtensions") | Out-Null
$iconTypeBuilder.AppendLine("{") | Out-Null
$iconTypeBuilder.AppendLine("    public static string? ToClass(this IconType iconType)") | Out-Null
$iconTypeBuilder.AppendLine("    {") | Out-Null
$iconTypeBuilder.AppendLine("        return iconType switch") | Out-Null
$iconTypeBuilder.AppendLine("        {") | Out-Null
$iconTypeBuilder.Append($switchBuilder.ToString()) | Out-Null
$iconTypeBuilder.AppendLine("            _ => null") | Out-Null
$iconTypeBuilder.AppendLine("        };") | Out-Null
$iconTypeBuilder.AppendLine("    }") | Out-Null
$iconTypeBuilder.AppendLine("}") | Out-Null
$iconTypeBuilder.AppendLine() | Out-Null

$iconTypeBuilder.ToString() | Set-Content -Path "Extensions/IconTypeExtensions.cs"

#
Write-Host "IconType.cs and IconTypeExtensions.cs generated successfully."
