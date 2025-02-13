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


        // Three tests for valid isosceles triangles
        [Test]  //Test7
        public void IdentifyTriangle_Isosceles_TwoEqualSides_ReturnsIsosceles()
        {
            int side1 = 4;
            int side2 = 4;
            int side3 = 2;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("Isosceles triangle", result);
        }

        [Test]  //Test8
        public void IdentifyTriangle_Isosceles_AnotherSet_ReturnsIsosceles()
        {
            int side1 = 7;
            int side2 = 7;
            int side3 = 5;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("Isosceles triangle", result);
        }

        [Test]  //Test9
        public void IdentifyTriangle_ValidLargeIsosceles_ReturnsIsosceles()
        {
            int side1 = 100;
            int side2 = 100;
            int side3 = 50;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("Isosceles triangle", result);
        }


    }
}
