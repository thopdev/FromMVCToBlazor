using FromMVCToBlazor.Mvc.Models;
using FromMVCToBlazor.Shared.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FromMVCToBlazor.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRenderService _renderService;

        public HomeController(ILogger<HomeController> logger, IRenderService renderService)
        {
            _logger = logger;
            _renderService = renderService;
        }

        public IActionResult Index()
        {
            return View(_renderService.GetRenderType());
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
