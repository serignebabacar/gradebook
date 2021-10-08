using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTest
    {
        [Fact]
        public void TestName()
        {
            var book = InitialisationBook();
            Assert.Equal("AL", book.GetName());
        }
        [Fact]
        public void TestCountListeGrades()
        {   
            var book = InitialisationBook();
            Assert.True(0 == book.GetGrades().Count);
            InitialisationCollectionOfBook(book);
            Assert.True(3 == book.GetGrades().Count);
        }
        private static void InitialisationCollectionOfBook(Book book)
        {
            book.AddGrade(10);
            book.AddGrade(11);
            book.AddGrade(12);
        }
        [Fact]
        public void TestAverage()
        {
            var book = InitialisationBook();
            InitialisationCollectionOfBook(book);
            Assert.Equal(11, book.GetStatistics().Average);
        }
        [Fact]
        public void TestMin()
        {
            var book = InitialisationBook();
            InitialisationCollectionOfBook(book);
            Assert.Equal(10, book.GetStatistics().LowValue);
        }
        [Fact]
        public void TestMax()
        {
            Book book = InitialisationBook();
            InitialisationCollectionOfBook(book);
            Assert.Equal(12, book.GetStatistics().HighValue);
        }
        private static Book InitialisationBook()
        {
            return new Book("AL");
        }
        private static Book InitialisationBook(string name)
        {
            return new Book(name);
        }
        [Fact]
        public void TypeTest()
        {
            var book1 = InitialisationBook("Book 1");
            var book2 = InitialisationBook("Book 2");
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book2, book1);

        }
        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = InitialisationBook("Book 1");
            var book2 = book1;
            Assert.Same(book2, book1);
        }

        [Fact]
        public void CsharpIsPassByValue()
        {
            var book1 = InitialisationBook("Book 1");
            GetBookSetName(ref book1, "New Name");
            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(ref Book book1, string v)
        {
            book1 = new Book(v);
            book1.Name = v;
        }
        [Fact]
        public void TestGetInt()
        {
            var x = GetInt();
             SetInt(ref x);
            Assert.Equal(4,x);
        }
        private void SetInt(ref int v)
        {
            v = 4;
        }
        public int GetInt()
        {
            return 3;
        }
        [Fact]
        public void StringBehaviourLikeValueTypes()
        {
            string name = "babacar"; 
            name = MakeUppercase(name);
            Assert.Equal("BABACAR", name);
        }

        private string MakeUppercase( string name)
        {
            return name.ToUpper();
        }
        [Fact]
        public void TestLevel()
        {
            var book = InitialisationBook();
            InitialisationCollectionOfBook(book);
            Assert.Equal('E', book.GetStatistics().Level);
        }
    }
}
