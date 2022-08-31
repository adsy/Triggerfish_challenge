using Infrastructure.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Triggerfish_Challenge.Controllers
{
    public class NewsArticlesController : Controller
    {
        private readonly IArticleService _articleService;

        public NewsArticlesController(IArticleService articleService)
        {
            _articleService = articleService ?? throw new ArgumentNullException($"{nameof(articleService)} must not be null when initialising NewsArticleController");
        }

        public IActionResult Index()
        {
            var articlesResponse = _articleService.GetNewsArticles();

            if (articlesResponse.IsSuccessful)
            {
                return View(articlesResponse.ReturnData);
            }

            return View();
        }
    }
}
