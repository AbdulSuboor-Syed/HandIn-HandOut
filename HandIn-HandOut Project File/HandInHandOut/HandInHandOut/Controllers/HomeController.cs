using HandInHandOut.Models;
using HandInHandOut.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HandInHandOut.Controllers
{    
    public class HomeController:Controller
    {
        private readonly IBooksRepository _booksRepository;
        private readonly IHostingEnvironment hostingEnvironment;        
        public HomeController(IBooksRepository booksRepository, IHostingEnvironment hostingEnvironment)
        {
            _booksRepository = booksRepository;
            this.hostingEnvironment = hostingEnvironment;
        }


        /// <summary>
        /// This method redirect users to the catalog where all the books are displayed taking data from database
        /// </summary>
        /// <returns>View(model)</returns>
        [Authorize]
        public ViewResult Index()
        {
            var model = _booksRepository.GetAllBooks();
                return View(model);
        }

        /// <summary>
        /// This method is used to redirect user to the information about the selected book
        /// </summary>
        /// <param name="id"></param>
        /// <returns>View(homeDetailsViewModel)</returns>
        public ViewResult Details(int? id)
        {            
            Books bookCheck = _booksRepository.GetBooks(id.Value);
            if(bookCheck == null)
            {
                Response.StatusCode = 404;
                return View("BookNotFound",id.Value);
            }


            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                books = bookCheck,
                PageTitle = "Books Details"
        };          
            return  View(homeDetailsViewModel);
        }

        /// <summary>
        /// This method redirects users to Create Book Page
        /// </summary>
        /// <returns>View()->Home/Create</returns>
        [HttpGet]
        [Authorize(Roles = "Admin,Collaborator")]

        public ViewResult Create()
        {
            return View();
        }
        /// <summary>
        /// This method takes information about new books and updates the database
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Roles = "Admin,Collaborator")]
        public IActionResult Create(BookCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = ProcessUploadFile(model);
                Books newBook = new Books
                {
                    Name = model.Name,
                    Major = model.Major,
                    Author = model.Author,
                    NumberOfBooksAvailable = model.NumberOfBooksAvailable,
                    BuyingAmount = model.BuyingAmount,
                    RentingAmount = model.RentingAmount,
                    IsAvailable = model.IsAvailable,
                    PhotoPath = uniqueFileName
                };
                _booksRepository.Add(newBook);
                return RedirectToAction("details", new { id = newBook.id });
            }
            return View();
        }

   
        /// <summary>
        /// This method is used to redirect user to the home page
        /// </summary>
        /// <returns>View(Home\Welcome)</returns>
        [AllowAnonymous]
        public ViewResult Welcome()
        {
            return View();
        }
     
        /// <summary>
        /// This method is used to redirect the user to Sell Books page
        /// </summary>
        /// <returns></returns>
        public ViewResult SellBooks()
        {
            return View();
        }

        /// <summary>
        /// This method is used to redirect the user to About us page
        /// </summary>
        /// <returns></returns>
        public ViewResult AboutUs()
        {
            return View();
        }

        /// <summary>
        /// This method is used to redirect the user to Edit a book information
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Authorize(Roles = "Admin,Collaborator")]
        public ViewResult Edit(int id)
        {
            Books book = _booksRepository.GetBooks(id);
            BookEditViewModel booksEditViewModel = new BookEditViewModel
            {
                id = book.id,
                Name = book.Name,
                Author = book.Author,
                Major = book.Major,
                BuyingAmount = book.BuyingAmount,
                RentingAmount = book.RentingAmount,
                NumberOfBooksAvailable = book.NumberOfBooksAvailable,
                IsAvailable = book.IsAvailable,
                ExistingPhotoPath = book.PhotoPath
            };
            return View(booksEditViewModel);
        }

        /// <summary>
        /// This method is used to update database after the data is altered for a book
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Roles = "Admin,Collaborator")]

        public IActionResult Edit(BookEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Books book = _booksRepository.GetBooks(model.id);
                book.Name = model.Name;
                book.Author = model.Author;
                book.Major = model.Major;
                book.NumberOfBooksAvailable = model.NumberOfBooksAvailable;
                book.BuyingAmount = model.BuyingAmount;
                book.RentingAmount = model.RentingAmount;
                book.IsAvailable = model.IsAvailable;
                if (model.Photo != null)
                {
                    book.PhotoPath = ProcessUploadFile(model);
                }
                _booksRepository.UpdateBooks(book);
                return RedirectToAction("index");
            }
            return View();
        }


        /// <summary>
        /// This methos is used to delete a book from the repository
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Roles = "Admin,Collaborator")]
        public IActionResult delete(int id)
        {
            Books book = _booksRepository.Delete(id);
            return RedirectToAction("index");
        }



        /// <summary>
        /// This method is used to add photos with unique path
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private string ProcessUploadFile(BookCreateViewModel model)
        {
            string uniqueFileName = null;
            if (model.Photo != null)
            {
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using(var fileroute= new FileStream(filePath, FileMode.Create))
                {
                    model.Photo.CopyTo(fileroute);
                }
                

            }

            return uniqueFileName;
        }
    }



}
