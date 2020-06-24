using System;

namespace ConsoleApp1
{
    class Customer
    {
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }

        public int Birthday_day { get; private set; }
        public int Birthday_month { get; private set; }

        public Customer(string firstname, string lastname, int birthday_day, int birthday_month)
        {
            Firstname = firstname ?? throw new ArgumentNullException(nameof(firstname));
            Lastname = lastname ?? throw new ArgumentNullException(nameof(lastname));
            Birthday_day = birthday_day;
            Birthday_month = birthday_month;
        }

        public override string ToString()
        {
           return ("\nПользователь:" + Lastname + " " + Firstname + "\n День рождения:" + Birthday_day + "." + Birthday_month);
        }

    }
}