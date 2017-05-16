using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterfaceSegregation.Configuration1
{
    [TestClass]
    public class AboutPageShould
    {
        [TestMethod]
        public void DisplayApplicationName()
        {
            var aboutPage = new AboutPage();
            var textWriter = new StringWriter();
            aboutPage.Render(textWriter);

            var output = textWriter.ToString();

            Assert.AreEqual("Interface Segregation By Dev Next", output);
        }
    }
}
