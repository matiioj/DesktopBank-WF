using System.Collections.Specialized;
using System.Configuration;

namespace DesktopBank.DAL
{
    public class DataAccess
    {
        DBSettings dbSettings;
        private readonly string connectionString;

        public DataAccess()
        {
            var Section = (NameValueCollection)ConfigurationManager.GetSection("MailSettings");
            dbSettings = new DBSettings(
                Section["ServerName"], Section["ServerUserName"], Section["ServerPassword"]
                );
        }
    }
}
