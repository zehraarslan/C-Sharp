namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler1 = new string[] { "Zehra", "Şeyma", "Merve", "Halime" };
            Console.WriteLine(isimler1[0]);
            Console.WriteLine(isimler1[1]);
            Console.WriteLine(isimler1[2]);
            Console.WriteLine(isimler1[3]);

            isimler1 = new string[5];
            isimler1[4] = "Hülya";
            Console.WriteLine(isimler1[0]);
            Console.WriteLine(isimler1[1]);
            Console.WriteLine(isimler1[2]);
            Console.WriteLine(isimler1[3]);
            Console.WriteLine(isimler1[4]);

            Console.WriteLine("-----------------------------------------------------------------");
            List<string> isimler2 = new List<string> {"Zehra", "Şeyma", "Merve", "Halime" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Hülya");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[4]);
        }

    }
}