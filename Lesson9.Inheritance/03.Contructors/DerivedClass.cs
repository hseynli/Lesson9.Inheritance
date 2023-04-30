class DerivedClass : BaseClass
{
    public int derivedField;

    // Default konstruktor.
    //public DerivedClass() 
    //{
    //}

    // İstifaçəki konstruktoru.
    // Varis olunmuş klasın instance-ı yaradılarsa, onda valideyn klasının konstrukrou avtomatik olaraq çağrılacaq.
    // Valideyn klasının konstrukrou bütün dəyişənlərə hansısa təhlükəsiz dəyərlər mənimsədəcəkdir.
    // Bundan sonra varis olunmuş klasın konstruktoru işə düşəcək və yenidən dəyişənlərə təhlükəsiz dəyərlər mənimsədəcəkdir
    public DerivedClass(int number1, int number2)
    {
        // Base klasın field-nin dəyərə mənimsədilməsi.
        baseNumber = number1;

        // Cari klasın field-nin dəyərə mənimsədilməsi.
        derivedField = number2;
    }
}