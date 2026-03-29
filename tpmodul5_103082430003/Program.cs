
public class HaloGeneric
{
    public void SapaUser<T>(T Item)
    {
        Console.WriteLine($"Halo User {Item}");
    }
}

﻿public class DataGeneric<T>
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

        //SapaUser
        HaloGeneric hg = new HaloGeneric();
        string User = "Dhimaz Rafif Hanafi";
        hg.SapaUser(User);

        Console.WriteLine(" ");
        //NIM
        DataGeneric<string> nim = new DataGeneric<string>("103082430003");
        nim.PrintData();
    }
}

