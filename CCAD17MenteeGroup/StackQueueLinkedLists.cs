﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCAD17MenteeGroup
{
    public static class StackQueueLinkedLists
    {
        /*
         * You are given an array of strings representing different fruits. 
         * 
         * Your task is to reverse the array using a stack and then perform the following operations:
            Reverse the array using a stack.

            Write a function ReverseUsingStack that takes an array of strings fruitArray and returns the reversed array. 

        Example:
        Input: ["elderberry", "date", "cherry", "date", "elderberry"]
        Output: ["elderberry", "date", "cherry", "banana", "apple"]
        
        Reversed Array: ["elderberry", "date", "cherry", "date", "elderberry"]

        Constraints
        The array fruitArray can contain up to 10^5 elements.
        Each element in fruitArray is a non-empty string.
         */
        public static string[] ReverseUsingStack(this string[] fruitArray)
        {
            throw new NotImplementedException();
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

        public static string[] RemoveUsingQueue(this string[] fruitArray, int n)
        {
            throw new NotImplementedException();
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
