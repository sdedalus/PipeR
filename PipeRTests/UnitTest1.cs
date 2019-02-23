using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace PipeRTests
{
    [TestClass]
    public partial class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var tmp = new PipeR.PipeSystem<TestValue>();
            tmp.Use(async (v, n) =>
                {
                    v.v = v.v + 1;
                    await n();
                });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            var x = tmp.Build();
            var y = new TestValue() { v = 1 };
            x(y);
            Assert.AreEqual(3, y.v);
        }


        [TestMethod]
        public void TestMethod2()
        {
            var tmp = new PipeR.PipeSystem<TestValue>();
            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            tmp.Use(async (v, n) =>
            {
                v.v = v.v + 1;
                await n();
            });

            var x = tmp.Build();
            var y = new TestValue() { v = 1 };
            x(y);
            Assert.AreEqual(30, y.v);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var tmp = new PipeR.PipeSystem<TestValue>();
            tmp.Use(new SkipTestFilter());
            tmp.Use(new IncrementTestFilter());


            var x = tmp.Build();
            var y = new TestValue() { v = 1 };
            x(y);
            Assert.AreEqual(2, y.v);
        }

    }
}
