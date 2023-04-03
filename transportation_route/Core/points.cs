using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transportationAPP.Core
{
    public class points
    {
        public Guid ID { get; set; }
        public string Title { get; set; }//назва перевізника
        public string city_city { get; set; }//місто місто
        public double Price { get; set; }//ціна поїздки
     
        
          public override string ToString()
        {
            return $"Перевiзник: {Title}      Маршрут: {city_city}      Ціна: {Price} грн";
        }
    }
}

