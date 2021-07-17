# PowerUtils.Text



## Support to
- .NET 2.0 or more
- .NET Framework 4.6.2 or more
- .NET Standard 2.0 or more



## Documentation


### Extensions


#### string.CleanExtraSpaces();

Clean extra spaces. Replace tabs to one space and double spaces to one space

```csharp
// result = "Hello world!!!"
var result = " Hello  world!!! ".CleanExtraSpaces();
```


#### string.CleanExtraLineBreak();

Clean extra line breaks. Replace double line breaks to one line break

```csharp
// result = "Hello\r\nWorld!!!"
var result = "Hello\r\n\r\n\r\nWorld!!!".CleanExtraLineBreak();
```

#### string.CleanExtraLineBreakAndLineBreak();

Clean extra spaces, override tabs to one space, double spaces to one space and double line breaks to one line break

```csharp
// result = "Hello\r\nWorld!!!"
var result = "   Hello \r\n\r\n\r\n  World!!! ".CleanExtraLineBreakAndLineBreak();
```

#### string.EmptyOrWhiteSpace();

Convert a string with empty or white spaces to null

```csharp
// result = null
var result = "       ".EmptyOrWhiteSpace();
```

#### string.CompressText(maxLength);

Compress text if greater the max length

```csharp
// result = "Hell…"
var result = "Hello world!!!".CompressText(5);
```

#### string.Truncate(maxLength);

Truncate text if greater the max length

```csharp
// result = "Hello"
var result = "Hello world!!!".Truncate(5);
```



## Contribution

*Help me to help others*



## LICENSE

[MIT](https://github.com/NelsonBN/demo-rabbitmq/blob/main/LICENSE)