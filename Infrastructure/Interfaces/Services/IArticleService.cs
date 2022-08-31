using Domain;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces.Services
{
    public interface IArticleService
    {
        ServiceResponse<List<Article>> GetNewsArticles();
    }
}
