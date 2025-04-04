using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCAD17MenteeGroup
{
    public static class StackQueueLinkedLists
    {
        /*
            You are given an array of strings representing different fruits and an integer k. 
        Your task is to reverse the array starting from the k-th element using a stack.

            Write a function ReverseFromKUsingStack that takes an array of strings fruitArray and an integer k, 
            and returns the array reversed starting from the k-th element.

        Example: 
            Input: ["apple", "banana", "cherry", "date", "elderberry"], k = 2
           Output: ["apple", "banana", "elderberry", "date", "cherry"]

       

            Reversed Array starting from the 2-th element: ["apple", "banana", "elderberry", "date", "cherry"]

        Constraints
        The array fruitArray can contain up to 10^5 elements.
        Each element in fruitArray is a non-empty string.
        k is a non-negative integer and less than the length of fruitArray.
         */
        public static string[] ReverseFromKUsingStack(this string[] fruitArray, int k)
        {
            //LIFO Stack
            //take input determine utilizing for loop
            //while i != k 
            if (fruitArray.Length == 0 || k >= fruitArray.Length)
            {
                return fruitArray;
            }

            //LIFO
            Stack<string> stack = new Stack<string>();

            //Push elements from k-th to end to stack
            for (int i = k; i < fruitArray.Length; i++)
            {
                stack.Push(fruitArray[i]);
            }

            //Pop elements to reverse the array starting from k-th element
            for (int i = k; i < fruitArray.Length; i++)
            {
                fruitArray[i] = stack.Pop();
            }

            return fruitArray;
        }


        /*
         * You are given an array of strings representing different fruits. 
         * Your task is to remove the first n elements from the array using a queue and return the remaining array.

            Write a function RemoveUsingQueue that takes an array of strings fruitArray and an integer n, 
            and returns the remaining array after removing the first n elements.
        Example:
            Input: ["elderberry", "date", "cherry", "banana", "apple"], n = 2
            Output: ["cherry", "banana", "apple"]

            Remaining Array after removing first 2 elements: ["cherry", "banana", "apple"]
        
        Constraints:
            The array fruitArray can contain up to 10^5 elements.
            Each element in fruitArray is a non-empty string.
            n is a non-negative integer.
         */

        //public static string[] RemoveUsingQueue(this string[] fruitArray, int n)
        //{
        //    // Given the problem def, I would like to create a queue
        //    // With the queue in place I would like to access the array using a for loop
        //    // There is two options, I can put all elements in the queue, and then dequeue up until n
        //    // Or I can skip n and only enqueue the remainder. However this wants me to enqueu all elements
        //    // Am I understanding correctly??
        //    // MO: that is correct -- you can enqueue all elements and the dequeue n elements

        //    // Making the queue || I hate not having any intellisense to color the DS's - oh it's on VSCode but not on VS
        //    Queue<string> fruitQueue = new Queue<string>();
        //    int length = fruitArray.Length; // creating var n to have the length of the array

        //    // Using a for loop to enqueue the elements of the array
        //    for (int i = 0; i < length; i++) // n - 1 to stay in bounds of array
        //    {
        //        fruitQueue.Enqueue(fruitArray[i]);
        //    }
        //    // Now with the queue built with all of the elements from the array I will begin dequeuing elements -> nth element
        //    int toRemove = 0;
        //    while (toRemove <= n-1) // I believe should do n-1 because of proper indexing
        //    {
        //        fruitQueue.Dequeue();
        //        toRemove++;
        //    }

        //    //Remaining Array after removing first 2 elements: elderberry, date

        //     // refactoring for proper order
        //    return fruitQueue.ToArray(); // converting the queue back to an array
        //}

        public static string[] RemoveUsingQueue(this string[] fruitArray, int n)
        {
            // what if fruitArray is empty? what if n is 0? what if n is greater than the length of fruitArray?
            try
            {
                if (fruitArray == null || n == 0)
                {
                    return fruitArray;
                }
                if (n > fruitArray.Length)
                {
                    return Array.Empty<string>();
                }
                //FIFO
                Queue<string> queue = new Queue<string>();
                //Enqueue array
                foreach (string s in fruitArray)
                {
                    queue.Enqueue(s);
                }
                //Dequeue N elements
                for (int i = 0; i < n; i++)
                {
                    //queue.Count
                    queue.Dequeue();
                }

                return queue.ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return fruitArray;
            }
            //throw new NotImplementedException();
        }


        /*
         * You are given an array of strings representing different fruits. 
         * Your task is to store the elements in a linked list and return the k-th element from the linked list.

            Write a function GetKthElementUsingLinkedList that takes an array of strings fruitArray and an integer k, 
            and returns the k-th element from the linked list.
        Example:
            Input: ["elderberry", "date", "cherry", "banana", "apple"], k = 2
            Output: "date"

            Remaining Array stored in LinkedList: ["elderberry", "date", "cherry", "banana", "apple"]
            The 2-th element in the linked list is: "date"

        Constraints:
            The array fruitArray can contain up to 10^5 elements.
            Each element in fruitArray is a non-empty string.
            k is a non-negative integer.
         */

        public static string GetKthElementUsingLinkedList(this string[] fruitArray, int k)
        {
            throw new NotImplementedException();
        }

        /*
         * You are given an array of strings representing different fruits and an integer k. 
         * Your task is to rotate the array to the right by k steps. 
         * Convert the array to a linked list and then perform the rotation. 
         * Return the rotated array as a string array.

            Write a function RotateFruitArrayUsingLinkedList that takes an array of strings fruitArray and an integer k, 
            and returns the rotated array as a string array.
        Example:
            Input: ["apple", "banana", "cherry", "date", "elderberry"], k = 2
            Output: ["date", "elderberry", "apple", "banana", "cherry"]

            Rotated Array: ["date", "elderberry", "apple", "banana", "cherry"]

        Constraints:
            The array fruitArray can contain up to 10^5 elements.
            Each element in fruitArray is a non-empty string.
            k is a non-negative integer.
            
         * 
         */
        public static string[] RotateFruitArrayUsingLinkedList(this string[] fruitArray, int k)
        {
            throw new NotImplementedException();
        }
    }
}
