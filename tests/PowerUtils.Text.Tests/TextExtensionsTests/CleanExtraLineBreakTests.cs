using System;
using FluentAssertions;
using Xunit;

namespace PowerUtils.Text.Tests.TextExtensionsTests
{
    public class CleanExtraLineBreakTests
    {
        [Fact]
        public void Null_CleanExtraLineBreak_Null()
        {
            // Arrange
            string input = null;


            // Act
            var act = input.CleanExtraLineBreak();


            // Assert
            act.Should()
                .BeNull();
        }

        [Fact]
        public void Empty_CleanExtraLineBreak_Empty()
        {
            // Arrange
            var input = "";


            // Act
            var act = input.CleanExtraLineBreak();


            // Assert
            act.Should()
                .BeEmpty();
        }

        [Fact]
        public void WithDoubleSpaces_CleanExtraLineBreak_EqualsInput()
        {
            // Arrange
            var input = "  Hello  world...    I am Nelson  Nobre  ";


            // Act
            var act = input.CleanExtraLineBreak();


            // Assert
            act.Should()
                .Be("  Hello  world...    I am Nelson  Nobre  ");
        }

        [Fact]
        public void LineBreaks_CleanExtraLineBreak_StringWithLineBreaks()
        {
            // Arrange
            var input = "  Hello  world...  " + Environment.NewLine + Environment.NewLine + "  I am Nelson  Nobre     ";


            // Act
            var act = input.CleanExtraLineBreak();


            // Assert
            act.Should()
                .Be("  Hello  world...  " + Environment.NewLine + "  I am Nelson  Nobre     ");
        }

        [Fact]
        public void HelloWorld_CleanExtraLineBreak_StringWithoutDoubleSLineBreak()
        {
            // Arrange
            var input = "Hello" + Environment.NewLine + Environment.NewLine + Environment.NewLine + "World!!!";


            // Act
            var act = input.CleanExtraLineBreak();


            // Assert
            act.Should()
                .Be("Hello" + Environment.NewLine + "World!!!");
        }
    }
}
