using ItBrains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.ViewsModel
{
    public class HomeVM
    {
        public List<FeedBack> FeedBacks { get; set; }

        public About About { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
