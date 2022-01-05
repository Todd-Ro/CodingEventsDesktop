using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CodingEvents.Controllers
{
    

    public class EventsController : Controller
    {
        
        static private List<string> eventList;


        public IActionResult Index()
        {
            if(eventList is null)
            {
                eventList = new List<string>();
            }
            if(!eventList.Contains("REACT"))
            {
                eventList.AddRange(new List<string>
                {
                    "STL Coders",
                    "Geek Gala",
                    "REACT"
                });
            }
            
            ViewBag.alltheevs = eventList;
            return View();
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Events/Add")]
        public IActionResult NewEvent(string eventName)
        {
            if (eventList is null)
            {
                eventList = new List<string>();
            }
            eventList.Add(eventName);

            return Redirect("/Events");
        }
    }

    
}
