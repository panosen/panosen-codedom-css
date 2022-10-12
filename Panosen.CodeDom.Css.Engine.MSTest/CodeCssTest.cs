using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace Panosen.CodeDom.Css.Engine.MSTest
{
    [TestClass]
    public class CodeCssTest
    {
        [TestMethod]
        public void TestMethod()
        {
            CodeCss codeCss = new CodeCss();

            codeCss.Name = ".basic";
            codeCss.Summary = "abc";
            codeCss.AddProperty("margin", "10px")
                .AddProperty("background-color", "#f00")
                .AddProperty("float", "right");

            var actual = codeCss.TransformText();

            var expected = PrepareExpected();

            Assert.AreEqual(expected, actual);
        }

        private string PrepareExpected()
        {
            return @"/* abc */
.basic {
    background-color: #f00;
    float: right;
    margin: 10px;
}
";
        }
    }
}
