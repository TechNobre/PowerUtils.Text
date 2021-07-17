using FluentAssertions;
using System;
using Xunit;
namespace PowerUtils.Text.Tests
{
    public class CleanExtraLineBreakTests
    {
        [Fact(DisplayName = "String only empty should return empty")]
        [Trait("Extension", "CleanExtraLineBreak")]
        public void CleanExtraLineBreak_Null_ReturnNull()
        {
            // Arrange
            string input = null;


            // Act
            var act = input.CleanExtraLineBreak();


            // Assert
            act.Should()
                .BeNull();
        }

        [Fact(DisplayName = "String only empty should return empty")]
        [Trait("Extension", "CleanExtraLineBreak")]
        public void CleanExtraLineBreak_Empty_ReturnEmpty()
        {
            // Arrange
            var input = string.Empty;


            // Act
            var act = input.CleanExtraLineBreak();


            // Assert
            act.Should()
                .BeEmpty();
        }

        [Fact(DisplayName = "String with double spaces")]
        [Trait("Extension", "CleanExtraLineBreak")]
        public void CleanExtraLineBreak_WithDoubleSpaces_resultEqualsInput()
        {
            // Arrange
            var input = "  Hello  world...    I am Nelson  Nobre  ";


            // Act
            var act = input.CleanExtraLineBreak();


            // Assert
            act.Should()
                .Be("  Hello  world...    I am Nelson  Nobre  ");
        }

        [Fact(DisplayName = "String with line breaks must keep the double spaces")]
        [Trait("Extension", "CleanExtraLineBreak")]
        public void CleanExtraLineBreak_LineBreaks_ReturnStringWithLineBreaks()
        {
            // Arrange
            var input = "  Hello  world...  " + Environment.NewLine + Environment.NewLine + "  I am Nelson  Nobre     ";


            // Act
            var act = input.CleanExtraLineBreak();


            // Assert
            act.Should()
                .Be("  Hello  world..." + Environment.NewLine + "I am Nelson  Nobre     ");
        }

        [Fact(DisplayName = "String with double line breaks - Hello world test")]
        [Trait("Extension", "CleanExtraLineBreak")]
        public void CleanExtraLineBreak_HelloWorld_ReturnStringWithoutDoubleSLineBreak()
        {
            // Arrange
            var input = "Hello\r\n\r\n\r\nWorld!!!";


            // Act
            var act = input.CleanExtraLineBreak();


            // Assert
            act.Should()
                .Be("Hello\r\nWorld!!!");
        }
    }
}