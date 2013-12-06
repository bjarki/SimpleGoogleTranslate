using NUnit.Framework;

namespace SimpleGoogleTranslate.Tests
{
    [TestFixture]
    public class GoogleTranslator_Tests
    {
        [Test]
        public void Is_and_symbol_handeld()
        {
            // Arrange
            const string input = "Sort &Ascending {0}{1}";
            const string expected = "Sorter &Stigende {0}{1}";
            var actual = "";
            var translator = new GoogleTranslator();

            // Act
            actual = translator.Translate("en", "no", input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Is_Space_left_on_at_end_of_string()
        {
            // Arrange
            const string input = "Some Stuff ";
            const string expected = "noen Stuff ";
            string actual = "";
            var translator = new GoogleTranslator();

            // Act
            actual = translator.Translate("en", "no", input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}