using Domain;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces.Repositories
{
    public interface IArticleRepository
    {
        ServiceResponse<List<Article>> RetrieveNewsArticlesFromApi();
    }
}
