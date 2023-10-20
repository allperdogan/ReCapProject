using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User() {FirstName="Alper", LastName="Dogan", Email="abc@gmail.com", Password="123"};

            UserManager userManager = new UserManager(new EfUserDal());
            userManager.AddUser(user1);

            Rental rental1 = new Rental() {CustomerId=1, CarId=1, RentDate = new DateTime(2023,1,1) , ReturnDate = new DateTime(2023, 1, 2) };

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.AddRental(rental1);

            foreach(var rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine(rental.Id + " " + rental.CustomerId);
            }
            
        }
    }
}