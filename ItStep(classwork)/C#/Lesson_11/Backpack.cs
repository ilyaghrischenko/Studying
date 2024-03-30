using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_11
{
    public delegate void ItemHandler(string message);

    public class Backpack
    {
        private string _color;
        private string _producer;
        private double _weight;
        private int _volume;
        private Item[] _items;

        public Backpack()
        {
            Color = "NoColor";
            Producer = "NoProducer";
            Weight = 0;
            Volume = 0;
            Items = new Item[3] { new Item(), new Item(), new Item() };
        }
        public Backpack(string color, string producer, double weight, int volume, Item[] items)
        {
            Color = color;
            Producer = producer;
            Weight = weight;
            Volume = volume;
            Items = items;
        }

        public string Color
        {
            get { return _color; }
            set
            {
                if (value == string.Empty) throw new Exception("Color: Invalid value");
                foreach (var item in value)
                {
                    if(!char.IsLetter(item)) throw new Exception("Color: Invalid value");
                }

                _color = value;
            }
        }
        public string Producer
        {
            get { return _producer; }
            set
            {
                if (value == string.Empty) throw new Exception("Producer: Invalid value");
                foreach (var item in value)
                {
                    if (!char.IsLetter(item)) throw new Exception("Producer: Invalid value");
                }

                _producer = value;
            }
        }
        public double Weight
        {
            get { return _weight; }
            set
            {
                if (value < 0) throw new Exception("Weight: Invalid value");
                _weight = value;
            }
        }
        public int Volume
        {
            get { return _volume; }
            set
            {
                if (value < 0) throw new Exception("Volume: Invalid value");
                _volume = value;
            }
        }
        public Item[] Items
        {
            get { return _items; }
            set
            {
                if (value == null) throw new Exception("Items: Invalid value");
                _items = value;
            }
        }

        public void Show()
        {
            WriteLine($"Color: {Color} || Producer: {Producer} || Weight: {Weight} || Volume: {Volume}");
            WriteLine($"Items {Items.Length}:");
            foreach (var item in Items)
            {
                WriteLine(item);
            }
        }

        public event ItemHandler addItem;
        public event ItemHandler removeItem;
        public void AddItem(Item item)
        {
            Array.Resize(ref _items, Items.Length + 1);
            Items?.Append(item);
            addItem?.Invoke("Об'єкт за назвою item додано");
        }
        public void RemoveItem(Item item)
        {
            bool isFind = false;
            foreach (var el in Items)
            {
                if (el.ToString() == item.ToString()) isFind = true;
            }
            if (!isFind) throw new Exception("RemoveItem(Item): Item not found");

            Array.Resize(ref _items, Items.Length - 1);
            removeItem?.Invoke("Об'єкт за назвою item видалено");
        }
    }
}
