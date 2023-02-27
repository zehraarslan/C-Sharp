namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "143";
            customer1.TcNo = "1216545";
            customer1.FirstName = "Zehra";
            customer1.FirstName = "ARSLAN";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "13265";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "216589896";
        }
    }
}