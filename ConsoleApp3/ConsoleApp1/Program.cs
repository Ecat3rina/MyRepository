using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var trackingInfo = new TrackingInfo { Number = "121231213" };
            var trackingUpdater = new TrackingUpdater();
            var mailService = new MailService();

            //trackingUpdater.TrackingUpdated += mailService.OnTrackingUpdated;
            WeakEventManager<TrackingUpdater, EventArgs>.AddHandler(trackingUpdater, "TrackingUpdated", mailService.OnTrackingUpdated);
            trackingUpdater.Update(trackingInfo);
            //mailService = null;
            GC.Collect();
            trackingUpdater.Update(trackingInfo);

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }

    public class MailService
    {
        public void OnTrackingUpdated(object source, EventArgs e)
        {
            Console.WriteLine("Sending Email...");
        }
    }

    public class TrackingUpdater
    {
        public delegate void TrackingUpdatedEventHandler(object source, EventArgs args);
        //public event EventHandler<EventArgs> TrackingUpdated;
        public event TrackingUpdatedEventHandler TrackingUpdated;
        public void Update(TrackingInfo trackingInfo)
        {
            Console.WriteLine(trackingInfo.Number);

            OnTrackingUpdated();
        }
        protected virtual void OnTrackingUpdated()
        {
            TrackingUpdated?.Invoke(this, EventArgs.Empty);
        }
    }

    public class TrackingInfo
    {
        public string Number { get; set; }
    }
}
