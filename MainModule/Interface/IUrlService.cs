using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainModule.ModelViews;

namespace MainModule.Interface
{
    interface IUrlService
    {
        IEnumerable<UrlRunView> GetList_Url();
        IEnumerable<RunDetailView> GetList_RunDetail(int id);
        int Add(UrlRunView url);
        int Edit(int id);
        void Delete(int id);
        void ChangeStatus(int id);
    }
}
