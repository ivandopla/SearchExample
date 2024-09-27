using ConsoleTables;
using search.Declare;
using search.Models;

namespace search.Service
{
    public class Search
    {
        public static IBase[] SearchItems(Property property, string search)
        {
            var result = new Dictionary<Property, IBase[]> {
                {Property.Car , new Products().Cars[Property.Car].Where(w => w.Name.ToLower().Contains(search.ToLower())).ToArray()},
                {Property.Vegetables , new Products().Vegetables[Property.Vegetables].Where(w => w.Name.ToLower().Contains(search.ToLower())).ToArray()}
            };

            Console.WriteLine($"Поиск по таблице: {property}");
            ConsoleTable.From(result[property]).Write();

            return result[property];
        }  
    }
}