namespace Packt.Shared
{
    public partial class Person
    {
        
        //property defined using C# 1-5 syntax get only
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }
        
        //two properties defined using C# 6+ lambda expression
        public string Greeting => $"{Name} says 'Hello!'";
        public int Age => System.DateTime.Today.Year - DateOfBirth.Year;
        
        //properties with both get and set methods
        public string FavoriteIceCream { get; set; }

        private string favoritePrimaryColor;

        public string FavoritePrimaryColor
        {
            get
            {
                return favoritePrimaryColor;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favoritePrimaryColor = value;
                        break;
                    default:
                        throw new System.ArgumentException(
                            $"{value} in not a primary color." +
                            $"Choose from red, green, blue"
                            );
                }
            }
        }
    }
}