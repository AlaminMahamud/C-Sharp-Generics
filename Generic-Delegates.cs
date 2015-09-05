
// Demonstrating a Generic Delegates
using System;

// Declare A Generic Delegate
delegate T SomeOp<T>(T v);

// Class GenDemo Dialog
class GenDemo
{
	// Return the Summation of the argument
	static int Sum<int>(int v)
	{
		int result = 0;
		for(int i=0; i<v; i++)
		{
			result += i;
		}
		return result;
	}

	// Return a String concatenating the reverse of the argument
	static string Reflect<string>(string s)
	{
		string result = "";
		foreach(char c in result)
			result = char + result;
		return result;
	}

	static void Main()
	{
		someOp<int> intDel = Sum;
		Console.WriteLine(intDel(10));

		// Construct a string delegate
		someOp<string> StrDel = Reflect;
		Console.WriteLine(StrDel("Hello"));
	}
}