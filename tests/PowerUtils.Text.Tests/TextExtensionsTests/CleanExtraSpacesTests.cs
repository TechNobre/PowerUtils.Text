﻿using System;
using FluentAssertions;
using Xunit;

namespace PowerUtils.Text.Tests.TextExtensionsTests
{
    public class CleanExtraSpacesTests
    {
        [Fact]
        public void Null_CleanExtraSpaces_Null()
        {
            // Arrange
            string input = null;


            // Act
            var act = input.CleanExtraSpaces();


            // Assert
            act.Should()
                .BeNull();
        }

        [Fact]
        public void Empty_CleanExtraSpaces_Empty()
        {
            // Arrange
            var input = "";


            // Act
            var act = input.CleanExtraSpaces();


            // Assert
            act.Should()
                .BeEmpty();
        }

        [Fact]
        public void TwoSpaces_CleanExtraSpaces_OneSpace()
        {
            // Arrange
            var input = "  ";


            // Act
            var act = input.CleanExtraSpaces();


            // Assert
            act.Should()
                .BeEmpty();
        }

        [Fact]
        public void TwoTabs_CleanExtraSpaces_OneSpace()
        {
            // Arrange
            var input = "\t\t";


            // Act
            var act = input.CleanExtraSpaces();


            // Assert
            act.Should()
                .BeEmpty();
        }

        [Fact]
        public void WithDoubleSpaces_CleanExtraSpaces_StringWithoutDoubleSpaces()
        {
            // Arrange
            var input = "  Hello  world...    I am Nelson  Nobre  ";


            // Act
            var act = input.CleanExtraSpaces();


            // Assert
            act.Should()
                .Be("Hello world... I am Nelson Nobre");
        }

        [Fact]
        public void LineBreaks_CleanExtraSpaces_StringWithLineBreaks()
        {
            // Arrange
            var input = "  Hello  world...  " + Environment.NewLine + Environment.NewLine + "  I am Nelson  Nobre  ";


            // Act
            var act = input.CleanExtraSpaces();


            // Assert
            act.Should()
                .Be("Hello world..." + Environment.NewLine + Environment.NewLine + "I am Nelson Nobre");
        }

        [Fact]
        public void HelloWorld_CleanExtraSpaces_StringWithoutDoubleSpaces()
        {
            // Arrange
            var input = " Hello  world!!! ";


            // Act
            var act = input.CleanExtraSpaces();


            // Assert
            act.Should()
                .Be("Hello world!!!");
        }

        [Fact]
        public void HelloWorldWithTab_CleanExtraSpaces_StringWithoutTab()
        {
            // Arrange
            var input = " Hello\tworld!!! ";


            // Act
            var act = input.CleanExtraSpaces();


            // Assert
            act.Should()
                .Be("Hello world!!!");
        }
    }
}
