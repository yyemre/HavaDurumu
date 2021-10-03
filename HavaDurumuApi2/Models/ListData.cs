using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HavaDurumuApi2.Models;

namespace HavaDurumuApi2
{
    public static class ListData 
    {
        static List<Data> dataList = new List<Data>();

        public static List<Data> getHavaDurumu()
        {
            return dataList;
        }
        public static void addHavaDurumu(Data data)
        {
            dataList.Add(data);
        }
    }
}
