using Microsoft.Extensions.DependencyInjection;
using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main()
        {
            //Setup DI
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IEmployee, EmployeeAdapter>()
                .BuildServiceProvider();

            var emp = serviceProvider.GetService<IEmployee>();
            string value = emp.GetAllEmployees();
            Console.WriteLine("------------------:: After ::------------\n" + value);
            Console.ReadLine();

        }
    }




}