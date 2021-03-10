using Intuition.Data.Repository;
using Intuition.Domain.Commands;
using Intuition.Domain.Interfaces;
using Intuition.Domain.Models;
using Intuition.Domain.Queries;
using Intuition.Domain.TaxCalculation;
using System;

namespace Intuition
{
    class Program
    {

        static void Main()
        {
            Question1();


            Question2();


            Question3();

            Console.ReadKey();

        }

        public static void Question1()
        {


            IEmployeeCommands employeeCommand = new EmployeeCommands(new EmployeeCommandsRepository());
            var firstEmployee = new Employee(1, "test", "test");
            employeeCommand.AddEmployee(firstEmployee);
            Console.WriteLine(
                $"Adding first employee :{firstEmployee.EmployeeId}, Name:{firstEmployee.FirstName}, Address:{firstEmployee.LastName}");
            var secondEmployee = new Employee(2, "test1", "test1");
            employeeCommand.AddEmployee(secondEmployee);

            Console.WriteLine(
                $"Adding second employee :{secondEmployee.EmployeeId}, Name:{secondEmployee.FirstName}, Address:{secondEmployee.LastName}");
            var thirdEmployee = new Employee(3, "test2", "test2");
            employeeCommand.AddEmployee(thirdEmployee);

            Console.WriteLine(
                $"Adding third employee :{thirdEmployee.EmployeeId}, Name:{thirdEmployee.FirstName}, Address:{thirdEmployee.LastName}");


            IEmployeeQueries employeeQuery = new EmployeeQueries(new EmployeeQueryRepository());
            var result = employeeQuery.GetEmployee(1);


            Console.WriteLine($"Get Employee ID =1 :{result.EmployeeId}, Name:{result.FirstName}, Address:{result.LastName}");


            var orderList = employeeQuery.GetOrderedEmployeeArray();

            for (int employeeCount = 1; employeeCount >= orderList.Count; employeeCount++)
            {
                Console.WriteLine(
                    $" Employee Ordered Array  :{orderList[employeeCount].EmployeeId}, Name:{orderList[employeeCount].FirstName}, Address:{orderList[employeeCount].LastName}");
            }
        }


        private static void Question3()
        {
            var product = new Product() { Id = Guid.NewGuid(), Price = 12.00M };
            Cart cart = new Cart();
            cart.AddItemToCart(product);
            var payment = new Payment("us");
            payment.Calculate(cart);
            CartTotal cartTotal = payment.GetReceipt();
            payment.PrintReceipt(cartTotal);


            var product1 = new Product() { Id = Guid.NewGuid(), Price = 12.00M };
            var cart1 = new Cart();
            cart1.AddItemToCart(product1);
            var payment1 = new Payment("ca");
            payment1.Calculate(cart);
            CartTotal receipt1 = payment1.GetReceipt();
            payment1.PrintReceipt(receipt1);
        }

        private static void Question2()
        {
            Vehicle car = new Car();
            Vehicle truck = new Truck();
            Vehicle train = new Train();


            car.SetSuccessor(truck);
            truck.SetSuccessor(train);


            var carTimeTaken = car.Execute(388);


            Console.WriteLine($" The vehicle from the time taken is :  :{carTimeTaken}");
        }
    }



}
