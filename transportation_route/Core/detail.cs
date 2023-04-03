using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace transportationAPP.Core
{
    public class detail
    {

        public Guid ID { get; set; }
        public string Title { get; set; }//назва перевізника
        public string Address { get; set; }//адреса самого перевізника
        public string Email { get; set; }//пошта перевізника
        public string Phone { get; set; }//телефон перевізника

        public List<transportationRoute> transportation_route { get; set; }
        public List<points> Point { get; set; }

        public override string ToString()
        {
            string transportationTitles = string.Join(", ", transportation_route.Select(p => p.Title));
            string pointTitles = string.Join(", ", Point.Select(p => p.city_city));
            return $"Клiєнт: {Title}      Адреса перевiзника: {Address}      Пошта: {Email}      Телефон: {Phone}      Перевiзник: {transportationTitles}      Маршрут: {pointTitles}";
        }
    }

}