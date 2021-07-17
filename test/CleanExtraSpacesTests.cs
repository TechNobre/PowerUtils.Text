using FluentAssertions;
using System;
using Xunit;

namespace PowerUtils.Text.Tests
{
    public class CleanExtraSpacesTests
    {
        [Fact(DisplayName = "String only empty should return null")]
        [Trait("Extension", "CleanExtraSpaces")]
        public void CleanExtraSpaces_Null_ReturnNull()
        {
            // Arrange
            string input = null;


            // Act
            var act = input.CleanExtraSpaces();


            // Assert
            act.Should()
                .BeNull();
        }

        [Fact(DisplayName = "String only empty should return empty")]
        [Trait("Extension", "CleanExtraSpaces")]
        public void CleanExtraSpaces_Empty_ReturnEmpty()
        {
            // Arrange
            var input = string.Empty;


            // Act
            var act = input.CleanExtraSpaces();


            // Assert
            act.Should()
                .BeEmpty();
        }

        [Fact(DisplayName = "String with double spaces")]
        [Trait("Extension", "CleanExtraSpaces")]
        public void CleanExtraSpaces_WithDoubleSpaces_ReturnStringWithoutDoubleSpaces()
        {
            // Arrange
            var input = "  Hello  world...    I am Nelson  Nobre  ";


            // Act
            var act = input.CleanExtraSpaces();


            // Assert
            act.Should()
                .Be("Hello world... I am Nelson Nobre");
        }

        [Fact(DisplayName = "String with line breaks must keep the line breaks")]
        [Trait("Extension", "CleanExtraSpaces")]
        public void CleanExtraSpaces_LineBreaks_ReturnStringWithLineBreaks()
        {
            // Arrange
            var input = "  Hello  world...  " + Environment.NewLine + Environment.NewLine + "  I am Nelson  Nobre  ";


            // Act
            var act = input.CleanExtraSpaces();


            // Assert
            act.Should()
                .Be("Hello world..." + Environment.NewLine + Environment.NewLine + "I am Nelson Nobre");
        }

        [Fact(DisplayName = "String with double spaces - Hello world test")]
        [Trait("Extension", "CleanExtraSpaces")]
        public void CleanExtraSpaces_HelloWorld_ReturnStringWithoutDoubleSpaces()
        {
            // Arrange
            var input = " Hello  world!!! ";


            // Act
            var act = input.CleanExtraSpaces();


            // Assert
            act.Should()
                .Be("Hello world!!!");
        }
    }
}