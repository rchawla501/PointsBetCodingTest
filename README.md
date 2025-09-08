# PointsBetCodingTest
Project structure
- PointsBetCodingTest Solution
   - PointsBet.StringClassLibrary: Contains the original class StringFormattor.cs with modified code
   - PointsBet.Project: Contains Microsoft Tests
Notes:
There are 2 static methods in the stringformatter class. One uses the StringBuilder approach and the second one uses the Join method.
StringBuilder is the best suited for multiple string concatenations.
String Join is simple and short syntax for string concatenations.
For small arrays we can use any of the above methods. String builder is meant to be high performant in large datasets. But both String.Join and StrinBuilder are at par for string concatenation in out case.
There are few test cases added in test project.
