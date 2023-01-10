using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaMiaPizzeriaModel.Models
{
    public class Pizza
    {
        //MODELLO PIZZA

        //Proprietà Pizza
        public int Id { get; set; }
        [Column(TypeName = "varchar(300)")]
        public string Image { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "text")]
        public string Description { get; set; }
        public float Price { get; set; }

        //Costruttore pizza vuoto utile per quanto si lavora con DB
        public Pizza()
        {

        }

        //Costruttore Pizza senza id perché gestito da DB
        public Pizza(string image, string name, string description, float price)
        {
            Image = image;
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
