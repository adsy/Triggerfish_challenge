using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Article
    {
        public string ArticleTitle { get; set; }
        public string Description { get; set; }
        public string ReadTime{ get; set; }
        public string ImageLink{ get; set; }
    }
}
