var myObj = new MyClass();
myObj.Info();

class MyClass
{
    int F1;               // Implicit Field Initialization (ค่าเริ่มต้น = 0)
    string F2;            // Implicit Field Initialization (ค่าเริ่มต้น = null)
    int F3 = 100;         // Explicit Field Initialization (กำหนดค่าเป็น 100)
    string F4 = "ASDF";   // Explicit Field Initialization (กำหนดค่าเป็น "ASDF")

    public void Info()
    {
        System.Console.WriteLine($"Default integer      F1 = {F1}");  //Implicit fields initialization
        System.Console.WriteLine($"Default string       F2 = {F2}");

        System.Console.WriteLine($"Initialized integer  F3 = {F3}");  //Explicit field initialization
        System.Console.WriteLine($"Initialized string   F4 = {F4}");
    } 
}

