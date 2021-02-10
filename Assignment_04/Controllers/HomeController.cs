using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment_04.Models;

namespace Assignment_04.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();

            foreach(FavoriteRestaurants f in FavoriteRestaurants.GetFavoriteRestaurants())
            {
                //If favDish is passed in as a null value, set favDish to "it's all tasty!"
                string? favDish = f.FavDish ?? "It's all tasty!";

                //This is a check to make sure that a correct link is passed in for the website. If the website is "coming soon", don't create a link
                if(f.Website != "Coming Soon")
                {
                    restaurantList.Add(string.Format($"<b>#{f.Rank}: {f.Name}</b> <br /><b>Favorite Dish:</b> {favDish} <br /><b>Address:</b> {f.Address}" +
                    $" <br /><b>Phone #:</b> {f.Phone} <br /><b>Website:</b> <a href=\"https://{f.Website}\" target=\"_blank\">{f.Website}</a>"));
                }
                else
                {
                    restaurantList.Add(string.Format($"<b>#{f.Rank}: {f.Name}</b> <br /><b>Favorite Dish:</b> {favDish} <br /><b>Address:</b> {f.Address}" +
                    $" <br /><b>Phone #:</b> {f.Phone} <br /><b>Website:</b> <a href=\"#\">{f.Website}</a>"));
                }
                
            }

            return View(restaurantList);
        }

        [HttpGet("Submit")]
        public IActionResult Submit()
        {
            return View();
        }

        [HttpPost("Submit")]
        public IActionResult Submit(Suggestions Suggestion)
        {
            //Checks to make sure that all of the data is valid before adding to temp storage
            if (ModelState.IsValid)
            {
                TempStorage.AddSuggestion(Suggestion);
            }
            
            return View();
        }

        public IActionResult Suggestions()
        {
            List<string> suggestionList = new List<string>();

            //creats the output string for the user suggested restaurants
            foreach(Suggestions s in TempStorage.Suggestions)
            {
                suggestionList.Add(string.Format($"<b>Suggestor:</b> {s.Name} <br /><b>Restaurant Name:</b> {s.Restaurant}" +
                    $"<br /><b>Favorite Dish:</b> {s.FavDish}<br /><b>Phone Number:</b> {s.Phone}"));
            }
            return View(suggestionList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
