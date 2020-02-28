using System;
using System.Threading;

namespace ConsoleApp2
{
    public class TrackingInformationEventArgs : EventArgs
    {
        public string Number { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var trackingUpdater = new TrackingUpdater();
            var mailService = new MailService();
            var smsService = new SmsService();
            trackingUpdater.TrackingUpdated += mailService.OnTrackingUpdated;
            trackingUpdater.TrackingUpdated += smsService.OnTrackingUpdated;
            //trackingUpdater.Update();
        }
    }

    public class TrackingUpdater
    {
        //public delegate void TrackingUpdatedEventHandler(object source, TrackingInformationEventArgs args);
        //public event TrackingUpdatedEventHandler TrackingUpdated;
        public event EventHandler<TrackingInformationEventArgs> TrackingUpdated;
        public void Update()
        {
            //processing
            Console.WriteLine("Result proceeded");
            var args = new TrackingInformationEventArgs { Number = "1234123" };
            Thread.Sleep(3000);
            OnTrackingUpdated(args);
        }
        

        protected void OnTrackingUpdated(TrackingInformationEventArgs e)
        {
            TrackingUpdated?.Invoke(this, e);
        }
    }

    public class MailService
    {
        public void OnTrackingUpdated(object source, EventArgs e)
        {
            Console.WriteLine("Sending Email...");
        }
    }

    public class SmsService
    {
        public void OnTrackingUpdated(object source, EventArgs e)
        {
            Console.WriteLine("Sending Sms...");
        }
    }


}
