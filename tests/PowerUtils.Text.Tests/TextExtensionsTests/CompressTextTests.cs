namespace PowerUtils.Text.Tests.TextExtensionsTests;

public class CompressTextTests
{
    [Fact]
    public void Null_CompressText_Null()
    {
        // Arrange
        string input = null;


        // Act
        var act = input.CompressText(50);


        // Assert
        act.Should()
            .BeNull();
    }

    [Fact]
    public void Empty_CompressText_Empty()
    {
        // Arrange
        var input = "";


        // Act
        var act = input.CompressText(50);


        // Assert
        act.Should()
            .BeEmpty();
    }

    [Fact]
    public void EqualsMaxLength_CompressText_EqualsInput()
    {
        // Arrange
        var input = "HelLo";
        var maxLength = 5;


        // Act
        var act = input.CompressText(maxLength);


        // Assert
        act.Should()
            .Be("HelLo");
        act.Should()
            .HaveLength(maxLength);
    }

    [Fact]
    public void LessMaxLength_CompressText_EqualsInput()
    {
        // Arrange
        var input = "Hello";
        var maxLength = 4;


        // Act
        var act = input.CompressText(maxLength);


        // Assert
        act.Should()
            .Be("Hel…");
        act.Should()
            .HaveLength(maxLength);
    }

    [Fact]
    public void GreaterMaxLength_CompressText_CompressedText()
    {
        // Arrange
        var input = "Hello world!!!";
        var maxLength = 5;


        // Act
        var act = input.CompressText(maxLength);


        // Assert
        act.Should()
            .Be("Hell…");
        act.Should()
            .HaveLength(maxLength);
    }
}
