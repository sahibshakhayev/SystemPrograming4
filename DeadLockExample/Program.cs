Thread thread1 = new Thread(TeaLover);
Thread thread2 = new Thread(CookieLover);

thread1.Start();
thread2.Start();

Console.ReadLine();




static void TeaLover()
{
    lock ("Чайник")
    {
        Console.WriteLine("Поток 1 хочет чай");
        lock ("Тарелка с Печеньем")
        {
            Console.WriteLine("Поток 1 хочет печенье");
        }
    }
    Console.WriteLine("Поток 1 закончил чаепитие");

}

static void CookieLover()
{
    lock ("Тарелка с Печеньем")
    {
        Console.WriteLine("Поток 2 хочет печенье");
        lock ("Чайник")
        {
            Console.WriteLine("Поток 2 хочет чай");
        }
    }

    Console.WriteLine("Поток 2 закончил чаепитие");
}
