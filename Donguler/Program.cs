namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlmaya Başlangıç İçin Temel Kurs", "Java", "Python" };


            // foreach - dizi temlleri yapıları tek tek dönmeye yarıyor.
            foreach (string s in kurslar) 
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}