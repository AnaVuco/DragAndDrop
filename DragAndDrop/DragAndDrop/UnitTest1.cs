using DragAndDrop.DragAndDropPage;
using DragAndDrop.Driver;

namespace DragAndDrop
{
    public class Tests
    {
        DragAndDropPages dragAndDrop;

        [SetUp]
        public void Setup()
        {
            WebDriver.Initialize();
            dragAndDrop = new DragAndDropPages();
        }
        
        [TearDown]

        public void Close()
        {
            WebDriver.CleanUp();
        }
        [Test]
        public void Test1()
        {
            dragAndDrop.MoveObject();

           
        }
    }
}