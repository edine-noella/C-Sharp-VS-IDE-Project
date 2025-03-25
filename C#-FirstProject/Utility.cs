namespace C__FirstProject;

public static class Utility
{

    //a static class can not have a non static method, constructor or property/field inside

    private static string name;
    private static int age;
    public static void greet(string name)
    {
        Console.WriteLine($"Hello, {name}");
    }

    static Utility()
    {
        name = "Edine Noella";
        age = 0;
    }
    
    
    
}