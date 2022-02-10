namespace PowerUtils.Text.Tests.TextExtensionsTests;

[Trait("Extension", "CleanSpecialCharacters")]
public class CleanSpecialCharactersTests
{
    [Fact(DisplayName = "String null should return null")]
    public void CompressText_Null_ReturnNull()
    {
        // Arrange
        string input = null;


        // Act
        var act = input.CleanSpecialCharacters();


        // Assert
        act.Should()
            .BeNull();
    }

    [Fact(DisplayName = "String only empty should return empty")]
    public void CleanSpecialCharacters_Empty_ReturnEmpty()
    {
        // Arrange
        var input = "";


        // Act
        var act = input.CleanSpecialCharacters();


        // Assert
        act.Should()
            .BeEmpty();
    }

    [Theory(DisplayName = "Test texts - Replace to other character")]
    [InlineData("hello world", "hello-world")]
    [InlineData("hello world!!!", "hello-world---")]
    [InlineData("#hello#world3", "-hello-world3")]
    [InlineData("Hello World", "Hello-World")]
    public void CleanSpecialCharacters_Text_ReturnStringCleanWithOtherCharacter(string input, string expected)
    {
        // Arrange & Act
        var act = input.CleanSpecialCharacters("-");


        // Assert
        act.Should()
            .Be(expected);
    }

    [Theory(DisplayName = "Test texts")]
    [InlineData("hello world", "helloworld")]
    [InlineData("Hello World!!!", "HelloWorld")]
    [InlineData("#hello#world3", "helloworld3")]
    public void CleanSpecialCharacters_Text_ReturnStringClean(string input, string expected)
    {
        // Arrange & Act
        var act = input.CleanSpecialCharacters();


        // Assert
        act.Should()
            .Be(expected);
    }
}
