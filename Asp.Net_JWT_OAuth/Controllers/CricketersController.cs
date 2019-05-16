using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Asp.Net_JWT_OAuth.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class CricketersController : Controller
    {
        [HttpGet]
        [Authorize]
        public IEnumerable<Cricketer> Get()
        {
            var currentUser = HttpContext.User;
            var resultCricketerList = new Cricketer[] {
                new Cricketer {Name = "Virat Kohli", Title = "King Kohli", ThumbNail_Image = "https://www.cricketcountry.com/wp-content/uploads/2018/12/Virat-Kohli-PTI.jpeg" },
                new Cricketer {Name = "AB De Villiers", Title = "Mr 360", ThumbNail_Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR2XkOlQrDPhM4rv3ENq5SbMJwaWWbw62UWLmiqvlwJVqzOJJZiBg" },
                new Cricketer {Name = "Chris Gayle", Title = "Universe Boss", ThumbNail_Image = "https://www.wiplayers.com/wp-content/uploads/2015/12/chris-gayle.png" }
            };


            return resultCricketerList;
        }

        public class Cricketer
        {
            public string Name { get; set; }
            public string Title { get; set; }
            public string ThumbNail_Image { get; set; }
        }
    }
}
