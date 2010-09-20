
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using MvcMusicStore.ViewModels;

namespace MvcMusicStore
{
    public class StoreController : Controller
    {
		//GET: /Store/
		public ActionResult Index()
		{
			// Create a list of genres 
			var genres = new List<string> {"Rock", "Jazz", "Country", "Pop", "Disco" }; 
			
			// Create our view model 
			var viewModel = new StoreIndexViewModel {  
			    NumberOfGenres = genres.Count(), 
			    Genres = genres 
			}; 
					
			return View(viewModel);
		}
		//GET: /Store/Browse
		public string Browse() 
		{ 
		    string message = "Store.Browse, Genre = " + 
		   	Server.HtmlEncode(Request.QueryString["genre"]); 
		    return Server.HtmlEncode(message); 
		}
		// GET: /Store/Details/5
        public string Details(int id)
        {
            string message = "Store.Details, ID = " + id;
			return Server.HtmlEncode(message);
        }
    }
}

