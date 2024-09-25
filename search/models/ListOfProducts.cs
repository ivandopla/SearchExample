public static class ListOfProducts
{
    public static Dictionary<Property, Car[]> GetCarDictionary()
    {
        return new Dictionary<Property, Car[]>
        {
            { Property.Car,
                [
                    new Car{ Id = 1, Name = "lada", CarNumber = 283469, Color = "crimson"},
                    new Car{ Id = 1, Name = "lamborghini", CarNumber = 281671, Color = "red"},
                    new Car{ Id = 2, Name = "ford", CarNumber = 273836, Color = "black"},
                    new Car{ Id = 3, Name = "lexus", CarNumber = 108921, Color = "white"},
                    new Car{ Id = 4, Name = "ferrari", CarNumber = 619653, Color = "blue"}
                ]
            }
        };
    }

    public static Dictionary<Property, Vegetables[]> GetVegetablesDictionary()
    {
        return new Dictionary<Property, Vegetables[]>
        {
            { Property.Vegetables,
            [
                new Vegetables{ Id = 1, Name = "onion", Cost = 400, ForWhat = WeightMeasures.kg},
                new Vegetables{ Id = 2, Name = "cucumber", Cost = 150, ForWhat = WeightMeasures.kg},
                new Vegetables{ Id = 3, Name = "tomatoes", Cost = 200, ForWhat = WeightMeasures.kg},
                new Vegetables{ Id = 4, Name = "potatoes", Cost = 100, ForWhat = WeightMeasures.kg},
            ]
            }
        };
    }
}
