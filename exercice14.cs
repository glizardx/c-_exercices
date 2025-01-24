using System;

namespace Coding.Exercise
{
    public class Order
    {
        private string _item;
        private DateTime _date;

        public string Item
        {
            get { return _item; }
        }

        public DateTime Date
        {
            get { return _date; }
            set
            {
                if (value.Year == DateTime.Now.Year)
                {
                    _date = value;
                }
            }
        }

        public Order(string item, DateTime date)
        {
            _item = item;
            Date = date;
        }
    }
}
