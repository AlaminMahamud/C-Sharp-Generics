// some generic restrictions
//	>> Propertiess, operators, and indexers cannot be generic
//	   However, these items can be used in a generic class and can be use of the 
//	   Generic type parameters of the class
//	>> the extern modifier cannot be applier to a generic method
//     Pointer type cannot be used as type args in generics
//	>> if a generic class contains a static field, then each constructed type has iit  
//	   has its own copy of that field. this means that each instance of the same constructed
//	   type shares the same static field. 
//	   however, a different constructed type shares a different copy of that field.
// 	   thus, a static field is not shared by all constructed types

	