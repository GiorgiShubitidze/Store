using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using SportsStorenew.Service;
using SportsStoreNew.Domain;
using SportsStoreNew.Domain.DB;
using SportsStoreNew.Service;
using SportsStoreNew.Service.Models;

namespace SportsStoreNew.Controllers
{
    [Authorize]
   
    public class HomeController : Controller
    {
        IBrowsingAppService _browsingAppService;
        private readonly IEmailSender _emailSender;


        public HomeController(IBrowsingAppService browsingAppService ,IEmailSender emailSender)
        {
            _emailSender = emailSender;
            _browsingAppService = browsingAppService;
        }
        // GET: HomeController
      [AllowAnonymous]
        public IActionResult Index(string categoryName, string productName, int page = 1)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var products = _browsingAppService.GetProducts(new
                Service.Models.GetProductsRequest
            {
                CategoryName = categoryName,
                PageSize = 8,
                Page = page,
                Name = productName
            });
            return View(products);
        }

        [AllowAnonymous]
        public IActionResult Details(int Id)
        {
            var product = _browsingAppService.GetProduct(Id);
            return View(product); 
        }
        [AllowAnonymous]
        public ActionResult Contact()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Contact(string name , string receiver,string email , string subject, string message)
        {
            var NameMassage = $"გამარჯობა მე ვარ {name}   {message}    მეილი: {email}";
            if(email == null || message ==null)
            {
                ViewBag.Error = " თქვენი მეილი არ გაიგზვნა  , გთხოვთ შეავსოთ ყველა ველი და  სცადოთ თავიდან";
                return View();
            }
            else
            {
                var Sent = _emailSender.SendEmailAsync("shubi1213@gmail.com", subject, NameMassage);
                if (Sent != null)
                {
                    ViewBag.Success = " თქვენი მეილი წარმატებით გაიგზავნა";
                    return View();
                }
            }
            return View();
        }

    }
}
