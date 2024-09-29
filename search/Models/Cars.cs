using search.Declare;

namespace search.Models
{
    public class Cars
    {
        public  Car[] CarItems { get; set; }
        public Cars(){
            CarItems =
            [
                    new (){ Id = 1, Name = "lada", CarNumber = 283469, Color = "crimson"},
                    new (){ Id = 1, Name = "lamborghini", CarNumber = 281671, Color = "red"},
                    new (){ Id = 2, Name = "ford", CarNumber = 273836, Color = "black"},
                    new (){ Id = 3, Name = "lexus", CarNumber = 108921, Color = "white"},
                    new (){ Id = 4, Name = "ferrari", CarNumber = 619653, Color = "blue"}
            ];
        }
    }
    public class Car: IBase {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int CarNumber {  get; set; }
        public required string Color { get; set; }
    }
    
}