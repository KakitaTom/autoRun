using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainModule.ModelViews
{
    public class UrlRunView
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public int? TimeDeley { get; set; }
        public bool? IsActive { get; set; }
    }
}
