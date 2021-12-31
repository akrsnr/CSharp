// learn abisi burdan --> https://web.archive.org/web/20211231181051/https://dingyuliang.me/c-async-await-work/

class x
{
    static async Task Main(string[] args)
    {
        var q = Method1();
        var y = Method2();
        await Task.Delay(5000);
        Console.WriteLine("soner");
        await q;
        await y;
    }
    public static async Task Method1()
    {
        Console.WriteLine("Method1 before");

        await Task.Run(() =>
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Method 1 : " + i);
            }
        });
        
        Console.WriteLine("Method1 after");

    }
    public static async Task Method2()
    {
        Console.WriteLine("Method2 before");

        await Task.Run(() =>
        {
            for (int i = 101; i < 1110; i++)
            {
                Console.WriteLine("Method 2 : " + i);
            }
        });
        
        Console.WriteLine("Method2 after");

    }
}
