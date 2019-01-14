using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtGallery.Models;
using ArtGallery.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ArtGallery.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArtRepository _artRepository;

        public HomeController(IArtRepository artRepository)
        {
            _artRepository = artRepository;  
        }

        public IActionResult Index()
        {
           
            var arts = _artRepository.getAllArtClasses().OrderBy(a => a.Name);
            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to Art Gallery",
                Arts = arts.ToList()
            };
            return View(homeViewModel);
        }
    }
}