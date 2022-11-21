using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragAndDrop.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using WebDriver = DragAndDrop.Driver.WebDriver;

namespace DragAndDrop.DragAndDropPage
{
    public class DragAndDropPages
    {
        private IWebDriver driver = WebDriver.Instance;

        public IWebElement Drag => driver.FindElement(By.Id("draggable"));
        public IWebElement Drop => driver.FindElement(By.Id("droppable"));

        public void MoveObject()
        {
            var builder = new Actions(driver);
            var dragandDrop = builder.ClickAndHold(Drag).MoveToElement(Drop).Release(Drag).Build();
            dragandDrop.Perform();
        }


    }
}
