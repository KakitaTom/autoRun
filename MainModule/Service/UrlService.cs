using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using autoRun;
using MainModule.Interface;
using MainModule.ModelViews;

namespace MainModule.Service
{
    public class UrlService : IUrlService
    {
        public IEnumerable<UrlRunView> GetList_Url()
        {
            using(var db = new akabiz_runEntities())
            {
                var list = db.UrlRuns.ToList();

                var result = from r in list
                    select new { };

                
            }

            return null;
        }

        public IEnumerable<RunDetailView> GetList_RunDetail(int id)
        {
            throw new NotImplementedException();
        }

        public int Add(UrlRunView url)
        {
            throw new NotImplementedException();
        }

        public int Edit(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void ChangeStatus(int id)
        {
            throw new NotImplementedException();
        }
    }
}
