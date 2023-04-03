using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using transportationAPP.Service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace transportationAPP.Core
{
    public class transportationRoute
    {
        public Guid id { get; set; }//індивідуальне ід
        public string Title { get; set; }//назва перевізника
        public double Rating { get; set; }//рейтинг
        public string country_country { get; set; }//країна прибуття і вибуття
        public string Phone { get; set; }//телефон
        public List<points> Points { get; set; }

        public override string ToString()
        {
            string pointTitles = string.Join(", ", Points.Select(p => p.city_city));
            return $"Назва перевізника: {Title}     Рейтинг: {Rating}      Країна прибуття і вибуття: {country_country}      Телефон: {Phone}     Маршрути: {pointTitles}";
        }
    }
}

