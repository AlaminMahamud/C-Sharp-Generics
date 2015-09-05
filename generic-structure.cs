// Demonstrate a Generic Struct
using System;

// This Structure is Generic

struct XY<T>
{
	T x;
	T y;

	public XY(T a, T b)
	{
		x = a;
		y = b;
	}

	public T X
	{
		get{return x;}
		set{x = value;}
	}

	public T Y
	{
		get{return y;}
		set{y = value;}
	}
}


class StructTest
{
	static void Main()
	{
		XY<int> a = new XY<int>(10,20);
		XY<string> b = new XY<string>("Hello", "World!");

		Console.WriteLine(a.x + " " + a.y);
		Console.WriteLine(b.x + " " + b.y);
	}
}