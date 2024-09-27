using System.Data;

namespace search.Models
{
    public class Propertys{
        public static string Messages { get; set; }  =
             $"Продукт какой категорий вы хотите найти? \n\t1: {Property.Vegetables}\n\t2: {Property.Car}\n";
        public static void GetMessages() => Console.WriteLine(Messages);
        public static string Question(){
            Console.WriteLine("Введите наименование: "); 
            return Console.ReadLine();
            }

        public static Property GetProperty() {
            try
            {
                int number = int.Parse(Console.ReadLine());
                var isProperty = Enum.IsDefined(typeof(Property), number);
                Console.WriteLine(
                    "Вы ввели: " +  number);

                if (!isProperty)
                    throw new Exception( $"Указано несуществующее значение: {number} ");
                
                return (Property)number;
            }
            catch (FormatException)
            {
                  throw new Exception("Неверный ввод. Пожалуйста, введите действительное целое число.");
            }
            catch (OverflowException)
            {
                 throw new Exception("Введенный вами номер слишком велик или слишком мал.");
            }
        }
    }

    public enum Property
    {
        Vegetables = 1,
        Car = 2
    }
}