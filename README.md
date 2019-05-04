# HumanBytes

[![NuGet version](https://img.shields.io/nuget/v/HumanBytes.svg)](https://www.nuget.org/packages/HumanBytes)
[![AppVeyor build](https://img.shields.io/appveyor/ci/thomaslevesque/humanbytes.svg)](https://ci.appveyor.com/project/thomaslevesque/humanbytes)
[![AppVeyor tests](https://img.shields.io/appveyor/tests/thomaslevesque/humanbytes.svg)](https://ci.appveyor.com/project/thomaslevesque/humanbytes/build/tests)

A library to convert byte sizes to a human readable form.

## Installation

Install the library via NuGet

```
PM> Install-Package HumanBytes
```

## Basic usage

The `Bytes` extension method returns an object that has a human readable string representation:

```csharp
var f = new FileInfo("TheFile.jpg");
Console.WriteLine("The size of '{0}' is {1}", f, f.Length.Bytes());
```

The value is formatted using the default formatter; you can change the default formatter settings through the `ByteSizeFormatter.Default` static property.

## More advanced usage

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

## Localization

At this stage, HumanBytes only supports English and French. However, if you need support for another language, it's very easy, as there are only 3 terms that need to be translated. Just create an instance of `ByteSizeFormatter` as shown above, and set the following properties:

- `ByteSymbol`: the symbol for byte, e.g. "B" in English.
- `ByteWord`: the word for byte, e.g. "byte" in English.
- `ByteWords`: the word for several bytes, e.g. "bytes" in English.

The values set on these properties will be used instead of the ones defined in resources.

If you would like to add permanent support for another language, you'll have to modify the library itself. Just clone the project, add a `Resources.xx.resx` file (where `xx` is the language code) in the `HumanBytes/Properties` folder, translate the terms, and build.

I'll be glad to accept pull requests to support more languages.
