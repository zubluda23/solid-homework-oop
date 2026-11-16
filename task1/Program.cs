using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    //Який принцип S.O.L.I.D. порушено? Виправте! В.:Принцип єдиного обов’язку
    class Item
    {

    }
    class Order
    {
        private List<Item> itemList;

        internal List<Item> ItemList
        {
            get
            {
                return itemList;
            }

            set
            {
                itemList = value;
            }
        }

        public void CalculateTotalSum() {/*...*/}
        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}
     }
    class OrderViewer
    {
        public void PrintOrder(Order order) {/*...*/}
        public void ShowOrder(Order order) {/*...*/}
    }


    class OrderRepository
    {
        public void Load(int orderId) {/*...*/}
        public void Save(Order order) {/*...*/}
        public void Update(Order order) {/*...*/}
        public void Delete(Order order) {/*...*/}
    }


    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Order order = new Order();
            order.AddItem(new Item());

            OrderViewer viewer = new OrderViewer();
            viewer.ShowOrder(order);

            OrderRepository repo = new OrderRepository();
            repo.Save(order);

            Console.WriteLine("Замовлення успішно оброблено!");
        }
    }
}
