using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using autoRun.UI;
using MainModule.Interface;
using MainModule.ModelViews;
using MainModule.Service;

namespace autoRun.Common
{
    public static class ThreadCommon
    {
        private static readonly IUrlService _urlService = new UrlService();
        private static Thread newThread;
        private static CancellationTokenSource _cts;

        public static void ThreadStart(IEnumerable<UrlRunView> listUrl)
        {
            Thread.Sleep(500);
            _cts = new CancellationTokenSource();
            newThread = new Thread(() => AddTaskToThread(listUrl));
            newThread.Start();
        }

        public static void ThreadStop()
        {
            _cts.Cancel();
        }

        private static void AddTaskToThread(IEnumerable<UrlRunView> urlList)
        {
            foreach (var item in urlList)
            {
                try
                {
                    Task.Run(async () =>
                    {
                        while (true)
                        {
                            _cts.Token.ThrowIfCancellationRequested();
                            await Task.Run(() => CreateRunDetail(item));
                            if (_cts.Token.IsCancellationRequested)
                            {
                                _cts.Token.ThrowIfCancellationRequested();
                            }
                        }
                    }, _cts.Token);

                }
                catch (OperationCanceledException e)
                {
                    return;
                }
            }
        }

        private static void CreateRunDetail(UrlRunView url)
        {
            Task.Delay((int)url.TimeDeley * 1000).Wait(_cts.Token);

            if (_cts.IsCancellationRequested)
                return;

//            MessageBox.Show(url.Url);

            var run = new RunDetailView()
            {
                DateCreate = DateTime.Now,
                IsActive =  "Lỗi",
                UrlRunId = url.Id
            };

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url.Url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                var get = client.GetAsync("");
                get.Wait();

                var result = get.Result;
                if (result.IsSuccessStatusCode)
                {
                    var read = result.Content.ReadAsStringAsync();
                    read.Wait();
                    run.IsActive = "Tốt";
                    MessageBox.Show(read.Result);
                }
            }
            _urlService.CreateRunDetails(run);
        }
    }
}
