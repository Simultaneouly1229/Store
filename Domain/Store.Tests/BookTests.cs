using Xunit;

namespace Store.Tests
{
    public class BookTests
    {
        [Fact]
        public void IsIsbn_WithNull_ReturnFalse()
        {
            bool actual = Book.IsIsbn(null);

            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithEmpty_ReturnFalse()
        {
            bool actual = Book.IsIsbn("");

            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithInvalidIsbn_ReturnFalse()
        {
            var invalidIsbn = "ISBN 12144";

            bool actual = Book.IsIsbn(invalidIsbn);

            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithValidIsbn10_ReturnTrue()
        {
            var validIsbn = "ISBN 123-456-789-0";

            bool actual = Book.IsIsbn(validIsbn);

            Assert.True(actual);
        }

        [Fact]
        public void IsIsbn_WithValidIsbn13_ReturnTrue()
        {
            var validIsbn = "ISBN 123-456-789-123-0";

            bool actual = Book.IsIsbn(validIsbn);

            Assert.True(actual);
        }

        [Fact]
        public void IsIsbn_WithTrashStart_ReturnFalse()
        {
            var invalidIsbn = "xxx ISBN 123-456-789-123-0 yyy";

            bool actual = Book.IsIsbn(invalidIsbn);

            Assert.False(actual);
        }
    }
}