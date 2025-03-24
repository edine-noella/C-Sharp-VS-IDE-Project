using System;

class Person
{
    private string name;  // Private field (hidden from outside)

    public string Name   // Public property (controls access)
    {
        get { return name; }
        set { if (!string.IsNullOrWhiteSpace(value)) name = value; }
    }
}