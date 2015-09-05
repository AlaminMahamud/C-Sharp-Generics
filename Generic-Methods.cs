/// Creating a Generic Method

using System;

/// A Class of Array of Utilities
/// A Generic Class
class ArrayUtils
{
    // Copy an Array,
    // Inserting a new Element
    // this is a Generic Methods

    public static bool CopyInsert<T>(T e, uint idx, T[] src, T[] target)
    {
        // See if target array is big enough
        if (target.Length < src.Length + 1)
            return false;

        for (int i = 0, j = 0; i < src.Length; i++, j++)
        {
            if (i == idx)
                target[j++] = e;
            target[j] = src[i];
        }

        return true;
    }

}


class GenMethDemo
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3 };
        int[] nums2 = new int[4];

        // Display Contents of nums 
        foreach (int i in nums)
            Console.WriteLine(i);

        // Operate an int array
        ArrayUtils.CopyInsert(99, 2, nums, nums2);

        // Display Contents of nums2
        Console.WriteLine("Contents of nums2 : ");
        foreach (int i in nums2)
            Console.WriteLine(i);

        // Now use CopyInsert on an array of strings
        string[] s1 = { "Genrics", "are", "Powerful" };
        string[] s2 = new string[4];

        // Displaying the contents of s1
        foreach (string p in s1)
            Console.WriteLine(p);

        // Insert into a string array
        ArrayUtils.CopyInsert("In C#", 0, s1, s2);

        // Display Contents of String2
        foreach (string a in s2)
            Console.WriteLine(a);

        // This call is invalid because the first argument
        // is of type double and the third and fourth arguments
        // have element types of int 

        // ArrayUtils.CopyInsert(0.01, 1, nums, nums2);

    }
}
