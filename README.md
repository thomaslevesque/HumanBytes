HumanBytes
==========

A library to convert byte sizes to a human readable form.

Installation
------------

Install the library via NuGet

```
PM> Install-Package HumanBytes
```

Basic usage
-----------

The `Bytes` extension method returns an object that has a human readable string representation:

```csharp
var f = new FileInfo("TheFile.jpg");
Console.WriteLine("The size of '{0}' is {1}", f, f.Length.Bytes());
```

The value is formatted using the default formatter; you can change the default formatter settings through the `ByteSizeFormatter.Default` static property.

More advanced usage
-------------------

If you need more control, create an instance of `ByteSizeFormatter` and change its settings:

```csharp
var formatter = new ByteSizeFormatter
{
    Convention = ByteSizeConvention.Binary,
    DecimalPlaces = 1,
    NumberFormat = "#,##0.###",
    MinUnit = ByteSizeUnit.Kilobyte,
    MaxUnit = ByteSizeUnit.Gigabyte,
    RoundingRule = ByteSizeRounding.Closest,
    UseFullWordForBytes = true,
};

var f = new FileInfo("TheFile.jpg");
Console.WriteLine("The size of '{0}' is {1}", f, formatter.Format(f.Length));
```

Localization
------------

At this stage, HumanBytes only supports English and French. However, if you need support for another language, it's very easy: there are only 3 terms that need to be translated, so it shouldn't take more than a minute. Here are the steps:

- add a `Resources.xx.resx` file (where `xx` is the language code) in the `HumanBytes/Properties` folder, and translate the terms
- edit `HumanBytes/HumanBytes.csproj` to include the new resource file
- edit `NuGet\HumanBytes.nuspec` to include the new satellite assembly

I'll be glad to accept pull requests to support more languages.
