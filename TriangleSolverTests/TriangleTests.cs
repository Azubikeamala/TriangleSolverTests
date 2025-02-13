using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolverTests
{
    [TestFixture]
    public class TriangleTests
    {

        //Test1 (For a valid equilateral triangle)

        [Test]
        public void IdentifyTriangle_Equilateral_ReturnsEquilateral()
        {
            // Arrange
            int side1 = 7;
            int side2 = 7;
            int side3 = 7;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Equilateral triangle", result);
        }

        // Five tests for valid scalene triangles
        [Test] //Test2
        public void IdentifyTriangle_Scalene_AllDifferentSides_ReturnsScalene()
        {
            int side1 = 5;
            int side2 = 6;
            int side3 = 7;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("Scalene triangle", result);
        }

        [Test] //Test3
        public void IdentifyTriangle_Scalene_AnotherSet_ReturnsScalene()
        {
            int side1 = 8;
            int side2 = 9;
            int side3 = 10;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("Scalene triangle", result);
        }

        [Test] //Test4
        public void IdentifyTriangle_Scalene_DifferentSet_ReturnsScalene()
        {
            int side1 = 11;
            int side2 = 13;
            int side3 = 16;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("Scalene triangle", result);
        }

        [Test]  //Test5
        public void IdentifyTriangle_Scalene_AnotherVariation_ReturnsScalene()
        {
            int side1 = 6;
            int side2 = 8;
            int side3 = 9;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("Scalene triangle", result);
        }

        [Test]  //Test6
        public void IdentifyTriangle_Scalene_AnotherCase_ReturnsScalene()
        {
            int side1 = 7;
            int side2 = 11;
            int side3 = 9;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("Scalene triangle", result);
        }



    }
}
