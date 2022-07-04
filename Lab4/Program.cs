using System;
using System.Text;
using Lab4.Contracts;
using Lab4.Enums;

namespace Lab4
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int age;
            decimal height, weight;

            Console.WriteLine("Розрахунок щоденної норми споживання кілокалорій");
            Console.WriteLine("\nВведіть свої дані:");
            Console.WriteLine("\nВік:");
            age = Input.GetNumber(0, 100);

            Console.WriteLine("\nЗріст");
            height = Input.GetNumber(0m, 250m);

            Console.WriteLine("\nВага");
            weight = Input.GetNumber(0, 200);


            Console.WriteLine("\nСтать: 1 - Чоловіча, 2 - Жіноча");
            Sex sex = (Sex)Input.GetNumber(0, 3);

            Console.WriteLine("\nФізична активність: 1 - Низька, 2 - Середня, 3 - Висока");
            ActivityType activityType = (ActivityType)Input.GetNumber(0, 4);

            Console.WriteLine("\nТип статури: 1 - Ектоморф, 2 - Мезоморф, 3 - Ендоморф");
            BodyType bodyType = (BodyType)Input.GetNumber(0, 4);

            CaloriesCalculatorFacade calculator = new CaloriesCalculatorFacade(new AgeCalculator(age),
                new HeightCalculator(height), new BodyTypeCalculator(bodyType),
                new PhysicalActivityCalculator(activityType), new SexCalculator(sex), new WeightCalculator(weight));

            Console.WriteLine("\nВаша щоденна норма споживання калорій: {0}", calculator.Calculate());

            Console.WriteLine("\nНатисніть будь-яку клавішу, щоб вийти...");
            Console.ReadKey();
        }
    }
}
