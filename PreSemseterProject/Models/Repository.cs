using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreSemseterProject.Models
{
    public static class Repository
    {
        private static List<Volunter> VolunterInformation = new List<Volunter>();

        public static IEnumerable<Volunter> VolInfo
        {
            get
            {
                return VolunterInformation;
            }
        }


        public static void AddVolunter(Volunter volinfo)
        {
            VolunterInformation.Add(volinfo);
        }
    }
}
