using Domain.Model;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository ?? throw new ArgumentNullException($"{articleRepository} must not be null when initialising ArticleService");
        }

        public List<Article> GetNewsArticles()
        {
            return _articleRepository.GenerateNewsArticles();
        }
    }
}
