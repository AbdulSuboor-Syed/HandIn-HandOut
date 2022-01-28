using HandInHandOut.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HandInHandOut.ViewModels
{
    public class BookCreateViewModel
    {        

        [Required]
        public string Name { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public Major? Major { get; set; }
        public double BuyingAmount { get; set; }
        public double RentingAmount { get; set; }
        public Available IsAvailable { get; set; }

        public int NumberOfBooksAvailable { get; set; }

        public IFormFile Photo { get; set; }
    }
}
