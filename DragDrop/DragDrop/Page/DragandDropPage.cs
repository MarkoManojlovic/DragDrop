
using DragDrop.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver = DragDrop.Driver.WebDriver;

namespace DragDrop.Page
{
    public class DragandDropPage
    {
        private IWebDriver driver = WebDriver.Instance;

        public IWebElement Drag => driver.FindElement(By.Id("draggable"));
        public IWebElement Drop => driver.FindElement(By.Id("droppable"));


        public void MoveObject()
        {
            var builder = new Actions(driver);
            var dragAndDrop = builder.ClickAndHold(Drag).MoveToElement(Drop).Release(Drag).Build();
            dragAndDrop.Perform();
        }
    }
}
