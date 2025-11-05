using System;
using System.Collections.Generic;
using System.Linq;
using Moq;
using Data.Entities;
using TranslateNG.Controllers;

namespace TranslateNG.Tests.Controllers;

[TestClass]
public class HomeControllerTests
{
    [TestMethod]
    public void ReturnsTrue()
    {
        var myReturn = true;
        Assert.IsTrue(myReturn);
    }

    [TestMethod]
    public void ReturnsFalse()
    {
        var myReturn = false;
        Assert.IsFalse(myReturn);
    }

    [TestMethod]
    public void ReturnsLanguagesId()
    {
        var returnLanguage = new Languages
        {
            Id = new Guid(),
            Name = "testName"
        };

        Assert.AreEqual(returnLanguage.Name, "testName");
    }
}