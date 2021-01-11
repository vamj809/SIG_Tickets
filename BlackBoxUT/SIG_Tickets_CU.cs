using NUnit.Framework;

namespace BlackBoxUT
{
    public class Tests : TestSession
    {
        [SetUp]
        public void ClassInitialize(TestContext context)
        {
            Setup(context);
            
            //radGridView = session.FindElementByAccessibilityId("radGridView1");
            //radDropDownButtonThemes = session.FindElementByAccessibilityId("radDropDownButton1");
        }

        [TearDown]
        public static void ClassCleanup()
        {
            TearDown();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

    }
}