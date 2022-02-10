﻿namespace PowerUtils.Text.Tests.TextExtensionsTests;

[Trait("Extension", "LowercaseFirst")]
public class LowercaseFirstTests
{
    [Fact(DisplayName = "String null - Should return null")]
    public void LowercaseFirst_Null_ReturnNull()
    {
        // Arrange
        string input = null;


        // Act
        var act = input.LowercaseFirst();


        // Assert
        act.Should()
            .BeNull();
    }

    [Fact(DisplayName = "String only empty - Should return empty")]
    public void LowercaseFirst_Empty_ReturnEmpty()
    {
        // Arrange
        var input = "";


        // Act
        var act = input.LowercaseFirst();


        // Assert
        act.Should()
            .BeEmpty();
    }

    [Fact(DisplayName = "String with spaces before text")]
    public void LowercaseFirst_LessMaxLength_ReturnEqualsInput1()
    {
        // Arrange
        var input = " Hello world!!!";


        // Act
        var act = input.LowercaseFirst();


        // Assert
        act.Should()
            .Be(input);
    }

    [Fact(DisplayName = "String with spaces before text")]
    public void LowercaseFirst_LessMaxLength_ReturnEqualsInput2()
    {
        // Arrange
        var input = " hello world!!!";


        // Act
        var act = input.LowercaseFirst();


        // Assert
        act.Should()
            .Be(input);
    }

    [Fact(DisplayName = "String lowercase")]
    public void LowercaseFirst_Lowercase_ReturnsupperFirstCharacter()
    {
        // Arrange
        var input = "hello world!!!";


        // Act
        var act = input.LowercaseFirst();


        // Assert
        act.Should()
            .Be("hello world!!!");
    }

    [Fact(DisplayName = "String lowercase with first character already upper")]
    public void LowercaseFirst_AlreadyUpper_ReturnsupperFirstCharacter()
    {
        // Arrange
        var input = "Hello world!!!";


        // Act
        var act = input.LowercaseFirst();


        // Assert
        act.Should()
            .Be("hello world!!!");
    }
}
