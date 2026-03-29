public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T Item)
    {
        this.data = Item;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah : {data}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        DataGeneric<string> nim = new DataGeneric<string>("103082430003");
        nim.PrintData();
    }
}
