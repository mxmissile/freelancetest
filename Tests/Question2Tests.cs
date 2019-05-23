using System;
using NUnit.Framework;
using WebApp.App;

namespace Tests
{
    public class Question2Tests
    {
        [Test]
        public void ReversString_actually_reverses_string()
        {
            // arrange
            var sut = new Question2();
            const string value = "canyon";
            const string expected = "noynac";

            // act 
            var result = sut.ReverseString(value);

            // assert
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void ReverseString_throws_with_null()
        {
            // arrange
            var sut = new Question2();

            // act assert
            Assert.Throws<NullReferenceException>(() => { sut.ReverseString(null); });
        }

        [Test]
        public void ReverseString_throws_with_empty()
        {
            // arrange
            var sut = new Question2();
            const string value = "";

            // act assert
            Assert.Throws<ArgumentException>(() => { sut.ReverseString(value); });
        }
    }
}
