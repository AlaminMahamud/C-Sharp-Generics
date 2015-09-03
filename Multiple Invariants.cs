
// use Multiple where clauses

// Gen has two type args and both have a where clause 
class Gen<T,V> where T : class
			   where V : struct
			   
T ob1;
V ob2;

public Gen(T t, V v)
{
	ob1 = t;
	ob2 = v;
}

class MultipleConstrainDemo
{
	static void Main()
	{
		// The following snippet is allowable 
		// string is a class - ref type
		// int is a value type
		Gen<string, int> x = new Gen<string, int>("Hello", 11);


		// the following snippet is not available
		// bool is a value type - not compatible for ref type
		// int is also a value type
		Gen<bool, int> y = new Gen<bool, int>(true, 11);
	}
}