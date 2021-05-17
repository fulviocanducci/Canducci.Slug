using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            string result = SlugExtensions.ToSlug("Friend Item 45 Friend");
            Assert.AreEqual(result, "friend-item-45-friend");
        }

        [TestMethod]
        public void TestSlugExtensionLenthChar()
        {
            string result = SlugExtensions.ToSlug("Friend Item 45 Friend", 10);
            Assert.AreEqual(result, "friend-ite");
        }

        [TestMethod]
        public void TestCountChar()
        {
            string result = "product source main".ToSlug(15);
            Assert.AreEqual(result, "product-source");
            Assert.AreEqual(14, result.Length);
        }
    }
}
