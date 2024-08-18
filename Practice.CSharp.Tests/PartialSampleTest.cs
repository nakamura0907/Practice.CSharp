using Practice.CSharp.Shared.Partial;

namespace Practice.CSharp.Tests
{
    [TestClass]
    public class PartialSampleTest
    {
        [TestMethod]
        public void TestSample()
        {
            var sample = new PartialSample();
            Assert.AreEqual("sample", sample.Sample());
        }
    }
}