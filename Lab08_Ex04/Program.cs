using System;

var myObj = new MyClass();

System.Console.WriteLine($"Default integer      F1 = {myObj.F1}");  // Implicit fields initialization
System.Console.WriteLine($"Default string       F2 = {myObj.F2}");
System.Console.WriteLine($"Initialized integer  F3 = {myObj.F3}");  // Explicit field initialization
System.Console.WriteLine($"Initialized string   F4 = {myObj.F4}");

class MyClass
{
    public int F1;               // ไม่ได้กำหนดค่าเริ่มต้น (Implicit Initialization)
    public string F2;            // ไม่ได้กำหนดค่าเริ่มต้น (Implicit Initialization)
    public int F3 = 100;         // กำหนดค่าเริ่มต้นเป็น 100 (Explicit Initialization)
    public string F4 = "ASDF";   // กำหนดค่าเริ่มต้นเป็น "ASDF" (Explicit Initialization)
}

