using search.Declare;

namespace search.Models
{
    public class Vegetables
    {
         public  Vegetable[] VegetableItems { get; set; }

         public Vegetables(){
            VegetableItems =
            [
                new(){ Id = 1, Name = "Морковь", Cost = 400, ForWhat = WeightMeasures.kg},
                new(){ Id = 2, Name = "Ананас", Cost = 150, ForWhat = WeightMeasures.kg},
                new(){ Id = 3, Name = "Картошка", Cost = 200, ForWhat = WeightMeasures.kg},
                new(){ Id = 4, Name = "Томаты", Cost = 100, ForWhat = WeightMeasures.kg},
                new(){ Id = 5, Name = "Калина", Cost = 100, ForWhat = WeightMeasures.kg},
            ];
         }
    }

    public class Vegetable: IBase {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Cost { get; set; }
        public WeightMeasures ForWhat { get; set; }
    }
}