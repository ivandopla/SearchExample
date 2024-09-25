using System;
using System.Linq;

Console.WriteLine($"Продукт какой категорий вы хотите найти? \n\t1: {Property.Vegetables}\n\t2: {Property.Car}\n\t3. Juice\nКатегория: ");
var CategoryAnswer = int.Parse(Console.ReadLine());

Dictionary<Property, Car[]> searchcar = ListOfProducts.GetCarDictionary();
Dictionary<Property, Vegetables[]> searchvegetables = ListOfProducts.GetVegetablesDictionary();

switch (CategoryAnswer)
{
    case 1:
        Console.WriteLine("Какой овощ вы ищите?\n: ");
        string VegetableAnswer = Console.ReadLine();
        string VegetableAnswerToLower = VegetableAnswer.ToLower();
        if (VegetableAnswer != null)
        {
            Vegetables? VegetablesFinder = searchvegetables.ContainsKey(Property.Vegetables)
                ? searchvegetables[Property.Vegetables].FirstOrDefault(Vegetables => Vegetables.Name == VegetableAnswerToLower) :
                null;
            
            if (VegetablesFinder != null)
            {
                Console.WriteLine($"Найден овощ: Id = {VegetablesFinder.Id}\nОвощ = {VegetablesFinder.Name}\nСтоймость {VegetablesFinder.Cost}\nЦена за {VegetablesFinder.ForWhat}");
            }
            else
            {
                Console.WriteLine($"Овощ {VegetableAnswer} не найден");
            }
        }
        break;
    case 2:
        Console.WriteLine("Какую машину вы хотите найти?\n: ");
        string CarAnswer = Console.ReadLine();
        string CarAnswerToLower = CarAnswer.ToLower();
        if (CarAnswer != null)
        {
            foreach (var list in searchcar)
            {
                foreach (var car in list.Value)
                {
                    if (car.Name.IndexOf(CarAnswerToLower) >= 0)
                    {
                        Console.WriteLine($"Найдена машина: {car.Name}\nномер: {car.CarNumber}\nцвет: {car.Color}");
                    }
                }
            }
        }
        break;
    default:
        Console.WriteLine("Error");
        break;
}
