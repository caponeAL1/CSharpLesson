using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace FirstMVCApp.Controllers
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
            return View();
        }
        public IActionResult DoLogin(String txtUser, String txtPwd)
        {
            ViewData["userValue"] =$"{ txtUser},{txtPwd }";
            return View();
        }
        public IActionResult SayHello(String name)
        { 
            if(String.IsNullOrEmpty(name))
            
                ViewData["v1"] = "Name is Empty";
             else
                ViewData["v1"] = name;
            
            ViewData["v1"] = name;
            return View();
        }
        public IActionResult Add(int x,int y)
        {
            int result = x + y;
            ViewData["result"]=result;
            return View("Add");
        }
        public IActionResult Multiply(int x, int y)
        {
            int result = x *y;
            ViewData["result"] = result;
            return View("Add");
        }
        public IActionResult Divide(int x, int y)
        {
            int result = x / y;
            ViewData["result"] = result;
            return View("Add");
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
        public IActionResult AddNewBook()
        {
            Book book = new Book();
            return View(book);
        }
        public IActionResult SaveNewBook(Book pBook)
        {
            String fName = @"c:\temp\book.csv";
            String strBook=$"{pBook.BookID}, {pBook.Title},{pBook.AuthorName},{pBook.Cost}";
            using (StreamWriter sw= new StreamWriter(fName,true))
            {
                sw.WriteLine(strBook);
            }
            return View(pBook);
        }
        public IActionResult ListAllBook()
        {
            String fName = @"c:\temp\book.csv";
            List<Book> list = new List<Book>();
            using (StreamReader sr = new StreamReader(fName))
            {
                string strBook = $"{sr.ReadLine()}";
                String[] data = strBook.Split(',');
                Book book = StringToBook(data,new Book());
                list.Add(book);
                while(!sr.EndOfStream)
                {
                    strBook = $"{sr.ReadLine()}";
                    data=strBook.Split(',');
                    book = StringToBook(data, new Book());
                    list.Add(book);

                }
            }
            return View(list);
        }
        private Book StringToBook(String[] data,Book book)
        {
          book.BookID = int.Parse(data[0]);
          book.Title = data[1];
          book.AuthorName = data[2];
          book.Cost = float.Parse(data[3]);
          return book;
        }
    }
}