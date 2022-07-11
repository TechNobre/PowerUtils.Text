namespace PowerUtils.Text.Tests.TextExtensionsTests;

public class CleanSpecialCharactersTests
{
    [Fact]
    public void Null_CompressText_Null()
    {
        // Arrange
        string input = null;


        // Act
        var act = input.CleanSpecialCharacters();


        // Assert
        act.Should()
            .BeNull();
    }

    [Fact]
    public void Empty_CleanSpecialCharacters_Empty()
    {
        // Arrange
        var input = "";


        // Act
        var act = input.CleanSpecialCharacters();


        // Assert
        act.Should()
            .BeEmpty();
    }

    [Theory]
    [InlineData("hello world", "hello-world")]
    [InlineData("hello world!!!", "hello-world---")]
    [InlineData("#hello#world3", "-hello-world3")]
    [InlineData("Hello World", "Hello-World")]
    public void Text_CleanSpecialCharacters_StringCleanWithOtherCharacter(string input, string expected)
    {
        // Arrange & Act
        var act = input.CleanSpecialCharacters("-");


        // Assert
        act.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("hello world", "helloworld")]
    [InlineData("Hello World!!!", "HelloWorld")]
    [InlineData("#hello#world3", "helloworld3")]
    public void Text_CleanSpecialCharacters_StringClean(string input, string expected)
    {
        // Arrange & Act
        var act = input.CleanSpecialCharacters();


        // Assert
        act.Should()
            .Be(expected);
    }
}
