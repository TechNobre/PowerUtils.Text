# PowerUtils.Text

![Logo](https://raw.githubusercontent.com/TechNobre/PowerUtils.Text/main/assets/logo/logo_128x128.png)

***Helpers, extensions and utilities for manipulating strings***

![Tests](https://github.com/TechNobre/PowerUtils.Text/actions/workflows/tests.yml/badge.svg)
[![Mutation tests](https://img.shields.io/endpoint?style=flat&url=https%3A%2F%2Fbadge-api.stryker-mutator.io%2Fgithub.com%2FTechNobre%2FPowerUtils.Text%2Fmain)](https://dashboard.stryker-mutator.io/reports/github.com/TechNobre/PowerUtils.Text/main)

[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=TechNobre_PowerUtils.Text&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=TechNobre_PowerUtils.Text)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=TechNobre_PowerUtils.Text&metric=coverage)](https://sonarcloud.io/summary/new_code?id=TechNobre_PowerUtils.Text)
[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=TechNobre_PowerUtils.Text&metric=reliability_rating)](https://sonarcloud.io/summary/new_code?id=TechNobre_PowerUtils.Text)
[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=TechNobre_PowerUtils.Text&metric=bugs)](https://sonarcloud.io/summary/new_code?id=TechNobre_PowerUtils.Text)

[![NuGet](https://img.shields.io/nuget/v/PowerUtils.Text.svg)](https://www.nuget.org/packages/PowerUtils.Text)
[![Nuget](https://img.shields.io/nuget/dt/PowerUtils.Text.svg)](https://www.nuget.org/packages/PowerUtils.Text)
[![License: MIT](https://img.shields.io/github/license/TechNobre/PowerUtils.Text.svg)](https://github.com/TechNobre/PowerUtils.Text/blob/main/LICENSE)


- [Support](#support-to)
- [How to use](#how-to-use)
    - [Installation](#installation)
    - [TextExtensions](#TextExtensions)
        - [CleanExtraSpaces](#string.CleanExtraSpaces)
        - [CleanExtraLineBreak](#string.CleanExtraLineBreak)
        - [CleanExtraLineBreakAndLineBreak](#string.CleanExtraLineBreakAndLineBreak)
        - [EmptyOrWhiteSpace](#string.EmptyOrWhiteSpace)
        - [CompressText](#string.CompressText)
        - [Truncate](#string.Truncate)
        - [CapitalizeName](#string.CapitalizeName)
        - [CleanSpecialCharacters](#string.CleanSpecialCharacters)
        - [UppercaseFirst](#string.UppercaseFirst)
        - [LowercaseFirst](#string.LowercaseFirst)
        - [ToSnakeCase](#string.ToSnakeCase)
    - [NetworkExtensions](#NetworkExtensions)
        - [IsEmail](#string.IsEmail)
        - [CombineURL](#string.CombineURL)
        - [ToQueryString](#object.ToQueryString)
- [Warning](#warning)
- [Contribution](#contribution)
- [License](./LICENSE)
- [Changelog](./CHANGELOG.md)



## Support to <a name="support-to"></a>
- .NET 7.0
- .NET 6.0
- .NET 5.0
- .NET 3.1



## How to use <a name="how-to-use"></a>

### Install NuGet package <a name="installation"></a>
This package is available through Nuget Packages: https://www.nuget.org/packages/PowerUtils.Text

**Nuget**
```bash
Install-Package PowerUtils.Text
```

**.NET CLI**
```
dotnet add package PowerUtils.Text
```



### TextExtensions <a name="TextExtensions"></a>

#### string.CleanExtraSpaces(); <a name="string.CleanExtraSpaces"></a>
Clean extra spaces. Replace tabs to one space and double spaces to one space

```csharp
// result = "Hello world!!!"
var result = " Hello  world!!! ".CleanExtraSpaces();
```

#### string.CleanExtraLineBreak(); <a name="string.CleanExtraLineBreak"></a>
Clean extra line breaks. Replace double line breaks to one line break

```csharp
// result = "Hello\r\nWorld!!!"
var result = "Hello\r\n\r\n\r\nWorld!!!".CleanExtraLineBreak();
```

#### string.CleanExtraLineBreakAndLineBreak(); <a name="string.CleanExtraLineBreakAndLineBreak"></a>
Clean extra spaces, override tabs to one space, double spaces to one space and double line breaks to one line break

```csharp
// result = "Hello\r\nWorld!!!"
var result = "   Hello \r\n\r\n\r\n  World!!! ".CleanExtraLineBreakAndLineBreak();
```

#### string.EmptyOrWhiteSpace(); <a name="string.EmptyOrWhiteSpace"></a>
Convert a string with empty or white spaces to null

```csharp
// result = null
var result = "       ".EmptyOrWhiteSpace();
```

#### string.CompressText(maxLength); <a name="string.CompressText"></a>
Compress text if greater the max length

```csharp
// result = "Hell..."
var result = "Hello world!!!".CompressText(5);
```

#### string.Truncate(maxLength); <a name="string.Truncate"></a>
Truncate text if greater the max length

```csharp
// result = "Hello"
var result = "Hello world!!!".Truncate(5);
```

#### string.CapitalizeName(); <a name="string.CapitalizeName"></a>
Capitalize the people amd company names

```csharp
// result = "Nelson Nobre"
var result = "nelson nobre".CapitalizeName();
```

#### string.CleanSpecialCharacters(substitute = ""); <a name="string.CleanSpecialCharacters"></a>
Capitalize the people amd company names

```csharp
// result1 = "HelloWorld"
var result1 = "Hello World!!!".CleanSpecialCharacters();

// result2 = "Hello-World"
var result2 = "Hello World".CleanSpecialCharacters("-");
```

#### string.UppercaseFirst(); <a name="string.UppercaseFirst"></a>
Uppercase the first character

```csharp
// result = "Hello world!!!"
var result = "hello world!!!".UppercaseFirst();
```

#### string.LowercaseFirst(); <a name="string.LowercaseFirst"></a>
Uppercase the first character

```csharp
// result = "hello world!!!"
var result = "Hello world!!!".UppercaseFirst();
```

#### string.ToSnakeCase(); <a name="string.ToSnakeCase"></a>
Convert a text to snake case format

```csharp
// result = "test_snake_case"
var result = "TestSnakeCase".ToSnakeCase();
```



### TextExtensions <a name="TextExtensions"></a>

#### string.IsEmail(); <a name="string.IsEmail"></a>
Check if the input is an email

```csharp
// result = true
var result = "nelson@fake.com".IsEmail();
```

#### string.CombineURL(); <a name="string.CombineURL"></a>
Check if the input is an email

```csharp
// result = http://localhost:8080/clients/photos
var result = "http://localhost:8080".CombineURL("clients", "photos");
```

#### object.ToQueryString(); <a name="object.ToQueryString"></a>
Convert an object to a QueryString.

```csharp
object parameters = new
{
    Name = "Nelson",
    Age = 12,
    IsValide = true
};

// result = ?Name=Nelson&Age=12&IsValide=True
var result = parameters.ToQueryString();
```



## :warning: Warning <a name="warning"></a>
Discontinued the extension `string.EmptyOrWhiteSpace()`. New method `string.EmptyOrWhiteSpaceToNull()` will be removed in 2022/08/31.



## Contribution <a name="contribution"></a>

If you have any questions, comments, or suggestions, please open an [issue](https://github.com/TechNobre/PowerUtils.Text/issues/new/choose) or create a [pull request](https://github.com/TechNobre/PowerUtils.Text/compare)
