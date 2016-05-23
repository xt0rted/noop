namespace Website.Modules
{
    using Nancy;
    public class DefaultModule : NancyModule
    {
        public DefaultModule()
        {
            Get["/"] = _ => "hello";
        }
    }
}
