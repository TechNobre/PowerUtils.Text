using System;

namespace PowerUtils.Text.Tests.NetworkExtensionsTests;

public class ToQueryStringTests
{
    [Fact]
    public void Null_ToQueryString_ArgumentNullException()
    {
        // Arrange
        object value = null;


        // Act
        var act = Record.Exception(() => value.ToQueryString());


        // Assert
        act.Should()
            .BeOfType<ArgumentNullException>();
    }

    [Fact]
    public void ShortNumber_ToQueryString_ArgumentNullException()
    {
        // Arrange
        short value = 4212;


        // Act
        var act = Record.Exception(() => value.ToQueryString());


        // Assert
        act.Should()
            .BeOfType<NotSupportedException>();
    }

    [Fact]
    public void UShortNumber_ToQueryString_ArgumentNullException()
    {
        // Arrange
        ushort value = 4212;


        // Act
        var act = Record.Exception(() => value.ToQueryString());


        // Assert
        act.Should()
            .BeOfType<NotSupportedException>();
    }

    [Fact]
    public void IntNumber_ToQueryString_ArgumentNullException()
    {
        // Arrange
        int value = 4212;


        // Act
        var act = Record.Exception(() => value.ToQueryString());


        // Assert
        act.Should()
            .BeOfType<NotSupportedException>();
    }

    [Fact]
    public void UIntNumber_ToQueryString_ArgumentNullException()
    {
        // Arrange
        uint value = 4212;


        // Act
        var act = Record.Exception(() => value.ToQueryString());


        // Assert
        act.Should()
            .BeOfType<NotSupportedException>();
    }

    [Fact]
    public void LongNumber_ToQueryString_ArgumentNullException()
    {
        // Arrange
        long value = 4212;


        // Act
        var act = Record.Exception(() => value.ToQueryString());


        // Assert
        act.Should()
            .BeOfType<NotSupportedException>();
    }

    [Fact]
    public void ULongNumber_ToQueryString_ArgumentNullException()
    {
        // Arrange
        ulong value = 4212;


        // Act
        var act = Record.Exception(() => value.ToQueryString());


        // Assert
        act.Should()
            .BeOfType<NotSupportedException>();
    }

    [Fact]
    public void FloatNumber_ToQueryString_ArgumentNullException()
    {
        // Arrange
        float value = 4212;


        // Act
        var act = Record.Exception(() => value.ToQueryString());


        // Assert
        act.Should()
            .BeOfType<NotSupportedException>();
    }

    [Fact]
    public void DoubleNumber_ToQueryString_ArgumentNullException()
    {
        // Arrange
        double value = 4212;


        // Act
        var act = Record.Exception(() => value.ToQueryString());


        // Assert
        act.Should()
            .BeOfType<NotSupportedException>();
    }

    [Fact]
    public void DecimalNumber_ToQueryString_ArgumentNullException()
    {
        // Arrange
        decimal value = 4212;


        // Act
        var act = Record.Exception(() => value.ToQueryString());


        // Assert
        act.Should()
            .BeOfType<NotSupportedException>();
    }

    [Fact]
    public void ObjectWithoutParameters_ToQueryString_Empty()
    {
        // Arrange
        object value = new object();


        // Act
        var act = value.ToQueryString();


        // Assert
        act.Should()
            .BeEmpty();
    }

    [Fact]
    public void ObjectWithParameters_ToQueryString_QueryString()
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
