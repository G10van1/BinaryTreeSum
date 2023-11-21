using BinaryTreeSum;

namespace BinaryTreeSumTest
{
    public class Tests
    {
        private BinaryTree bTree; 

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            bTree = new BinaryTree(new int[] { 1, 10, 5, 1, 0, 6, 0 });
            Assert.That(bTree.MajorSum(), Is.EqualTo("Equal"));
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            bTree = new BinaryTree(new int[] {});
            Assert.That(bTree.MajorSum(), Is.EqualTo("Equal"));
            Assert.Pass();
        }

        [Test]
        public void Test3()
        {
            bTree = new BinaryTree(new int[] { 1, 10, 5, 3, 0, 6, 0 });
            Assert.That(bTree.MajorSum(), Is.EqualTo("Left"));
            Assert.Pass();
        }

        [Test]
        public void Test4()
        {
            bTree = new BinaryTree(new int[] { 1, 10, 5, -1, 0, 6, 0 });
            Assert.That(bTree.MajorSum(), Is.EqualTo("Right"));
            Assert.Pass();
        }

        [Test]
        public void Test5()
        {
            bTree = new BinaryTree(new int[] { 1, 10, 5, 1, 0, -1, 4 });
            Assert.That(bTree.MajorSum(), Is.EqualTo("Left"));
            Assert.Pass();
        }

        [Test]
        public void Test6()
        {
            bTree = new BinaryTree(new int[] { 1, 9, 7, 2, 0, 6, 0 });
            Assert.That(bTree.MajorSum(), Is.EqualTo("Right"));
            Assert.Pass();
        }


        [Test]
        public void Test7()
        {
            bTree = new BinaryTree(new int[] { 1, 1, 1, 1, 1, 1, 1 });
            Assert.That(bTree.MajorSum(), Is.EqualTo("Equal"));
            Assert.Pass();
        }

        [Test]
        public void Test8()
        {
            bTree = new BinaryTree(new int[] { 1, -1, 0, 5, 7, 0, 0 });
            Assert.That(bTree.MajorSum(), Is.EqualTo("Equal"));
            Assert.Pass();
        }
    }
}