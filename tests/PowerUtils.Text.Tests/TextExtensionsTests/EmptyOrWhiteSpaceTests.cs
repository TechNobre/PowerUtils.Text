using System;
using FluentAssertions;
using Xunit;

namespace PowerUtils.Text.Tests.TextExtensionsTests
{
    public class EmptyOrWhiteSpaceTests
    {
        [Fact]
        [Obsolete]
        public void Null_EmptyOrWhiteSpace_Null()
        {
            // Arrange
            string input = null;


            // Act
            var act = input.EmptyOrWhiteSpace();


            // Assert
            act.Should()
                .BeNull();
        }

        [Fact]
        [Obsolete]
        public void Empty_EmptyOrWhiteSpace_Null()
        {
            // Arrange
            var input = "";


            // Act
            var act = input.EmptyOrWhiteSpace();


            // Assert
            act.Should()
                .BeNull();
        }

        [Fact]
        [Obsolete]
        public void WithWhiteSpaces_EmptyOrWhiteSpace_Null()
        {
            // Arrange
            var input = "       ";


            // Act
            var act = input.EmptyOrWhiteSpace();


            // Assert
            act.Should()
                .BeNull();
        }

        [Fact]
        [Obsolete]
        public void Filled_EmptyOrWhiteSpace_EqualsInput()
        {
            // Arrange
            var input = " Hello world!!   ";


            // Act
            var act = input.EmptyOrWhiteSpace();


            // Assert
            act.Should()
                .Be(" Hello world!!   ");
        }
    }
}
