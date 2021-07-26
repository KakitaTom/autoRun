using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Models;
using MainModule.Interface;
using MainModule.ModelViews;

namespace MainModule.Service
{
    public class UrlService : IUrlService
    {
        public IEnumerable<UrlRunView> GetList_Url()
        {
            using(var db = new akabiz_runEntities1())
            {
                var list = db.UrlRuns.ToList();

                var result = from r in list
                    select new UrlRunView() { Id = r.Id, Name = r.Name, IsActive = r.IsActive, TimeDeley = r.TimeDeley, Url = r.Url };

                return result;
            }
        }

        public IEnumerable<RunDetailView> GetList_RunDetail(int id)
        {
            using (var db = new akabiz_runEntities1())
            {
                var urlList = db.UrlRuns.ToList();
                var runDetailList = db.RunDetails.ToList();

                
                var result = from r in urlList
                    join rd in runDetailList on r.Id equals rd.UrlRunId
                    where r.Id == id
                    select new RunDetailView() { Id = r.Id, DateCreate = rd.DateCreate, IsActive = rd.IsActive, UrlRunId = rd.Id};
                return result;
            }
        }

        public int Add(UrlRunView url)
        {
            using (var db = new akabiz_runEntities1())
            {
                var list = db.UrlRuns.ToList();

                var urlInDb = list.FirstOrDefault(u => u.Url == url.Url);

                if(urlInDb != null)
                    return 1;

                var newUrl = new UrlRun()
                {
                    Name = url.Name,
                    IsActive = url.IsActive,
                    TimeDeley = url.TimeDeley,
                    Url = url.Url
                };

                db.UrlRuns.Add(newUrl);
                db.SaveChanges();
                return 0;
            }
        }

        public int Edit(UrlRunView url)
        {
            using (var db = new akabiz_runEntities1())
            {
                var list = db.UrlRuns.ToList();

                var urlInDb = list.SingleOrDefault(u => u.Url == url.Url);

                if (urlInDb != null)
                    if (urlInDb.Url != url.Url)
                        return 1; // Đã tồn tại URL đó rồi

                urlInDb = list.SingleOrDefault(u => u.Id == url.Id);

                if (urlInDb == null)
                    return 2; // Không tồn tại Url


                urlInDb.IsActive = url.IsActive;
                urlInDb.Name = url.Name;
                urlInDb.TimeDeley = url.TimeDeley;
                urlInDb.Url = url.Url;

                db.SaveChanges();
                return 0;
            }
        }

        public void Delete(int id)
        {
            using (var db = new akabiz_runEntities1())
            {
                var list = db.UrlRuns.ToList();

                var urlInDb = list.SingleOrDefault(u => u.Id == id);

                if (urlInDb == null)
                    return;

                var list2 = db.RunDetails.Where(r => r.UrlRunId == urlInDb.Id);

                db.RunDetails.RemoveRange(list2);
                db.SaveChanges();

                db.UrlRuns.Remove(urlInDb);
                db.SaveChanges();

            }
        }

        public void ChangeStatus(int id)
        {

            using (var db = new akabiz_runEntities1())
            {
                var list = db.UrlRuns.ToList();


                var urlInDb = list.SingleOrDefault(u => u.Id == id);

                if(urlInDb == null)
                    return;

                urlInDb.IsActive = urlInDb.IsActive != true;
                db.SaveChanges();

            }
        }

        public IEnumerable<UrlRunView> GetList_UrlWithActiveStatus()
        {
            using (var db = new akabiz_runEntities1())
            {
                var list = db.UrlRuns.ToList();

                var result = from r in list
                    where r.IsActive == true
                    select new UrlRunView() { Id = r.Id, Name = r.Name, IsActive = r.IsActive, TimeDeley = r.TimeDeley, Url = r.Url };

                return result;
            }
        }

        public IEnumerable<UrlRunView> GetList_UrlWithEditUrl(int id)
        {
            using (var db = new akabiz_runEntities1())
            {
                var list = db.UrlRuns.ToList();

                var result = from r in list
                    where r.IsActive == true && r.Id != id
                    select new UrlRunView() { Id = r.Id, Name = r.Name, IsActive = r.IsActive, TimeDeley = r.TimeDeley, Url = r.Url };

                return result;
            }
        }

        public int CreateRunDetails(RunDetailView runDetail)
        {
            using (var db = new akabiz_runEntities1())
            {
                var list = db.UrlRuns.ToList();

                var newRunDetail = new RunDetail()
                {
                    DateCreate = runDetail.DateCreate,
                    IsActive = runDetail.IsActive,
                    UrlRunId = runDetail.UrlRunId
                };

                db.RunDetails.Add(newRunDetail);
                db.SaveChanges();
                return 0;
            }
        }
    }
}
