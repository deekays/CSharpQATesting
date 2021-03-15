using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDraperAssignment2;
using NUnit.Framework;


namespace Assignment2Tester
{
    public class RectangleTest
    {
        [TestFixture]
        public class RectangleTester
        {
            // Test rectangle constructed with length 5
            [Test]
            public void GetLengthConstruct5Return5()
            {
                // Arrange 
                Rectangle rectangle = new Rectangle(5, 1);

                int expected = 5;

                // Act
                int actual = rectangle.GetLength();

                // Assert
                Assert.AreEqual(expected, actual);

            }

            // Test rectangle constructed with length 0
            [Test]
            public void GetLengthConstruct0ReturnError()
            {
                // Arrange 
                Rectangle rectangle = new Rectangle(0, 1);

                int expected = 0;

                // Act
                int actual = rectangle.GetLength();

                // Assert
                Assert.AreEqual(expected, actual);  // This works because the error handling isn't on this end
            }

            // Test rectangle constructed with length -5
            [Test]
            public void GetLengthConstructNeg5ReturnNeg5()
            {
                // Arrange 
                Rectangle rectangle = new Rectangle(-5, 1);

                int expected = -5;

                // Act
                int actual = rectangle.GetLength();

                // Assert
                Assert.AreEqual(expected, actual);

            }

            // Test set length to 2
            [Test]
            public void SetLength2Return2()
            {
                // Arrange
                Rectangle rectangle = new Rectangle();
                rectangle.SetLength(2);
                int expected = 2;

                // Act
                int actual = rectangle.GetLength();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            // Test set length to 0
            [Test]
            public void SetLength0Return0()
            {
                // Arrange
                Rectangle rectangle = new Rectangle();
                rectangle.SetLength(0);
                int expected = 0;

                // Act
                int actual = rectangle.GetLength();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            // Test set length to -10
            [Test]
            public void SetLengthNeg10ReturnNeg10()
            {
                // Arrange
                Rectangle rectangle = new Rectangle();
                rectangle.SetLength(-10);
                int expected = -10;

                // Act
                int actual = rectangle.GetLength();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            // Test rectangle constructed with width 7
            [Test]
            public void GetWidthConstruct7Return7()
            {
                // Arrange 
                Rectangle rectangle = new Rectangle(1, 7);

                int expected = 7;

                // Act
                int actual = rectangle.GetWidth();

                // Assert
                Assert.AreEqual(expected, actual);

            }

            // Test rectangle constructed with width 0
            [Test]
            public void GetWidthConstruct0Return0()
            {
                // Arrange 
                Rectangle rectangle = new Rectangle(1, 0);

                int expected = 0;

                // Act
                int actual = rectangle.GetWidth();

                // Assert
                Assert.AreEqual(expected, actual);

            }

            // Test rectangle constructed with width -9
            [Test]
            public void GetWidthConstructNeg9ReturnNeg9()
            {
                // Arrange 
                Rectangle rectangle = new Rectangle(1, -9);

                int expected = -9;

                // Act
                int actual = rectangle.GetWidth();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            // Test set width to 88
            [Test]
            public void SetWidth88Return88()
            {
                // Arrange 
                Rectangle rectangle = new Rectangle();
                rectangle.SetWidth(88);
                int expected = 88;

                // Act
                int actual = rectangle.GetWidth();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            // Test set width to 0
            [Test]
            public void SetWidth0Return0()
            {
                // Arrange 
                Rectangle rectangle = new Rectangle();
                rectangle.SetWidth(0);
                int expected = 0;

                // Act
                int actual = rectangle.GetWidth();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            // Test set width to -32
            [Test]
            public void SetWidthNeg32ReturnNeg32()
            {
                // Arrange 
                Rectangle rectangle = new Rectangle();
                rectangle.SetWidth(-32);
                int expected = -32;

                // Act
                int actual = rectangle.GetWidth();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            // Test perimeter with default values of 1,1
            [Test]
            public void GetPerimeterDefaultConstructorReturn4()
            {
                // Arrange
                Rectangle rectangle = new Rectangle();

                int expected = 4;

                // Act
                int actul = rectangle.GetPerimeter();

                // Assert
                Assert.AreEqual(expected, actul);
            }

            // Test perimeter with values of 10,10
            [Test]
            public void GetPerimeterSet10and10Return40()
            {
                // Arrange
                Rectangle rectangle = new Rectangle(10,10);

                int expected = 40;

                // Act
                int actul = rectangle.GetPerimeter();

                // Assert
                Assert.AreEqual(expected, actul);
            }

            // Test perimeter with values of 2,4
            [Test]
            public void GetPerimeterSet2and4Return12()
            {
                // Arrange
                Rectangle rectangle = new Rectangle(2, 4);

                int expected = 12;

                // Act
                int actul = rectangle.GetPerimeter();

                // Assert
                Assert.AreEqual(expected, actul);
            }

            // Test area with default values of 1,1
            [Test]
            public void GetAreaDefaultConstructorReturn1()
            {
                // Arrange
                Rectangle rectangle = new Rectangle();

                int expected = 1;

                // Act
                int actul = rectangle.GetArea();

                // Assert
                Assert.AreEqual(expected, actul);
            }

            // Test area with vales of 5,6
            [Test]
            public void GetAreaSet5and6Return30()
            {
                // Arrange
                Rectangle rectangle = new Rectangle(5,6);

                int expected = 30;

                // Act
                int actul = rectangle.GetArea();

                // Assert
                Assert.AreEqual(expected, actul);
            }

            // Test area with default values of 12,12
            [Test]
            public void GetAreaSet12and12Return144()
            {
                // Arrange
                Rectangle rectangle = new Rectangle(12,12);

                int expected = 144;

                // Act
                int actul = rectangle.GetArea();

                // Assert
                Assert.AreEqual(expected, actul);
            }

        }
    }
}
