class Program{
    static void Main(){
        string[] names = {"Daigo","Hikaru","Hayata"};

        if (string.Equals(names[0], "daiGo", StringComparison.OrdinalIgnoreCase)){
            Console.WriteLine("Igual");
        }
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

    }
}