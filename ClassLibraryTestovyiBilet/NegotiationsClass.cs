using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTestovyiBilet
{
    public class NegotiationsClass
    {
        public TimeSpan CallDuration { get; set; }
        public int AbonentId { get; set; }
        public string Type { get; set; }
        public DateTime CallDate { get; set; }

        //public void Call(TimeSpan callDuration, int abonent, string type, DateTime callDate)
        //{
        //    Call(callDuration, abonent, type, callDate, AbonentClass);
        //}

        //public void Call(TimeSpan callDuration, int abonent, string type, DateTime callDate, AbonentClass abonentClass)
        //{
        //    if (callDuration.TotalSeconds <= 0) throw new ArgumentException("Длительность переговоров должна быть положительным значением");
        //    if (abonent == null) throw new ArgumentNullException(nameof(abonent), "Абонент не может быть null");

        //    CallDuration = callDuration;
        //    AbonentId = abonentClass.Id;
        //    Type = type;
        //    CallDate = callDate;
        //}
    }
}
