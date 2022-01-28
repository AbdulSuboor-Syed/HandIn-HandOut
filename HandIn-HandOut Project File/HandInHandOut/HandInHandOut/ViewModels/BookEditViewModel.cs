using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandInHandOut.ViewModels
{
    public class BookEditViewModel:BookCreateViewModel
    {
        public int id { get; set; }
        public string ExistingPhotoPath { get; set; }
    }
}
