using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainModule.ModelViews
{
    public class RunDetailView
    {
        public int Id { get; set; }
        public DateTime? DateCreate { get; set; }
        public string IsActive { get; set; }
        public int? UrlRunId { get; set; }
    }
}
