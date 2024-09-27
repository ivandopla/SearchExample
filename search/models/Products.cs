namespace search.Models
{
    public class Products
    {
        public   Dictionary<Property, Car[]> Cars { get; set; } = [];
        public   Dictionary<Property, Vegetable[]> Vegetables { get; set; } =[];

        public Products(){
            Cars.Add(Property.Car, new Cars().CarItems);
            Vegetables.Add(Property.Vegetables, new Vegetables().VegetableItems);
        }
    }
}