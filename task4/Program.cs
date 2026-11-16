using System;

/*Даний інтерфейс поганий тим, що він включає занадто багато методів.
 А що, якщо наш клас товарів не може мати знижок або промокодом, або для нього немає сенсу встановлювати матеріал з 
 якого зроблений (наприклад, для книг). Таким чином, щоб не реалізовувати в кожному класі невикористовувані в ньому методи, краще 
розбити інтерфейс на кілька дрібних і кожним конкретним класом реалізовувати потрібні інтерфейси.
Перепишіть, розбивши інтерфейс на декілька інтерфейсів, керуючись принципом розділення інтерфейсу. 
Опишіть класи книжки (розмір та колір не потрібні, але потрібна ціна та знижки) та верхній одяг (колір, розмір, ціна знижка),
які реалізують притаманні їм інтерфейси.*/

using System.Globalization;
using System.Text;


public interface IPriceable
{
    void SetPrice(double price);
}

public interface IDiscountable
{
    void ApplyDiscount(string discount);
    void ApplyPromocode(string promocode);
}

public interface IClothable
{
    void SetColor(byte color);
    void SetSize(byte size);
}

class Book : IPriceable, IDiscountable
{
    public double Price { get; private set; }

    public void SetPrice(double price)
    {
        Price = price;
    }

    public void ApplyDiscount(string discount)
    {
        double percent = double.Parse(discount, CultureInfo.InvariantCulture);
        Price -= Price * percent / 100;
    }

    public void ApplyPromocode(string promocode)
    {
        if (promocode == "SALE10")
        {
            ApplyDiscount("10");
        }
    }
}


class Outerwear : IPriceable, IDiscountable, IClothable
{
    public double Price { get; private set; }
    public byte Color { get; private set; }
    public byte Size { get; private set; }

    public void SetPrice(double price)
    {
        Price = price;
    }

    public void ApplyDiscount(string discount)
    {
        double percent = double.Parse(discount, CultureInfo.InvariantCulture);
        Price -= Price * percent / 100;
    }

    public void ApplyPromocode(string promocode)
    {
        if (promocode == "SALE10")
        {
            ApplyDiscount("10");
        }
    }

    public void SetColor(byte color)
    {
        Color = color;
    }

    public void SetSize(byte size)
    {
        Size = size;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Book book = new Book();
        book.SetPrice(200);
        book.ApplyDiscount("10");
        book.ApplyPromocode("SALE10");
        Console.WriteLine("Книжка: ціна " + book.Price);

        Outerwear jacket = new Outerwear();
        jacket.SetPrice(1500);
        jacket.SetColor(3);
        jacket.SetSize(48);
        jacket.ApplyDiscount("20");
        jacket.ApplyPromocode("SALE10");
        Console.WriteLine("Верхній одяг: ціна " + jacket.Price + ", колір " + jacket.Color + ", розмір " + jacket.Size);

        Console.ReadKey();
    }
}




//interface IItem
//{
// void ApplyDiscount(String discount);
//void ApplyPromocode(String promocode);

//void SetColor(byte color);
//void SetSize(byte size);

//void SetPrice(double price);
//}

//class Program
//{
//static void Main(string[] args)
//{

// Console.ReadKey();
//}
//}