namespace UpworkWP8
{
    public delegate void ServiceListener(Service state, string e);

    public abstract class Service : DataLayer.UpWork.interfaces.Service
    {
        public ServiceListener OnDataIsLoaded;

        public abstract object execute();

        protected void onRequestComplete(string response)
        {
            this.OnDataIsLoaded.Invoke(this, response);
        }
    }
}
