using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeliveryServiceManagementSystem;
using DeliveryServiceManagementSystem.Controllers;

namespace DeliveryServiceManagementSystem.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void addDriver()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.addDriver() as ViewResult;

            // Assert
            Assert.AreEqual("Driver Created", result.ViewBag.Message);
        }

        [TestMethod]
        public void addRoutes()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.addRoutes("Gwanda",325,6) as ViewResult;

            // Assert
            Assert.IsNotNull("Driver does not exist", result.ViewBag.Message);
        }
    }
}
