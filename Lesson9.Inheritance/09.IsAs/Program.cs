ClassB b = new ClassB();
ClassA a = null;

// Əgər qeyd edilən dəyişən hər-hansı klasdan törəyibsə true, əks halda false qaytaracaqdır:

if (b is ClassA)
{
    a = (ClassA)b;
}
else
{
    a = null;
}

// Əgər qeyd edilən dəyişən hər-hansı klasdan törəyibsə, onda onu tipə çeviriirik, əks halda null qaytaracaqdır:

a = b as ClassA;

class ClassA { /* ... */ }

class ClassB : ClassA { /* ... */ }