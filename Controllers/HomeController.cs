using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Schedule;

namespace mvc_sample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.datasource = GetScheduleData();
            ViewBag.template = "<div class='template-wrap' style='background:${SecondaryColor}'><div class='custom'> X </div><div class='subject'>${Subject}</div><div class='time'>Time: ${getTimeString(data.StartTime)} - ${getTimeString(data.EndTime)}</div></div>";
            return View();
        }
        public List<AppointmentData> GetScheduleData()
        {
            List<AppointmentData> appData = new List<AppointmentData>();
            appData.Add(new AppointmentData
            {
                Id = 1,
                Subject = "Explosion of Betelgeuse Star",
                Location = "Space Centre USA",
                StartTime = new DateTime(2018, 2, 15, 9, 30, 0),
                EndTime = new DateTime(2018, 2, 15, 11, 0, 0)
            });
            return appData;
        }

        public class AppointmentData
        {
            public int Id { get; set; }
            public string Subject { get; set; }
            public string Location { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public string CategoryColor { get; set; }
        }

    }
}