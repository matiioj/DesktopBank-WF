using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.DAL
{
    public class DBSettings
    {
        public string ServerName{ get; }
        public string ServerUserName { get; }
        public string ServerPassword { get; }

        public DBSettings(string ServerName, string ServerUserName, string ServerPassword )
        {
            this.ServerName = ServerName;
            this.ServerUserName = ServerUserName;
            this.ServerPassword = ServerPassword;
        }
    }
}
