using System;
using NUnit.Framework;
using WebApp.App;

namespace Tests
{
    public class Question1Tests
    {
        [Test]
        public void GetDate_accepts_valid_date_value()
        {
            // arrange
            var sut = new Question1();
            const int value = 20150531;
            var expected = new DateTime(2015, 5, 31);

            // act
            var result = sut.GetDate(value);

            // assert
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void GetDate_throws_with_invalid_date_value()
        {
            // arrange
            var sut = new Question1();
            const int value = 20159931;

            // act assert
            Assert.Throws<FormatException>(() => { sut.GetDate(value); });
        }
    }
}