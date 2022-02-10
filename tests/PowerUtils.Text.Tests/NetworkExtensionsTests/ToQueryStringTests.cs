using System;

namespace PowerUtils.Text.Tests.NetworkExtensionsTests;

[Trait("Extension", "ToQueryString")]
public class ToQueryStringTests
{
    [Fact(DisplayName = "Try to convert a null object to QueryString - Should return an 'ArgumentNullException'")]
    public void ToQueryString_Null_ArgumentNullException()
    {
        // Arrange
        object value = null;


        // Act
        var act = Record.Exception(() => value.ToQueryString());


        // Assert
        act.Should()
            .BeOfType<ArgumentNullException>();
    }

    [Fact(DisplayName = "Try to convert a short value to QueryString - Should return an 'NotSupportedException'")]
    public void ToQueryString_Short_ArgumentNullException()
    {
        // Arrange
        short value = 4212;


        // Act
        var act = Record.Exception(() => value.ToQueryString());


        // Assert
        act.Should()
            .BeOfType<NotSupportedException>();
    }

    [Fact(DisplayName = "Try to convert a ushort value to QueryString - Should return an 'NotSupportedException'")]
    public void ToQueryString_UShort_ArgumentNullException()
    {
        // Arrange
        ushort value = 4212;


        // Act
        var act = Record.Exception(() => value.ToQueryString());


        // Assert
        act.Should()
            .BeOfType<NotSupportedException>();
    }

    [Fact(DisplayName = "Try to convert a int value to QueryString - Should return an 'NotSupportedException'")]
    public void ToQueryString_Int_ArgumentNullException()
    {
        // Arrange
        int value = 4212;


        // Act
        var act = Record.Exception(() => value.ToQueryString());


        // Assert
        act.Should()
            .BeOfType<NotSupportedException>();
    }

    [Fact(DisplayName = "Try to convert a uint value to QueryString - Should return an 'NotSupportedException'")]
    public void ToQueryString_UInt_ArgumentNullException()
    {
        // Arrange
        uint value = 4212;


        // Act
        var act = Record.Exception(() => value.ToQueryString());


        // Assert
        act.Should()
            .BeOfType<NotSupportedException>();
    }

    [Fact(DisplayName = "Try to convert a long value to QueryString - Should return an 'NotSupportedException'")]
    public void ToQueryString_Long_ArgumentNullException()
    {
        // Arrange
        long value = 4212;


        // Act
        var act = Record.Exception(() => value.ToQueryString());


        // Assert
        act.Should()
            .BeOfType<NotSupportedException>();
    }

    [Fact(DisplayName = "Try to convert a ulong value to QueryString - Should return an 'NotSupportedException'")]
    public void ToQueryString_ULong_ArgumentNullException()
    {
        // Arrange
        ulong value = 4212;


        // Act
        var act = Record.Exception(() => value.ToQueryString());


        // Assert
        act.Should()
            .BeOfType<NotSupportedException>();
    }

    [Fact(DisplayName = "Try to convert a float value to QueryString - Should return an 'NotSupportedException'")]
    public void ToQueryString_Float_ArgumentNullException()
    {
        // Arrange
        float value = 4212;


        // Act
        var act = Record.Exception(() => value.ToQueryString());


        // Assert
        act.Should()
            .BeOfType<NotSupportedException>();
    }

    [Fact(DisplayName = "Try to convert a double value to QueryString - Should return an 'NotSupportedException'")]
    public void ToQueryString_Double_ArgumentNullException()
    {
        // Arrange
        double value = 4212;


        // Act
        var act = Record.Exception(() => value.ToQueryString());


        // Assert
        act.Should()
            .BeOfType<NotSupportedException>();
    }

    [Fact(DisplayName = "Try to convert a decimal value to QueryString - Should return an 'NotSupportedException'")]
    public void ToQueryString_Decimal_ArgumentNullException()
    {
        // Arrange
        decimal value = 4212;


        // Act
        var act = Record.Exception(() => value.ToQueryString());


        // Assert
        act.Should()
            .BeOfType<NotSupportedException>();
    }

    [Fact(DisplayName = "Convert a object without parameters to QueryString - Should return an empty string")]
    public void ToQueryString_WithoutParameters_Empty()
    {
        // Arrange
        object value = new object();


        // Act
        var act = value.ToQueryString();


        // Assert
        act.Should()
            .BeEmpty();
    }

    [Fact(DisplayName = "Convert a object with parameters to QueryString - Should return an QueryString")]
    public void ToQueryString_WithParameters_Empty()
    {
        // Arrange
        object parameters = new
        {
            Name = "Nelson",
            Age = 12,
            IsValide = true
        };


        // Act
        var act = parameters.ToQueryString();


        // Assert
        act.Should()
            .Be("?Name=Nelson&Age=12&IsValide=True");
    }
}
