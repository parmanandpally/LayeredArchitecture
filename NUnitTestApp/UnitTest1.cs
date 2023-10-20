using ShapeLibrary;

namespace NUnitTestApp;
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void RectAreaTestMethod()
    {
        //Arrange
        Rectangle rectObj = new Rectangle();
        
        //Act
        double result = rectObj.Area(12,10);
        
        //Assert
        Assert.AreEqual(120,result);
    }

    [Test]
    public void RectPerimeterTestMethod()
    {
        Rectangle rectObj = new Rectangle();
        double result=rectObj.Perimeter(12,5);
        Assert.AreEqual(34,result);
    }

}