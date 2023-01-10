namespace LaMiaPizzeriaModel.Models
{
    public class Pizza
    {
      //MODELLO PIZZA

        //Proprietà Pizza
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }

        //Costruttore Pizza
        public Pizza(int id, string image, string name, string description, float price)
        {
            Id = id;
            Image = image;
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
