using System;


namespace R5T.D0119
{
    public class EventNotifier
    {
        public event EventHandler NotificationHandler;


        public void Notify()
        {
            this.NotificationHandler?.Invoke(
                this,
                new EventArgs());
        }
    }
}
