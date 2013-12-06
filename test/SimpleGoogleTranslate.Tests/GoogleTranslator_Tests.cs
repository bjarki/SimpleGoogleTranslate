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
            actual = translator.Translate("en", "no", input, true);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}