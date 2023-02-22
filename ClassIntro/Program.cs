namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "C#";
            kurs1.EgitmenAdı = "Engin Demiroğ";
            kurs1.IzlenmeOranı = 78;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "Java";
            kurs2.EgitmenAdı = "Cem Demir";
            kurs2.IzlenmeOranı = 75;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "C++";
            kurs3.EgitmenAdı = "Engin Demiroğ";
            kurs3.IzlenmeOranı = 88;

            Console.WriteLine(kurs1.KursAdı + " : " + kurs1.EgitmenAdı);


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı + " : " + kurs.EgitmenAdı);
            }
        }
    }

    class Kurs
    {
        public string KursAdı { get; set; }
        public string EgitmenAdı { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}