using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer
            {
                Id = 1,
                DateOfBirty = new DateTime(1998),
                FirstName = "Zehra",
                LastName = "ARSLAN",
                NationalityId = "52656"
            });

            StarbucksCustomerManager customerManager2 = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager2.Save(new Customer
            {
                Id = 2,
                DateOfBirty = new DateTime(199),
                FirstName = "Zehra",
                LastName = "ARSLAN",
                NationalityId = "1662323"
            });

        }
    }
}