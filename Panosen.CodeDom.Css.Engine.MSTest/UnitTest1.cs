using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace Panosen.CodeDom.Css.Engine.MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CodeCss codeCss = new CodeCss();

            codeCss.Name = ".basic";
            codeCss.Margin = "10px";
            codeCss.BackgroundColor = "#f00";
            codeCss.Float = "right";

            var actual = codeCss.TransformText();

            var expected = PrepareExpected();

            Assert.AreEqual(expected, actual);
        }

        private string PrepareExpected()
        {
            return @".basic {
    background-color: #f00;
    float: right;
    margin: 10px;
}
";
        }
    }
}
