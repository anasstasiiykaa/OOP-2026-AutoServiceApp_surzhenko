using AutoServiceApp.Models;

namespace AutoServiceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("BMW", "X5", 2020);
            var car2 = new Car("Audi", "A6", 2022);
            var customer1 = new Customer("Олександр Коваленко");
            var customer2 = new Customer("Марія Бойко");

            Console.WriteLine("Автомобілі:");
            Console.WriteLine($"{car1.Brand} {car1.Model}, {car1.Year} рік");
            Console.WriteLine($"{car2.Brand} {car2.Model}, {car2.Year} рік");

            Console.WriteLine("\nВласники:");
            Console.WriteLine($"Власник: {customer1.Name}");
            Console.WriteLine($"Власник: {customer2.Name}");

            Console.WriteLine("\nСтан ремонту:");
            car1.StartRepair();
            Console.WriteLine($"Чи в ремонті: {car1.IsUnderRepair}");
            car1.FinishRepair();
            Console.WriteLine($"Чи в ремонті після завершення: {car1.IsUnderRepair}");

            try
            {
                var invalidCar = new Car("Mercedes", "E-Class", 2100);
                Console.WriteLine($"Створено авто: {invalidCar.Brand} {invalidCar.Model}, {invalidCar.Year}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Помилка валідації: {ex.Message}");
            }
        }
    }
}
