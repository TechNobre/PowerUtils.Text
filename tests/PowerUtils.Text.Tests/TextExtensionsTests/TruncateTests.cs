namespace PowerUtils.Text.Tests.TextExtensionsTests;

public class TruncateTests
{
    [Fact]
    public void Null_CompressText_Null()
    {
        // Arrange
        string input = null;


        // Act
        var act = input.Truncate(50);


        // Assert
        act.Should()
            .BeNull();
    }

    [Fact]
    public void Empty_Truncate_Empty()
    {
        // Arrange
        var input = "";


        // Act
        var act = input.Truncate(50);


        // Assert
        act.Should()
            .BeEmpty();
    }

    [Fact]
    public void EqualsMaxLength_Truncate_EqualsInput()
    {
        // Arrange
        var input = "HelLo";
        var maxLength = 5;


        // Act
        var act = input.Truncate(maxLength);


        // Assert
        act.Should()
            .Be("HelLo");
        act.Should()
            .HaveLength(maxLength);
    }

    [Fact]
    public void LessMaxLength_Truncate_EqualsInput()
    {
        // Arrange
        var input = "Hello";
        var maxLength = 4;


        // Act
        var act = input.Truncate(maxLength);


        // Assert
        act.Should()
            .Be("Hell");
        act.Should()
            .HaveLength(maxLength);
    }

    [Fact]
    public void GreaterMaxLength_Truncate_CompressedText1()
    {
        // Arrange
        var input = "Hello world!!!";
        var maxLength = 5;


        // Act
        var act = input.Truncate(maxLength);


        // Assert
        act.Should()
            .Be("Hello");
        act.Should()
            .HaveLength(maxLength);
    }

    [Fact]
    public void GreaterMaxLength_Truncate_CompressedText2()
    {
        // Arrange
        var input = "Hello world!!!";
        var maxLength = 6;


        // Act
        var act = input.Truncate(maxLength);


        // Assert
        act.Should()
            .Be("Hello ");
        act.Should()
            .HaveLength(maxLength);
    }
}
