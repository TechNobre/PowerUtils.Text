namespace PowerUtils.Text.Tests.TextExtensionsTests;

[Trait("Extension", "EmptyOrWhiteSpace")]
public class EmptyOrWhiteSpaceTests
{
    [Fact(DisplayName = "String null should return null")]
    public void EmptyOrWhiteSpace_Null_ReturnNull()
    {
        // Arrange
        string input = null;


        // Act
        var act = input.EmptyOrWhiteSpace();


        // Assert
        act.Should()
            .BeNull();
    }

    [Fact(DisplayName = "String only empty should return null")]
    public void EmptyOrWhiteSpace_Empty_ReturnNull()
    {
        // Arrange
        var input = string.Empty;


        // Act
        var act = input.EmptyOrWhiteSpace();


        // Assert
        act.Should()
            .BeNull();
    }

    [Fact(DisplayName = "String with white spaces should return null")]
    public void EmptyOrWhiteSpace_WithWhiteSpaces_ReturnNull()
    {
        // Arrange
        var input = "       ";


        // Act
        var act = input.EmptyOrWhiteSpace();


        // Assert
        act.Should()
            .BeNull();
    }

    [Fact(DisplayName = "String filled should return the input")]
    public void EmptyOrWhiteSpace_Filled_ReturnEqualsInput()
    {
        // Arrange
        var input = " Hello world!!   ";


        // Act
        var act = input.EmptyOrWhiteSpace();


        // Assert
        act.Should()
            .Be(" Hello world!!   ");
    }
}
