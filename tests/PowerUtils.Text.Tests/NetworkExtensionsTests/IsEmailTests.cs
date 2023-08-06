using FluentAssertions;
using Xunit;

namespace PowerUtils.Text.Tests.NetworkExtensionsTests
{
    public class IsEmailTests
    {
        [Theory]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData("fake@fake..com", false)]
        [InlineData("fake@.com", false)]
        [InlineData("@fake.com", false)]
        [InlineData("fake@fake.com", true)]
        [InlineData("fake@fake.com.co", true)]
        [InlineData("nelson", false)]
        [InlineData("nelson.nobre", false)]
        [InlineData("nelson.nobre@", false)]
        [InlineData("nelson.nobre@.com", false)]
        [InlineData("nelson.nobre@..com", false)]
        [InlineData("nelson.nobre@fake..com", false)]
        [InlineData("nelson.nobre@@fake.com", false)]
        [InlineData("n,nobre@@fake.com", false)]
        [InlineData("nelson.nobre@fake.com", true)]
        [InlineData("nelson.nobre-@fake.com", true)]
        [InlineData("nelson.nobre@fake.com.br", true)]
        [InlineData("nelson.nobre@fake.", false)]
        [InlineData("nelson.nobre@fake.com.", false)]
        [InlineData("nelson.nobre@fake.c0", true)]
        [InlineData("´nelson@fake.com", false)]
        [InlineData("nelson@fake", false)]
        [InlineData("nelson@fake.xn--6frz82g", true)]
        [InlineData("nelson@fake.pt6", true)]
        [InlineData("nelson@fake.6pt", true)]
        public void AnyString_Validate_IfIsEmail(string email, bool expected)
        {
            // Arrange & Act
            var act = email.IsEmail();


            // Assert
            act.Should()
                .Be(expected);
        }
    }
}
