using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryTestovyiBilet
{
    public class AbonentClass
    {
        //public List<string> abonetsList = new List<string>()
        //{ "id", "Фамилия", "Имя", "Отчество", "Номер кредитной карточки", "Дебет" };

        public int Id { get; set; }
        public static string LastName { get; set; }
        public static string FirstName { get; set; }
        public static string Patronymic { get; set; }
        public static string CreditCardNumber { get; set; }
        public static decimal Debit { get; set; }

        public static List<AbonentClass> abonetsList = new List<AbonentClass>();

        public static bool Abonets(int  idAbonent, string lastName, string firstName, string patronymic, string creditCardNumber, int debit)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(idAbonent)) || !string.IsNullOrEmpty(lastName) || !string.IsNullOrEmpty(firstName) || !string.IsNullOrEmpty(patronymic) || !string.IsNullOrEmpty(creditCardNumber) || !string.IsNullOrEmpty(Convert.ToString(debit)))
            {
                int countId = abonetsList.Where(x => x.Id == idAbonent).Count();
                if (countId != 0)
                    return false;
                if (!Regex.IsMatch(creditCardNumber, @"^\d{4}-\d{4}-\d{4}-\d{4}$"))
                    return false;

                //Id = idAbonent;
                //LastName = lastName;
                //FirstName = firstName;
                //Patronymic = patronymic;
                //CreditCardNumber = creditCardNumber;
                //Debit = debit;
            }
            else
                return false;

            return true;
        }

        public static void AddAbonent(int idAbonent, string lastName, string firstName, string patronymic, string creditCardNumber, int debit)
        {
            //var abonent = new AbonentClass(idAbonent, lastName, firstName, patronymic, creditCardNumber, debit);

            //var abonent = new AbonentClass()
            //{
            //    Id = idAbonent,
            //    LastName = lastName,
            //    FirstName = firstName,
            //    Patronymic = patronymic,
            //    CreditCardNumber = creditCardNumber,
            //    Debit = debit,
            //};
            //abonetsList.Add(abonent);
        }

        public void EditAbonent(int idAbonent, string lastName, string firstName, string patronymic, string creditCardNumber, int debit)
        {
            //if (!string.IsNullOrEmpty(lastName))
            //{
            //    var objLastName = abonetsList.Where(x => x.Id = idAbonent).FirstOrDefault();
            //    objLastName.LastName = lastName;
            //}

        }
    }
}
