using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace V_DOC_Admin_Panel.Utilities
{
    class AppSetting
    {
        public static string ConnectionString()
        {

            return ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
        }
    }
}
