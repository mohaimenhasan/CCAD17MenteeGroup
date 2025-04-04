namespace CCAD17MenteeGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stack, Queue, and LinkedList implementation
            var fruitArray = new string[] { "apple", "banana", "cherry", "date", "elderberry" };
            int k = 2;

            foreach (var fruits in fruitArray)
            {
                Console.WriteLine(fruits);
            }

            //var reversedFruitStack = fruitArray.ReverseUsingStack(k);
            //Console.WriteLine("Reversed Array: " + string.Join(", ", reversedFruitStack));

            //var remainingFruits = fruitArray.RemoveUsingQueue(k);
            //Console.WriteLine("Remaining Array after removing first " + n + " elements: " + string.Join(", ", remainingFruits));

            //var kthElement = fruitArray.GetKthElementUsingLinkedList(k);
            //Console.WriteLine("The " + k + "-th element in the remaining array is: " + kthElement);

            //var rotatedArray = fruitArray.RotateFruitArrayUsingLinkedList(k);
            //Console.WriteLine($"Rotated Array: {string.Join(", ", rotatedArray)}");
        }
    }
}