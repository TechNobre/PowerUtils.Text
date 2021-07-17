using FluentAssertions;
using System;
using Xunit;

namespace PowerUtils.Text.Tests
{
    public class CleanExtraLineBreakAndLineBreakTests
    {
        [Fact(DisplayName = "String null should return empty")]
        [Trait("Extension", "CleanExtraLineBreakAndLineBreak")]
        public void CleanExtraLineBreakAndLineBreak_Null_ReturnNull()
        {
            // Arrange
            string input = null;


            // Act
            var act = input.CleanExtraLineBreakAndLineBreak();


            // Assert
            act.Should()
                .BeNull();
        }

        [Fact(DisplayName = "String only empty should return empty")]
        [Trait("Extension", "CleanExtraLineBreakAndLineBreak")]
        public void CleanExtraLineBreakAndLineBreak_Empty_ReturnEmpty()
        {
            // Arrange
            var input = string.Empty;


            // Act
            var act = input.CleanExtraLineBreakAndLineBreak();


            // Assert
            act.Should()
                .BeEmpty();
        }

        [Fact(DisplayName = "String with double spaces")]
        [Trait("Extension", "CleanExtraLineBreakAndLineBreak")]
        public void CleanExtraLineBreakAndLineBreak_WithDoubleSpaces_resultEqualsInput()
        {
            // Arrange
            var input = "  Hello  world...    I am Nelson  Nobre  ";


            // Act
            var act = input.CleanExtraLineBreakAndLineBreak();


            // Assert
            act.Should()
                .Be("Hello world... I am Nelson Nobre");
        }

        [Fact(DisplayName = "String with line breaks must keep the double spaces")]
        [Trait("Extension", "CleanExtraLineBreakAndLineBreak")]
        public void CleanExtraLineBreakAndLineBreak_LineBreaks_ReturnStringWithLineBreaks()
        {
            // Arrange
            var input = "  Hello  world...  " + Environment.NewLine + Environment.NewLine + "  I am Nelson  Nobre     ";


            // Act
            var act = input.CleanExtraLineBreakAndLineBreak();


            // Assert
            act.Should()
                .Be("Hello world..." + Environment.NewLine + "I am Nelson Nobre");
        }

        [Fact(DisplayName = "String with double spaces and line breaks - Hello world test")]
        [Trait("Extension", "CleanExtraLineBreakAndLineBreak")]
        public void CleanExtraLineBreakAndLineBreak_HelloWorld_ReturnStringWithoutDoubleSLineBreakAndDoubleSplaces()
        {
            // Arrange
            var input = "   Hello \r\n\r\n\r\n  World!!! ";


            // Act
            var act = input.CleanExtraLineBreakAndLineBreak();


            // Assert
            act.Should()
                .Be("Hello\r\nWorld!!!");
        }
    }
}