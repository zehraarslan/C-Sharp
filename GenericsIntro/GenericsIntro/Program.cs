namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> name = new MyList<string>();
            name.Add("Zehra");
            foreach (string item in name.Items)
            {
                Console.WriteLine(item);
            }
            name.Add("Şeyma");
            name.Add("Merve");
            foreach(string item in name.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}