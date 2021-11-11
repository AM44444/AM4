using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AM4_MVC.Models
{
    public class About
    {
        public long Id { get; set; }
        public string Name  { get; set; }
        public string City  { get; set; }
        public string Description1  { get; set; }
        public string Description2  { get; set; }
        public string Experience { get; set; }
        public string Image { get; set; }


        public About(long id, string name, string city, string description1, string description2, string experience, string image)
        {
            Id = id;
            Name = name;
            City = city;
            Description1 = description1;
            Description2 = description2;
            Experience = experience;
            Image = image;
        }

    }
}
