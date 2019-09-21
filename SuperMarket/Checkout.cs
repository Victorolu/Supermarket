using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    public class Item
    {
        public string name;
        public int price;
    }

    public class Checkout<T> : ICheckout
    {
        public List<string> _items;
        public int totalPrice;

        public Checkout(List<string> items)
        {
            _items = items;
            AddingToScan();
        }

        public void AddingToScan()
        {
            try
            {
                foreach (var it in _items)
                {
                    Item item = new Item();

                    switch (it.ToLower())
                    {
                        case "a":
                            item.name = it;
                            item.price = 50;
                            break;

                        case "b":
                            item.name = it;
                            item.price = 30;
                            break;

                        case "c":
                            item.name = it;
                            item.price = 20;
                            break;

                        case "d":
                            item.name = it;
                            item.price = 15;
                            break;

                        default:
                            throw new Exception("Item not registered");
                    }

                    Scan(item);
                }
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public void Scan(Item item)
        {
            totalPrice += item.price;
        }

        public int Total()
        {
            var countA = _items.GroupBy(_ => _).Where(_ => _.Key.ToLower() == "a").Sum(_ => _.Count());
            var countB = _items.GroupBy(_ => _).Where(_ => _.Key.ToLower() == "b").Sum(_ => _.Count());

            if (countA > 2) {
                do {
                    totalPrice -= 20;
                    countA -= 3;
                } while (countA >= 3);
            }

            if (countB > 1) {
                do
                {
                    totalPrice -= 15;
                    countB -= 2;
                } while (countB >= 2);
            }


            return totalPrice;
        }
    }
}
