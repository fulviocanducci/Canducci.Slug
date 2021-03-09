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
  }
}
