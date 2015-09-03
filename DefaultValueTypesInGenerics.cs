// default params

using System;

class MyClass{}

class Test<T>
{
	public T obj;
	public Test()
	{
		// The Following statement would work for reference Type only
		// obj = null; // can't use

		// The following statement would work for only value types
		// obj = 0; // can't use either

		// The Statement works for both reference and value types
		obj = default(T); // Works!

		/// ...
	}
}

class DefaultDemo
{
	static void Main()
	{
		// Construct Test using a reference Types
		Test<MyClass> t = new Test<MyClass>(new MyClass()
		);

		Console.WriteLine(t.obj == null);

		// Construct Test using a value Type
		Test<int> y = new Test<int>();

		Console.WriteLine(y.obj == 0);
	}
}