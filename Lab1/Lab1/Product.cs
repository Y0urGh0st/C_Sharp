using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Product
    {
        private string _name;
        private decimal _price;
        private int _quantity;
   
        public Product(string _name, decimal _price, int _quantity)
        {
            Name = _name;
            Price = _price;
            this._quantity = _quantity;

        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Назва товару не може бути порожньою");
                _name = value;
            }
        }
        public decimal Price
        {
            get { return _price; }
            set 
            {
                if (value < 0)
                    throw new ArgumentException("Ціна не може бути від'емною!");
                _price = value;

            }


        }
        public int Quantity
        {
             get; private set; 
        }
        public decimal TotalValue
        {
            get { return _quantity * _price; }
        }
        public void Restock(int amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine("Кількість товарів повинна бути додатною");
                return;
            }
            _quantity += amount;
        }
        public void Sell(int amount)
        {
            if(amount > _quantity)
            {
                Console.WriteLine("Недостатньо товару на складі");
                return;
            }
            if(amount <= 0)
            {
                Console.WriteLine("Кількість продажу повина бути дадотною");
                return;
            }
            _quantity -= amount;
        }
        public string GetInfo()
        {
            return $"Товар:  {Name}, Ціна: {Price}, Кількість: {Quantity}, Загальна вартість: {TotalValue} грн ";
        }

    }
}
