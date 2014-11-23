HumanBytes
==========

A library to convert byte sizes to a human readable form.

Installation
------------

Install the library via NuGet

``````

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
