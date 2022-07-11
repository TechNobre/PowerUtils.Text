using System;

namespace PowerUtils.Text.Tests.TextExtensionsTests;

public class CleanExtraLineBreakAndLineBreakTests
{
    [Fact]
    public void Null_CleanExtraLineBreakAndLineBreak_Null()
    {
        // Arrange
        string input = null;


        // Act
        var act = input.CleanExtraLineBreakAndLineBreak();


        // Assert
        act.Should()
            .BeNull();
    }

    [Fact]
    public void Empty_CleanExtraLineBreakAndLineBreak_Empty()
    {
        // Arrange
        var input = "";


        // Act
        var act = input.CleanExtraLineBreakAndLineBreak();


        // Assert
        act.Should()
            .BeEmpty();
    }

    [Fact]
    public void WithDoubleSpaces_CleanExtraLineBreakAndLineBreak_EqualsInput()
    {
        // Arrange
        var input = "  Hello  world...    I am Nelson  Nobre  ";


        // Act
        var act = input.CleanExtraLineBreakAndLineBreak();


        // Assert
        act.Should()
            .Be("Hello world... I am Nelson Nobre");
    }

    [Fact]
    public void LineBreaks_CleanExtraLineBreakAndLineBreak_StringWithLineBreaks()
    {
        // Arrange
        var input = "  Hello  world...  " + Environment.NewLine + Environment.NewLine + "  I am Nelson  Nobre     ";


        // Act
        var act = input.CleanExtraLineBreakAndLineBreak();


        // Assert
        act.Should()
            .Be("Hello world..." + Environment.NewLine + "I am Nelson Nobre");
    }

    [Fact]
    public void HelloWorld_CleanExtraLineBreakAndLineBreak_StringWithoutDoubleLineBreakAndDoubleSplaces()
    {
        // Arrange
        var input = "   Hello " + Environment.NewLine + Environment.NewLine + Environment.NewLine + "  World!!! ";


        // Act
        var act = input.CleanExtraLineBreakAndLineBreak();


        // Assert
        act.Should()
            .Be("Hello" + Environment.NewLine + "World!!!");
    }
}
