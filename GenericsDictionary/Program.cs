namespace GenericsDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Zehra");
            myDictionary.Add(2, "Şeyma");
            myDictionary.ToString();
            myDictionary.Add(2, "Seren");

            myDictionary.ToString();
        }
    }
}