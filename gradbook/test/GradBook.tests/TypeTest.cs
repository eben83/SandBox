using System;
using Xunit; //testing framework

namespace GradBook.tests
{
    public class TypeTests
    {
        [Fact]
        public void GetBookReturnsDifferentObjects() // this is a unit test

        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);

        }

        [Fact]
        public void TwoVariablesCanReferanceSameObject() // this is a unit test

        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2); // Xunit to see if var is the same value
            Assert.True(object.ReferenceEquals(book2, book1));

        }
        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
