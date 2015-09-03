// Create Relationhip between two Type Params


// Create Relationship Between Two type params
class A{}
class B : A{}

// Here V Must be inherit From T
class Gen<T,V> where V : T{}

class NakedConstraintDemo
{
	static void Main()
	{
		// This declaration is OK because B inherits A
		Gen<A,B> x = new Gen<A,B>();

		// This declaration is in error because
		// A does not inherit B
		// Gen<B,A> y = new Gen<B,A>();
	}

}

