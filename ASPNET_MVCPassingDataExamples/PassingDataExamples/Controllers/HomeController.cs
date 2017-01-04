using PassingDataExamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassingDataExamples.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SampleBook()
        {
            // Passing Data using a Model Example
            //  Let us first see how we can create a strongly typed view which will display the data that is being 
            //  passed to it from the controller. Lets have a simple Model

            Book book = new Book
            {
                ID = 1,
                BookName = "Sample Book",
                Author = "Sample Author",
                ISBN = "Not available"
            };

            return View(book);
        }

        public ActionResult SampleBook2()
        {
            // Passing Data using a ViewModel Example
            // Now let us say we need a View that should display the data from multiple models. Lets say we 
            //  have one more class which is getting some custom message and it should be displayed on the page 
            //  whenever a Book data is being displayed. Now this message data is contained in a separate model

            Book book = new Book
            {
                ID = 1,
                BookName = "Sample Book",
                Author = "Sample Author",
                ISBN = "Not available"
            };

            Message msg = new Message
            {
                MessageText = "This is a Sample Message",
                MessageFrom = "Test User"
            };

            ShowBookAndMessageViewModel viewModel = new ShowBookAndMessageViewModel
            {
                Message = msg,
                Book = book
            };

            return View(viewModel);
        }

        public ActionResult SampleViewData()
        {
            // Passing Data using a ViewData Example
            // ViewData can be used to pass simple and small data from controller to the view Let is see 
            //  how we can pass a simple message string from Controller to View using ViewData.

            // Note: We are not type casting the data in view because it is simple string. If this data 
            //  would have been of some complex type, type casting would become inevitable.

            ViewData["Message"] = "This Message is coming from ViewData";

            return View();
        }

        public ActionResult SampleViewBag()
        {
            // Passing Data using a ViewBag Example
            // Implementing the same functionality but by using ViewBag instead of ViewData.

            ViewBag.Message = "This Message is coming from ViewBag";

            return View();
        }

        public ActionResult SampleBook3()
        {
            // Passing Data using a TempData Example
            // Now let us say we have an action method redirect to another action method and we need to 
            //  pass some data from one action method to another action method. To do this you we will 
            //  have to use TempData.

            Book book = new Book
            {
                ID = 1,
                BookName = "Sample Book",
                Author = "Sample Author",
                ISBN = "Not available"
            };

            TempData["BookData"] = book;
            return RedirectToAction("SampleBook4");
        }

        public ActionResult SampleBook4()
        {
            // Passing Data using a TempData Example

            // This action is called from SampleBook3

            // Now when the SampleBook3 action will be called it will create a Book type, put it in a TempData 
            //  variable and then redirect to action SampleBook4. Now in SampleBook4, the data will be extracted 
            //  from the TempData and then the View for the SampleBook4 will be shown which is a strongly typed 
            //  view and is capable of showing the data from the Book model.

            Book book = TempData["BookData"] as Book;

            return View(book);
        }

        public ActionResult SampleBook5()
        {
            // Use of sessions has nothing new for the the web developers.We can use session variables 
            //  to persist the data for a complete session.To demonstrate this let us implement the above 
            //  functionality using sessions instead of TempData.
            Book book = new Book
            {
                ID = 1,
                BookName = "Sample Book",
                Author = "Sample Author",
                ISBN = "Not available"
            };

            Session["BookData"] = book;
            return RedirectToAction("SampleBook6");
        }

        public ActionResult SampleBook6()
        {
            // Use of sessions has nothing new for the the web developers.We can use session variables 
            //  to persist the data for a complete session.To demonstrate this let us implement the above 
            //  functionality using sessions instead of TempData.

            // This action is called from SampleBook5

            // Now when the SampleBook5 action will be called it will create a Book type, put it in a session 
            //  variable and then redirect to action SampleBook6. Now in SampleBook6, the data will be extracted 
            //  from the Session and then the View for the SampleBook6 will be shown which is a strongly typed 
            //  view and is capable of showing the data from the Book model.

            Book book = Session["BookData"] as Book;

            return View(book);
        }
    }
}