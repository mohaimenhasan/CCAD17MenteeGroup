using CCAD17MenteeGroup;

namespace TestProjectCCAD17
{
    [TestClass]
    public class DetectCycleTests
    {
        [TestMethod]
        public void TestEmptyList()
        {
            var detectCycle = new DetectCycle();
            ListNode head = null;
            Assert.IsFalse(detectCycle.HasCycle(head));
        }

        [TestMethod]
        public void TestSingleNodeNoCycle()
        {
            var detectCycle = new DetectCycle();
            var head = new ListNode(1);
            Assert.IsFalse(detectCycle.HasCycle(head));
        }

        [TestMethod]
        public void TestSingleNodeWithCycle()
        {
            var detectCycle = new DetectCycle();
            var head = new ListNode(1);
            head.Next = head;
            Assert.IsTrue(detectCycle.HasCycle(head));
        }

        [TestMethod]
        public void TestMultipleNodesNoCycle()
        {
            var detectCycle = new DetectCycle();
            var head = new ListNode(1);
            head.Next = new ListNode(2);
            head.Next.Next = new ListNode(3);
            Assert.IsFalse(detectCycle.HasCycle(head));
        }

        [TestMethod]
        public void TestMultipleNodesWithCycle()
        {
            var detectCycle = new DetectCycle();
            var head = new ListNode(1);
            var second = new ListNode(2);
            var third = new ListNode(3);
            head.Next = second;
            second.Next = third;
            third.Next = second; // Cycle here
            Assert.IsTrue(detectCycle.HasCycle(head));
        }

        [TestMethod]
        public void TestMultipleNodesCycleAtHead()
        {
            var detectCycle = new DetectCycle();
            var head = new ListNode(1);
            var second = new ListNode(2);
            var third = new ListNode(3);
            head.Next = second;
            second.Next = third;
            third.Next = head; // Cycle here
            Assert.IsTrue(detectCycle.HasCycle(head));
        }
    }
}
