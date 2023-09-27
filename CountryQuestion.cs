using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Practico___Flag_Quiz
{
    internal class CountryQuestion
    {
        private string countryName;
        private string imgRoute;
        private bool hasBennAnswered;
        private string uriPrefix = "https://flagcdn.com/160x120/";

        public CountryQuestion(string countryName, string imgRoute)
        {
            this.countryName = countryName;
            this.imgRoute = $"{uriPrefix}{imgRoute}.png";
            hasBennAnswered = false;
        }

        public string CountryName { get { return countryName; } }
        public string ImageRoute { get { return imgRoute; } }
        public bool HasBennAnswered { get { return hasBennAnswered; } set { hasBennAnswered = value; } }
    }
}
