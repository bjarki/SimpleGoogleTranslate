using NUnit.Framework;

namespace SimpleGoogleTranslate.Tests
{
    [TestFixture]
    public class GoogleTranslateStringParser_Tests
    {
        [Test]
        public void Is_Space_Before_Dot_Removed()
        {
            // Arrange
            const string input = "input string .";
            const string expected = "input string.";
            var actual = "";

            // Act
            actual = GoogleTranslateStringParser.Fix(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Is_Space_Before_dash_Removed()
        {
            // Arrange
            const string input = "input string ,";
            const string expected = "input string,";
            var actual = "";

            // Act
            actual = GoogleTranslateStringParser.Fix(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Are_Curly_Brackets_Spaces_fixed()
        {
            // Arrange
            const string input = "( { 0 } : { 1 } )";
            const string expected = "({0}:{1})";
            var actual = "";

            // Act
            actual = GoogleTranslateStringParser.Fix(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Is_Space_Before_Colon_Removed()
        {
            // Arrange
            const string input = "Some : Stuff";
            const string expected = "Some: Stuff"; 
            var actual = "";

            // Act
            actual = GoogleTranslateStringParser.Fix(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Is_Space_Before_Equal_Removed()
        {
            // Arrange
            const string input = "Some = Stuff";
            const string expected = "Some= Stuff";
            var actual = "";

            // Act
            actual = GoogleTranslateStringParser.Fix(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Is_Space_around_minus_Removed()
        {
            // Arrange
            const string input = "Some - Stuff";
            const string expected = "Some-Stuff";
            string actual;

            // Act
            actual = GoogleTranslateStringParser.Fix(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Is_Space_left_on_at_end_of_string()
        {
            // Arrange
            const string input = "Some - Stuff ";
            const string expected = "Some-Stuff ";
            string actual;

            // Act
            actual = GoogleTranslateStringParser.Fix(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}