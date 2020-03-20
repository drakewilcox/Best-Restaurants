using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public Restaurant()
    {
      this.Reviews = new HashSet<Review>();
    }
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Hours { get; set; }
    public int Rating { get; set; }
    public int CuisineId { get; set; }
    public string KeyWords { get; set; }
    public virtual Cuisine Cuisine { get; set; }
    public virtual ICollection<Review> Reviews { get; set; }
  }
}