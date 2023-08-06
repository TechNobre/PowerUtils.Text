# [3.0.0](https://github.com/TechNobre/PowerUtils.Text/compare/v2.2.0...v3.0.0) (2023-08-06)


### Bug Fixes

* Soved issue `CleanExtraLineBreak()` removing spaces before and after line breaks ([2c8fc7a](https://github.com/TechNobre/PowerUtils.Text/commit/2c8fc7a84a356eed5a451757fd9125d8cf5397c1))


### Code Refactoring

* Removed discontinued extensions ([d4ed02f](https://github.com/TechNobre/PowerUtils.Text/commit/d4ed02f1e8031cd37723da35e2fd636f31791951))


### Tests

* Added unit tests for all supported frameworks ([267cf7c](https://github.com/TechNobre/PowerUtils.Text/commit/267cf7cdd9b1ba8baf5a2f23797ae851cba19744))


### BREAKING CHANGES

* Removed discontinued extensions `EmptyOrWhiteSpace`
* Removed supported for `netstandard2.0`, `netstandard2.1`, `net462`, `net48`

# [2.2.0](https://github.com/TechNobre/PowerUtils.Text/compare/v2.1.0...v2.2.0) (2022-07-11)


### Features

* Add support to debug in runtime `Microsoft.SourceLink.GitHub` ([08885ec](https://github.com/TechNobre/PowerUtils.Text/commit/08885ecf9e8548c156fb661aff832e27bc89cef9))

# [2.1.0](https://github.com/TechNobre/PowerUtils.Text/compare/v2.0.0...v2.1.0) (2022-03-04)
[Full Changelog]


### Features

* Added extension `string.ToSnakeCase()`;


### Enhancements

* Simplified code;




# [2.0.0](https://github.com/TechNobre/PowerUtils.Text/compare/v1.2.0...v2.0.0) (2022-02-10)

### Features

* Added extension `string.IsEmail()`;
* Added extension `string.CombineURL()`;
* Added extension `object.ToQueryString()`;


### BREAKING CHANGES

* Discontinued the extension `string.EmptyOrWhiteSpace()`. New method `string.EmptyOrWhiteSpaceToNull()`;




# [1.2.0](https://github.com/TechNobre/PowerUtils.Text/compare/v1.1.0...v1.2.0) (2021-11-23)

### Features

* Added extension `string.LowercaseFirst()`. To lowercase the first character;


### Enhancements

* Updated documentation;


### Updates

* Added support to .NET6.0;




# [1.1.0](https://github.com/TechNobre/PowerUtils.Text/compare/v1.0.0...v1.1.0) (2021-07-18)

### Features

* Added extension `string.UppercaseFirst()`. To uppercase the first character;
* Added extension `string.CapitalizeName()`. To capitalize the people and company names;
* Added extension `string.CleanSpecialCharacters()`. To replace all special characters in a string for other character;




# 1.0.0 (2021-07-18)

* Kick start project
