using Ring;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            IRingApi api = new RingApi();

            api.Session.StartAsync().GetAwaiter().GetResult();
        }
    }
}
