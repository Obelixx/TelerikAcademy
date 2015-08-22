using System;
namespace Log4netExample
{
    using log4net;

    public class LoggerExample
    {
        private static ILog Log = LogManager.GetLogger(typeof(LoggerExample));

        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();

            try
            {
                Log.Info("Trying something.");
                throw new Exception("Test exception"); // Tried with and without comment on this line...
                Log.Info("This is successful!");
            }
            catch (Exception ex)
            {
                Log.Error("This is unsuccessful!", ex);
            }

            Log.Debug("Program exited.");
        }
    }
}
