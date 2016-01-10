namespace DataLayer.UpWork
{
    public delegate void ServiceListener(Service state, string e);

    public class Service
    {
        public ServiceListener OnDataIsLoaded;

        protected void onRequestComplete(string response)
        {
            this.OnDataIsLoaded.Invoke(this, response);
        }
    }
}
