using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainModule.ModelViews;

namespace MainModule.Interface
{
    public interface IUrlService
    {
        IEnumerable<UrlRunView> GetList_Url();
        IEnumerable<RunDetailView> GetList_RunDetail(int id);
        int Add(UrlRunView url);
        int Edit(UrlRunView url);
        void Delete(int id);
        void ChangeStatus(int id);
        IEnumerable<UrlRunView> GetList_UrlWithActiveStatus();
        IEnumerable<UrlRunView> GetList_UrlWithEditUrl(int id);
        int CreateRunDetails(RunDetailView runDetail);
    }
}
