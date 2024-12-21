namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();
            Console.WriteLine(s1 == s2);
        }
    }
}
