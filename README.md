# PowerUtils.Text
Helpers, extensions and utilities for manipulating

![CI](https://github.com/TechNobre/PowerUtils.Text/actions/workflows/main.yml/badge.svg)
[![NuGet](https://img.shields.io/nuget/v/PowerUtils.Text.svg)](https://www.nuget.org/packages/PowerUtils.Text)
[![Nuget](https://img.shields.io/nuget/dt/PowerUtils.Text.svg)](https://www.nuget.org/packages/PowerUtils.Text)



## Support to
- .NET 3.1 or more
- .NET Framework 4.6.2 or more
- .NET Standard 2.0 or more



## Features

- [Extensions](#Extensions)
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



## Documentation

### How to use

#### Install NuGet package
This package is available through Nuget Packages: https://www.nuget.org/packages/PowerUtils.Text

**Nuget**
```bash
Install-Package PowerUtils.Text
```

**.NET CLI**
```
dotnet add package PowerUtils.Text
```

### Extensions <a name="Extensions"></a>

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



## Contribution

*Help me to help others*



## LICENSE

[MIT](https://github.com/TechNobre/PowerUtils.Text/blob/main/LICENSE)



## Release Notes


### v1.2.0 - 2021/11/23

#### New features
- Added extension `string.LowercaseFirst()`. To lowercase the first character;

#### Enhancements
- Updated documentation;

#### Updates
- Added support to .NET6.0;


### v1.1.0 - 2021/07/18

#### New features
- Added extension `string.UppercaseFirst()`. To uppercase the first character;
- Added extension `string.CapitalizeName()`. To capitalize the people and company names;
- Added extension `string.CleanSpecialCharacters()`. To replace all special characters in a string for other character;



### v1.0.0 - 2021/07/18

- Kick start project