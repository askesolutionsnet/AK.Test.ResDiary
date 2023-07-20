namespace AK.Test.ResDiary.Tests;

[TestClass]
public class ArrayDividerTests
{
    private IGroupArrayDivider groupArrayDivider;

    [TestInitialize]
    public void Setup()
    {
        groupArrayDivider = new GroupArrayDivider();
    }

    [TestMethod]
    public void TestArrayDivisionWithEqualChunks()
    {
        // Arrange
        int[] inputArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int N = 4;
        List<List<int>> expectedResult = new List<List<int>>
    {
        new List<int> { 1, 2 },
        new List<int> { 3, 4 },
        new List<int> { 5, 6 },
        new List<int> { 7, 8 }
    };

        // Act
        List<List<int>> result = groupArrayDivider.GroupArrayElements(inputArray, N);

        // Assert
        CollectionAssert.AreEqual(expectedResult[0], result[0]);
        CollectionAssert.AreEqual(expectedResult[1], result[1]);
        CollectionAssert.AreEqual(expectedResult[2], result[2]);
        CollectionAssert.AreEqual(expectedResult[3], result[3]);
    }

    [TestMethod]
    public void TestArrayDivisionWithUnequalChunks()
    {
        // Arrange
        int[] inputArray = { 1, 2, 3, 4, 5 };
        int N = 3;
        List<List<int>> expectedResult = new List<List<int>>
        {
            new List<int> { 1, 2 },
            new List<int> { 3, 4 },
            new List<int> { 5 }
        };

        // Act
        List<List<int>> result = groupArrayDivider.GroupArrayElements(inputArray, N);

        // Assert
        CollectionAssert.AreEqual(expectedResult[0], result[0]);
        CollectionAssert.AreEqual(expectedResult[1], result[1]);
        CollectionAssert.AreEqual(expectedResult[2], result[2]);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestInvalidNValueThrowsException()
    {
        // Arrange
        int[] inputArray = { 1, 2, 3, 4, 5 };
        int N = 0;

        // Act and Assert
        groupArrayDivider.GroupArrayElements(inputArray, N);
    }
}