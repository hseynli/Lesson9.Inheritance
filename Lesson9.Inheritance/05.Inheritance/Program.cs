﻿DerivedClass instance = new DerivedClass();

instance.field1 = 1;
instance.field2 = 2;
instance.field3 = 3;

instance.field4 = 4;
instance.field5 = 5;

BaseClass newInstance = instance; // Upcast

Console.WriteLine(newInstance.field1);
Console.WriteLine(newInstance.field2);
Console.WriteLine(newInstance.field3);

//Console.WriteLine(newInstance.field4);
//Console.WriteLine(newInstance.field5);


// Yoxlanış.
Console.WriteLine("instance Id     {0}", instance.GetHashCode());
Console.WriteLine("newInstance Id  {0}", newInstance.GetHashCode());