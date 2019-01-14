using ArtGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGallery.ViewModel
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<ArtClass> Arts { get; set; }
    }
}
