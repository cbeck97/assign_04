using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment_04.Models
{
    public class FavoriteRestaurants
    {
        //Constructor for the Model --> Creates a FavoriteRestaurants instance and sets the rank
        public FavoriteRestaurants(int rank)
        {
            Rank = rank;
        }

        //Properties of the Model
        //----------------------------------------------------------
        [Required]
        public int Rank { get; }

        [Required]
        public string Name { get; set; }

        public string? FavDish { get; set; }

        [Required]
        public string Address { get; set; }

        public string? Phone { get; set; }

        public string? Website { get; set; } = "Coming Soon";
        //---------------------------------------------------------

        //public method that returns a list of type FavoriteRestaurant that is preloaded with top 5 restaurants
        public static FavoriteRestaurants[] GetFavoriteRestaurants()
        {
            FavoriteRestaurants r1 = new FavoriteRestaurants(1)
            {
                Name = "Guru's",
                FavDish = "Cilantro Lime Casadilla",
                Address = "45 E Center St, Provo, UT 84606",
                Phone = "801-375-4878",
                Website = "www.guruscafe.com"
            };
            FavoriteRestaurants r2 = new FavoriteRestaurants(2)
            {
                Name = "Costa Vida",
                FavDish = "Sweet Pork Salad",
                Address = "1200 N University Ave, Provo, UT 84606",
                Phone = "801-373-1876",
                Website = "www.costavida.com"
            };
            FavoriteRestaurants r3 = new FavoriteRestaurants(3)
            {
                Name = "Panda Express",
                FavDish = "Chow Mein w/ Double Orange Chicken",
                Address = "1240 N University Ave",
                Phone = "801-818-0111",
                Website = "www.pandaexpress.com"
            };
            FavoriteRestaurants r4 = new FavoriteRestaurants(4)
            {
                Name = "Olive Garden",
                FavDish = "Chicken Alfredo",
                Address = "504 W 2230 N, Provo, UT, 84604",
                Phone = "801-134-7689",
            };
            FavoriteRestaurants r5 = new FavoriteRestaurants(5)
            {
                Name = "Buffalo Wild Wings",
                Address = "92 N 1200 E, Lehi, UT 84043",
                Phone = "801-766-8402",
                Website = "www.buffalowildwings.com"
            };
            return new FavoriteRestaurants[] { r1, r2, r3, r4, r5 };
        }

    }
}
