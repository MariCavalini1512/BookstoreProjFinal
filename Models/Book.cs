﻿using System.ComponentModel.DataAnnotations;

namespace Bookstoret2.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Title { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public double Price { get; set; }

        [Display(Name = "Autor")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Author { get; set; }

        [Display(Name = "Ano de Lançamento")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int ReleaseYear { get; set; }

        [Display(Name = "Gêneros Literários")]
        public ICollection<Genre> Genres { get; set; } = new List<Genre>();

        public Book()
        {

        }

        public Book(int id, string title, double price, string author, int releaseYear)
        {
            Id = id;
            Title = title;
            Price = price;
            Author = author;
            ReleaseYear = releaseYear;
        }
    }
}
