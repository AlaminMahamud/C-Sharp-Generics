// Demonstrate a Generic Interface

using System;

public interface ISeries<T>
{
	T GetNext(); // Return next element
	void Reset(); // restrat the series
	void SetStart(); // Set the starting element
}

// implement ISeries
class ByTwos<T> : ISeries<T>
{
	T start;
	T val;

	// this delegate defines the form of a method
	// that will be called when the next element in the series is needed
	public delegate T IncByTwo(T v);

	// This delegate reference will assigned the 
	// method passed to the ByTwos Constructor

	// This delegate reference will be assigned the 
	// method passed to the ByTwos Constructor
	IncByTwo incr;

	public ByTwos(IncByTwo incrMeth)
	{
		start = default(T);
		val   = default(T);
		incr  = incrMeth;
	}	

	public T GetNext()
	{
		val = incr(val);
		return val;
	}

	public void Reset()
	{
		val = start;
	}

	public void SetStart(T v)
	{
		start = v;
		val = start;
	}
}

class ThreeD
{
	public int x, y, z;
	public ThreeD(int a, int b, int c)
	{
		x = a;
		y = b;
		z = c;
	}
}


class GenIntfDemo
{
	// Define Plus two for int
	static int IntPlusTwo(int v)
	{
		return v+2;
	}

	// Define Plus two for Double
	static double DoublePlusTwo(Double v)
	{
		return v+2.0;
	}

	// Define PlusTwo for ThreeD
	static ThreeD ThreeDPlusTwo(ThreeD v)
	{
		if(v == null) return new ThreeD(0,0,0);
		else return new ThreeD(v.x+2, v.y+2, v.z+2);
	}

	static void Main(string[] args)
	{
		// Demonstrate int series
		ByTwos<int> intBT = new ByTwos<int>(IntPlusTwo);
		for(int i=0; i<5; i++)
			Console.Write(intBt.GetNext() + " ");
		Console.WriteLine();


		// Demonstrate Double Series
		ByTwos<double> dblBT = new ByTwos<double>(DoublePlusTwo);

		// Doubleseries SetStart()
		for(int i=0; i<5; i++)
			Console.Write(dblBT.GetNext() + " ");

		// Demonstrate ThreeD Series
		ByTwos<ThreeD> ThrDBT = new ByTwos<ThreeD>(ThreeDPlusTwo);	
		ThreeD coord;
		for(int i=0; i <5; i++)
		{
			coord = ThrDBT.GetNext();
			Console.Write(coord.x + "," + 
						  coord.y + "," +
						  coord.z + " ");
		}	
			Console.WriteLine();

	}
}