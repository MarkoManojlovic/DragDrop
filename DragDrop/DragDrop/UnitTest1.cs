using DragDrop.Driver;
using DragDrop.Page;

namespace DragDrop
{
    public class Tests
    {
        DragandDropPage dragAndDrop;

        [SetUp]
        public void Setup()
        {
            WebDriver.Instalize();
            dragAndDrop = new DragandDropPage();
        }

        [Test]
        public void Test1()
        {
            dragAndDrop.MoveObject();
            
        }
    }
}