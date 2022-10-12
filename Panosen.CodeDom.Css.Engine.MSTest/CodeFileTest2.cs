using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace Panosen.CodeDom.Css.Engine.MSTest
{
    [TestClass]
    public class CodeFileTest2
    {
        [TestMethod]
        public void TestMethod()
        {
            var codeCssFile = new CodeCssFile();

            codeCssFile.AddCss(".basic", "Test")
                .AddProperty("margin", "10px")
                .AddProperty("background-color", "#f00")
                .AddProperty("float", "right");

            codeCssFile.AddCss(".basic", "Test")
                .AddProperty("margin", "10px")
                .AddProperty("background-color", "#f00")
                .AddProperty("float", "right");

            var actual = codeCssFile.TransformText(new GenerationOptions
            {
                TabString = "  "
            });

            var expected = PrepareExpected();

            Assert.AreEqual(expected, actual);
        }

        private string PrepareExpected()
        {
            return @"/* Test */
.basic {
  background-color: #f00;
  float: right;
  margin: 10px;
}

/* Test */
.basic {
  background-color: #f00;
  float: right;
  margin: 10px;
}
";
        }
    }
}
