namespace CCAD17MenteeGroup
{
    /// <summary>
    /// This class provides a method to detect if a linked list has a cycle.
    /// </summary>
    public class DetectCycle
    {
        /// <summary>
        /// Determines if the linked list has a cycle.
        /// </summary>
        /// <param name="head">The head of the linked list.</param>
        /// <returns>True if there is a cycle in the linked list, otherwise false.</returns>
        /// <example>
        /// Example 1:
        /// Input: head = [3,2,0,-4], pos = 1
        /// Output: true
        /// Explanation: There is a cycle in the linked list, where the tail connects to the 1st node (0-indexed).
        /// 
        /// Example 2:
        /// Input: head = [1,2], pos = 0
        /// Output: true
        /// Explanation: There is a cycle in the linked list, where the tail connects to the 0th node.
        /// 
        /// Example 3:
        /// Input: head = [1], pos = -1
        /// Output: false
        /// Explanation: There is no cycle in the linked list.
        /// </example>
        /// <remarks>
        /// Constraints:
        /// - The number of the nodes in the list is in the range [0, 10^4].
        /// - -10^5 <= Node.val <= 10^5
        /// - pos is -1 or a valid index in the linked-list.
        /// 
        /// Follow up: Can you solve it using O(1) (i.e. constant) memory?
        /// </remarks>
        public bool HasCycle(ListNode head)
        {
            // Implementation goes here
            throw new NotImplementedException();
        }
    }
}