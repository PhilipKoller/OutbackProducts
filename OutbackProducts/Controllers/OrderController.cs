using Microsoft.AspNetCore.Mvc;
using OutbackProducts.Models;

namespace OutbackProducts.Controllers
{
    public class OrderController : Controller
    {
        public ViewResult Checkout() => View(new Order());
    }
}