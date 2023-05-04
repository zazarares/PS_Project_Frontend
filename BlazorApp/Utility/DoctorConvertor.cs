using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Utility
{
    public static class DoctorConvertor
    {
        public static List<string> ConvertDoctor(List<Doctor> D)
        {
            List<string> toReturn=new List<string>();
            for(int i= 0;i<D.Count;i++)
            {
                toReturn.Add(D[i].FirstName + " " + D[i].LastName);
            }
            return toReturn;
        }
        public static List<string> ConvertLocation(List<Location> L)
        {
            List<string> toReturn = new List<string>();
            for (int i = 0; i < L.Count; i++)
            {
                toReturn.Add(L[i].name);
            }
            return toReturn;
        }
    }
}
