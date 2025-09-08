using PointsBet.StringClassLibrary;

namespace PointsBet.TestProject
{
    [TestClass]
    public sealed class StringFormatterTests
    {
        [TestMethod]
        public void StringFormatterWithValidInput()
        {
            //Arrange
            string[] items = { "grapes", "banana", "mango", "kiwi" };
            string quote = "\"";

            //Act
            var result = StringFormatter.ToCommaSeparatedList(items, quote);

            //Assert
            Assert.AreEqual("\"grapes\", \"banana\", \"mango\", \"kiwi\"", result, true);
        }

        [TestMethod]
        public void StringFormatterWithValidInputWithSingleQuote()
        {
            //Arrange
            string[] items = { "grapes", "banana", "mango", "kiwi" };
            string quote = "'";

            //Act
            var result = StringFormatter.ToCommaSeparatedList(items, quote);

            //Assert
            Assert.AreEqual("'grapes', 'banana', 'mango', 'kiwi'", result, true);
        }

        [TestMethod]
        public void StringFormatterWithValidInputWithStarAsQuote()
        {
            //Arrange
            string[] items = { "grapes", "banana", "mango", "kiwi" };
            string quote = "*";

            //Act
            var result = StringFormatter.ToCommaSeparatedList(items, quote);

            //Assert
            Assert.AreEqual("*grapes*, *banana*, *mango*, *kiwi*", result, true);
        }

        [TestMethod]
        public void StringFormatterWithNullArray()
        {
            //Arrange
            string[] items = null;
            string quote = "*";

            //Act
            var result = StringFormatter.ToCommaSeparatedList(items, quote);

            //Assert
            Assert.AreEqual(string.Empty, result, true);
        }

        [TestMethod]
        public void StringFormatterWithNullQuote()
        {
            //Arrange
            string[] items = { "grapes", "banana", "mango", "kiwi" };
            string quote = null;

            //Act
            var result = StringFormatter.ToCommaSeparatedList(items, quote);

            //Assert
            Assert.AreEqual("grapes, banana, mango, kiwi", result, true);
        }

        [TestMethod]
        public void StringFormatterWithEmptyArray()
        {
            //Arrange
            string[] items = [];
            string quote = "\"";

            //Act
            var result = StringFormatter.ToCommaSeparatedList(items, quote);

            //Assert
            Assert.AreEqual(string.Empty, result, true);
        }

        [TestMethod]
        public void StringFormatterWithEmptyQuote()
        {
            //Arrange
            string[] items = { "grapes", "banana", "mango", "kiwi" };
            string quote = string.Empty;

            //Act
            var result = StringFormatter.ToCommaSeparatedList(items, quote);

            //Assert
            Assert.AreEqual("grapes, banana, mango, kiwi", result, true);
        }

        [TestMethod]
        public void StringFormatterWithSpecialChars()
        {
            //Arrange
            string[] items = { "gra'pes", "ban\"ana", "ma/ngo", "ki\\wi" };
            string quote = "\"";

            //Act
            var result = StringFormatter.ToCommaSeparatedList(items, quote);

            //Assert
            Assert.AreEqual("\"gra'pes\", \"ban\"ana\", \"ma/ngo\", \"ki\\wi\"", result, true);
        }



        #region LargeArray Test Cases
        //const int largeArraySize = 9000000;
        //string[] largeItems = new string[largeArraySize];
        //string largeItemsResult = string.Empty;

        //[TestInitialize]
        //public void TestSetUp()
        //{
        //    for (int i = 0; i < largeArraySize; i++)
        //    {
        //        largeItems[i] = i % 2 == 0 ?
        //            "even index number hgasdhga asgdjasgdjasgd ajsdhasg asdjka" + i :
        //            "odd index number asghzda asdjas jshgdf akjshd kjashd" + i;
        //    }
        //    largeItemsResult = string.Join(", ", largeItems.Select(item => $"\"{item}\""));
        //}

        //[TestMethod]
        //public void StringFormatterWithLargeArray()
        //{
        //    //Arrange       
        //    string quote = "\""; // Use only double quote delimiter for large arrays, as large array result is generated using docuble quotes.

        //    //Act
        //    var result = StringFormatter.ToCommaSeparatedList(largeItems, quote);

        //    //Assert
        //    Assert.AreEqual(largeItemsResult, result, true);
        //}

        //[TestMethod]
        //public void StringFormatterWithLargeArrayWithStringBuilder()
        //{
        //    //Arrange       
        //    string quote = "\""; // Use only double quote delimiter for large arrays, as large array result is generated using docuble quotes.

        //    //Act
        //    var result = StringFormatter.ToCommaSeparatedListWithStringBuilder(largeItems, quote);

        //    //Assert
        //    Assert.AreEqual(largeItemsResult, result, true);
        //} 
        #endregion
    }
}
