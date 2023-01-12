﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaMiaPizzeriaModel.Models
{
    public class Pizza
    {
        //MODELLO PIZZA

        //Proprietà Pizza
        public int Id { get; set; }

        [Column(TypeName = "varchar(300)")]
        [Required(ErrorMessage ="Il campo è obbligatorio")]
        [StringLength(300, ErrorMessage = "Non puoi andare oltre i 300 caratteri")]
        public string Image { get; set; }

        [Column(TypeName = "varchar(30)")]
        [Required(ErrorMessage = "Il campo è obbligatorio")]
       [StringLength(300, ErrorMessage = "Non puoi andare oltre i 100 caratteri")]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Description { get; set; }

        [Column(TypeName = "float(2)")]
        [Required(ErrorMessage = "Il campo è obbligatorio")]
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
