public class HaloGeneric
{
    public void SapaUser<T>(T Item)
    {
        Console.WriteLine($"Halo User {Item}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        //SapaUser
        HaloGeneric hg = new HaloGeneric();
        string User = "Dhimaz Rafif Hanafi";
        hg.SapaUser(User);
    }
}