using Domain;
using Domain.Model;
using Infrastructure.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        public ArticleRepository()
        {

        }

        public ServiceResponse<List<Article>> RetrieveNewsArticlesFromApi()
        {
            // Do api call here if it was real..

            return new ServiceResponse<List<Article>>
            {
                StatusCode = (int)HttpStatusCode.OK,
                ReturnData = GenerateNewsArticles()
            };
        }

        private List<Article> GenerateNewsArticles()
        {
            return new List<Article>
            {
                new Article
                {
                    ArticleTitle = "Why demand for in-store contactless payments is here to stay",
                    Description = "The demand for in-store contactless payment technology has increased over the past two years. Learn more about this growing trend and how you can leverage it.",
                    ReadTime = "4 minute read",
                    ImageLink = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRkkmobZGv5YV4-jeoSttpgMM6OR1jnbYJBBQ&usqp=CAU"
                },
                new Article
                {
                    ArticleTitle = "7 ways to increase ecommerce sales",
                    Description = "Increase ecommerce sales with these 6 ideas to improve your customers' online payment experience.",
                    ReadTime = "6 minute read",
                    ImageLink = "https://cdn.mos.cms.futurecdn.net/CAZ6JXi6huSuN4QGE627NR.jpg"
                },
                new Article
                {
                    ArticleTitle = "How technology empowers businesses to prepare for the future of commerce",
                    Description = "The future of ecommerce is ever changing. Learn how our future-forward commerce technology keeps businesses at the forefront and removes complexity.",
                    ReadTime = "5 minute read",
                    ImageLink = "https://www.bankrate.com/2020/12/15121531/Best-online-brokers-for-stock.jpeg?auto=webp&optimize=high&crop=16:9"
                },
            };
        }
    }
}
