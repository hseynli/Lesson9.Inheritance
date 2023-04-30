DerivedClass instance = new DerivedClass();
instance.Method();

// UpCast
BaseClass instanceUp = (BaseClass)instance;
instanceUp.Method();

// DownCast
DerivedClass instanceDown = (DerivedClass)instanceUp;
instanceDown.Method();