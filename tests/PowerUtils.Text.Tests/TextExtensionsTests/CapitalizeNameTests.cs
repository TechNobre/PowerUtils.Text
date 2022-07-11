namespace PowerUtils.Text.Tests.TextExtensionsTests;

public class CapitalizeNameTests
{
    [Fact]
    public void Null_CompressText_Null()
    {
        // Arrange
        string input = null;


        // Act
        var act = input.CapitalizeName();


        // Assert
        act.Should()
            .BeNull();
    }

    [Fact]
    public void Empty_CapitalizeName_Empty()
    {
        // Arrange
        var input = "";


        // Act
        var act = input.CapitalizeName();


        // Assert
        act.Should()
            .BeEmpty();
    }

    [Fact]
    public void OnlyOneCharacter_CapitalizeName_CapitalizedText()
    {
        // Arrange
        var input = "a";


        // Act
        var act = input.CapitalizeName();


        // Assert
        act.Should()
            .Be("A");
    }

    [Fact]
    public void OneCharacterAlreadyCapitalized_CapitalizeName_EqualsInput()
    {
        // Arrange
        var input = "A";


        // Act
        var act = input.CapitalizeName();


        // Assert
        act.Should()
            .Be("A");
    }

    [Fact]
    public void SpaceBaforeOneCharacter_CapitalizeName_CapitalizedText()
    {
        // Arrange
        var input = " a";


        // Act
        var act = input.CapitalizeName();


        // Assert
        act.Should()
            .Be(" A");
    }

    [Theory]
    [InlineData("nelson nobre", "Nelson Nobre")]
    [InlineData("jr.santos", "Jr.Santos")]
    [InlineData("abd al-uzza", "Abd Al-Uzza")]
    [InlineData("'abd al-rahmān", "'Abd Al-Rahmān")]
    [InlineData(" 'abd al-'rahmān", " 'Abd Al-'Rahmān")]
    public void Names_CapitalizeName_CapitalizedText(string input, string expected)
    {
        // Arrange & Act
        var act = input.CapitalizeName();


        // Assert
        act.Should()
            .Be(expected);
    }
}
