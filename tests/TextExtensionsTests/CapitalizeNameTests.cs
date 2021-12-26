using FluentAssertions;
using Xunit;

namespace PowerUtils.Text.Tests.TextExtensionsTests;

[Trait("Extension", "CapitalizeName")]
public class CapitalizeNameTests
{
    [Fact(DisplayName = "String null should return null")]
    public void CompressText_Null_ReturnNull()
    {
        // Arrange
        string input = null;


        // Act
        var act = input.CapitalizeName();


        // Assert
        act.Should()
            .BeNull();
    }

    [Fact(DisplayName = "String only empty should return empty")]
    public void CapitalizeName_Empty_ReturnEmpty()
    {
        // Arrange
        var input = string.Empty;


        // Act
        var act = input.CapitalizeName();


        // Assert
        act.Should()
            .BeEmpty();
    }

    [Fact(DisplayName = "String only one character")]
    public void CapitalizeName_OnlyOneCharacter_ReturnCapitalizedText()
    {
        // Arrange
        var input = "a";


        // Act
        var act = input.CapitalizeName();


        // Assert
        act.Should()
            .Be("A");
    }

    [Fact(DisplayName = "String one character already capitalized")]
    public void CapitalizeName_OneCharacterAlreadyCapitalized_ReturnEqualsInput()
    {
        // Arrange
        var input = "A";


        // Act
        var act = input.CapitalizeName();


        // Assert
        act.Should()
            .Be("A");
    }

    [Fact(DisplayName = "String a space before one character")]
    public void CapitalizeName_SpaceBaforeOneCharacter_ReturnCapitalizedText()
    {
        // Arrange
        var input = " a";


        // Act
        var act = input.CapitalizeName();


        // Assert
        act.Should()
            .Be(" A");
    }

    [Theory(DisplayName = "Test names")]
    [InlineData("nelson nobre", "Nelson Nobre")]
    [InlineData("jr.santos", "Jr.Santos")]
    [InlineData("abd al-uzza", "Abd Al-Uzza")]
    public void CapitalizeName_Names_ReturnCapitalizedText(string input, string expected)
    {
        // Arrange & Act
        var act = input.CapitalizeName();


        // Assert
        act.Should()
            .Be(expected);
    }
}
