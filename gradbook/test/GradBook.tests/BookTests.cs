using System;
using Xunit; //testing framework

namespace GradBook.tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade() // this is a unit test

        {
            //arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);
           
            // act
            var result = book.GetStats();



            //assert
            Assert.Equal(85.6,result.Average, 1); // the 3rd perameter is the decimal point value
            Assert.Equal(90.5,result.High, 1);
            Assert.Equal(77.3,result.low, 1);

        }
    }
}
