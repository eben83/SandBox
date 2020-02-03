using System;
using Xunit; //testing framework

namespace GradBook.tests
{

    public delegate string WriteLogDelegate(string logMessage);


    public class TypeTests
    {

        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log;
            log = returnMessage; // this will find the method below and use it
            var result = log("hello");
            Assert.Equal("hello", result);
        }
        string returnMessage(string message)
        {
            return message;
        }

        [Fact]

        public void ValueTypeAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);

        }

        private void SetInt(ref int z)
        {
            z = 42;
            
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef() // this unit test refreances the value.

        {
            var book1 = GetBook("Book 1");
            GetBookSetName( ref book1,"New Name");

            Assert.Equal("New Name", book1.Name);
            

        }

        private void GetBookSetName(ref Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void CSharpPassByValue() // this is a unit test

        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1,"New Name");

            Assert.Equal("Book 1", book1.Name);
            

        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameFromReferance() // this is a unit test

        {
            var book1 = GetBook("Book 1");
            SetName(book1,"New Name");

            Assert.Equal("New Name", book1.Name);
            

        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

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
