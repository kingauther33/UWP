using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1.Adapters
{
    class Adapter
    {
        private string baseURL = "https://foodgroup.herokuapp.com/api/menu";

        // singleton pattern

        private static Adapter instance;

        private Adapter() { }

        public static Adapter GetAdapter()
        {
            if (instance == null)
            {
                instance = new Adapter();
            }
            return instance;
        }

        public string GetMenuApi
        {
            get => String.Format(baseURL + "/api/menu");
        }
    }
}
