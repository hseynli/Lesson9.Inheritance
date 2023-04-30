DerivedClass instance = new DerivedClass();
instance.Method();

// UpCast
BaseClass instanceUp = instance as BaseClass;
instanceUp.Method();

// DownCast
DerivedClass instanceDown = instanceUp as DerivedClass;
instanceDown.Method();