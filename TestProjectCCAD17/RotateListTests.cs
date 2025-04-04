using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCAD17MenteeGroup;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectCCAD17
{
    [TestClass]
    public class RotateListTests
    {
        private ListNode CreateLinkedList(int[] values)
        {
            if (values.Length == 0) return null;
            ListNode head = new ListNode(values[0]);
            ListNode current = head;
            for (int i = 1; i < values.Length; i++)
            {
                current.Next = new ListNode(values[i]);
                current = current.Next;
            }
            return head;
        }

        private List<int> ConvertToList(ListNode head)
        {
            List<int> result = new List<int>();
            while (head != null)
            {
                result.Add(head.Value);
                head = head.Next;
            }
            return result;
        }

        [TestMethod]
        public void RotateRight_ByZeroPlaces_ReturnsSameList()
        {
            // Arrange
            var rotateList = new RotateList();
            var head = CreateLinkedList(new int[] { 1, 2, 3, 4, 5 });

            // Act
            var result = rotateList.RotateRight(head, 0);

            // Assert
            CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 4, 5 }, ConvertToList(result));
        }

        [TestMethod]
        public void RotateRight_ByLengthOfList_ReturnsSameList()
        {
            // Arrange
            var rotateList = new RotateList();
            var head = CreateLinkedList(new int[] { 1, 2, 3, 4, 5 });

            // Act
            var result = rotateList.RotateRight(head, 5);

            // Assert
            CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 4, 5 }, ConvertToList(result));
        }

        [TestMethod]
        public void RotateRight_ByMoreThanLengthOfList_ReturnsRotatedList()
        {
            // Arrange
            var rotateList = new RotateList();
            var head = CreateLinkedList(new int[] { 1, 2, 3, 4, 5 });

            // Act
            var result = rotateList.RotateRight(head, 7);

            // Assert
            CollectionAssert.AreEqual(new List<int> { 4, 5, 1, 2, 3 }, ConvertToList(result));
        }

        [TestMethod]
        public void RotateRight_EmptyList_ReturnsEmptyList()
        {
            // Arrange
            var rotateList = new RotateList();
            ListNode head = null;

            // Act
            var result = rotateList.RotateRight(head, 3);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void RotateRight_SingleNodeList_ReturnsSameList()
        {
            // Arrange
            var rotateList = new RotateList();
            var head = CreateLinkedList(new int[] { 1 });

            // Act
            var result = rotateList.RotateRight(head, 3);

            // Assert
            CollectionAssert.AreEqual(new List<int> { 1 }, ConvertToList(result));
        }
    }
}
