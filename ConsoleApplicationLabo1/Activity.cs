using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Activity
    {
        private String title;

        public String Title
        {
            get { return title; }
            set { title = value; }
        }

        private Boolean compulsory;

        public Boolean Compulsory
        {
            get { return compulsory; }
            set { compulsory = value; }
        }

        public Activity (String title, Boolean compulsory)
        {
            Title = title;
            Compulsory = compulsory;
        }

        public override string ToString()
        {
            return Title + (Compulsory ? " ( obligatoire )":" ") ;
        }

    }
}
