using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace Canducci.Slug.Test
{
    [TestClass]
    public class UnitTestSlug
    {
        [TestMethod]
        public void TestSlugTextValue()
        {
            string text = "Friend Sôuza";
            string slug = text.ToSlug();
            Assert.AreEqual("friend-souza", slug);
        }

        [TestMethod]
        public void TestSlugExtension()
        {
            string item = (string)typeof(SlugExtensions).GetMethod("GenerateSlug",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Static |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.Public
            ).Invoke(typeof(SlugExtensions), new object[]{ "Friend Peter Pan", 0 });
            
            string result = SlugExtensions.ToSlug("Friend Item 45 Friend");

            Assert.AreEqual(item, "friend-peter-pan");
            Assert.AreEqual(result, "friend-item-45-friend");
        }

        [TestMethod]
        public void TestSlugExtensionLength()
        {
            string result = SlugExtensions.ToSlug("Friend Item 45 Friend", 11);
            Assert.AreEqual(result, "friend-item");
        }

        [TestMethod]
        public void TestSlugExtensionLenthChar()
        {
            string result = SlugExtensions.ToSlug("Friend Item 45 Friend", 11);
            Assert.AreEqual(result, "friend-item");
        }

        [TestMethod]
        public void TestCountChar()
        {
            string result = "product source main".ToSlug(15);
            Assert.AreEqual(result, "product-source");
            Assert.AreEqual(14, result.Length);
        }

        [TestMethod]
        public void TestSlugTextValueNoLength()
        {
            string text = "Friend Sôuza Friend Peter ...";
            string slug = text.ToSlug();
            Assert.AreEqual("friend-souza-friend-peter", slug);
        }
    }
}
