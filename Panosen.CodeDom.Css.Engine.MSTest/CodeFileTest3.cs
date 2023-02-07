using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace Panosen.CodeDom.Css.Engine.MSTest
{
    [TestClass]
    public class CodeFileTest3
    {
        [TestMethod]
        public void TestMethod()
        {
            var codeCssFile = new CodeCssFile();

            codeCssFile.AddCss(".basic", "Test")
                .SetMargin("10px")
                .SetBackgroundColor("#f00")
                .SetFloat("right");

            codeCssFile.AddCss(".basic", "Test")
                .SetMargin("10px")
                .SetBackgroundColor("#f00")
                .SetFloat("right");

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
