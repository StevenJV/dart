using System;
using NUnit.Framework;
using OpenQA.Selenium;
using Navex.QA.Nova;
using Navex.QA.Nova.TestClassBases;

namespace dart;

class Program
{
    [TestFixture]
    public class TestClass1 : SeleniumBrowserTestBase
    {
        private String _url = null!;

        [SetUp]
        public void SetupTest()
        {
        }
        [TearDown]
        public void TeardownTest()
        {
        }

        [Test]
        public void testInsightsWobbly()
        {
            _url = "https://dm1.in.navex-pe.com/";
            Browser.Driver.Visit(this._url);
            insightsHomePage insightsHome = new insightsHomePage(Browser);
            Assert.AreEqual(insightsHome._forgotPasswordExpected, insightsHome._forgotPassword.Text);

        }
        [Test]
        public void testInsightsBlog()
        {
            _url = "https://steven.vorefamily.net/";
            Browser.Driver.Visit(this._url);
            blogPage blog = new blogPage(Browser);
            Assert.AreEqual(blog._titleExpected, blog.siteTitle.Text);

        }

    }
}