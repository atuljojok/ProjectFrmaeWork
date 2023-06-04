using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFrameworkCommonLib
{
    public class AppSettings
    {
        public string AppName { get; set; }
        public string MainHeading { get; set; }

        public string MainDesc { get; set; }
        public string Test { get; set; }

        public AppSettings()
        {
            AppName = "";
            MainHeading = "";
            MainDesc = "";
            Test = "";
        }
    }
    public class ContactSettings
    {
        public string ConName { get; set; }
        public string Adress { get; set; }
        public string Web { get; set; }
        public string Number { get; set; }


        public ContactSettings()
        {
            ConName = "";
            Adress = "";
            Web = "";
            Number = "";

        }
    }
}
