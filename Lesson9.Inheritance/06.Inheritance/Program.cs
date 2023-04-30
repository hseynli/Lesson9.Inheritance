DerivedClass instance = new DerivedClass();
instance.Method();

// UpCast
BaseClass instanceUp = instance;
instanceUp.Method();

// DownCast
DerivedClass instanceDown = (DerivedClass)instanceUp;
instanceDown.Method();