
Teapot Tefal = new Teapot("Tefal", "2кВт");
Tefal.Sound();
Tefal.Snow();
Tefal.Desc();

Microwave Beko = new Microwave("Beko", "800 Вт");
Beko.Sound();
Beko.Snow();
Beko.Desc();

Car car = new Car("kia", 122, "white");
car.Sound();
car.Snow();
car.Desc();

Steamboat steamboat = new Steamboat("Н. В. Гоголь", 80, 10);
steamboat.Sound();
steamboat.Snow();
steamboat.Desc();

class Device
{
    protected string _name;

    public string Name
    { get { return _name;}
        set { _name = value; }
    }
    public Device(string name)
    {
        _name = name;
    }
    public virtual void Sound() { }
    public virtual void Snow() { }
    public virtual void Desc() { }
}

class Teapot : Device
{
    string _power;

    public Teapot(string name,string power):base(name)
    {
        Name = name;
        _power = power;
    }
    public override void Sound()
    {
        Console.WriteLine("Звук кипящего чайника.");
    }
    public override void Snow() 
    {
        Console.WriteLine($"Это устройство называется чайник {_name}");
    }
    public override void Desc()
    {
        Console.WriteLine($"Мощность этого устройства {_power}\n");
    }
}
class Microwave : Device
{
    string _power;

    public Microwave(string name,string power):base(name)
    {
        Name = name;
        _power = power;
    }
    public override void Sound()
    {
        Console.WriteLine("Дзинььь.");
    }
    public override void Snow() 
    {
        Console.WriteLine($"Это устройство называется микровалновая печь {_name}");
    }
    public override void Desc()
    {
        Console.WriteLine($"Мощность этого устройства {_power}\n");
    }
}

class Car:Device
{
    int _number_of_horsepower;
    string _color;


    public Car(string name, int number_of_horsepower,string color) : base(name)
    {
        Name = name;
        _number_of_horsepower= number_of_horsepower;
        _color= color;

    }
    public override void Sound()
    {
        Console.WriteLine("Дрынь дын дынь.");
    }
    public override void Snow()
    {
        Console.WriteLine($"Это машина называется  {_name}, цвет машины {_color}");
    }
    public override void Desc()
    {
        Console.WriteLine($"Колличество {_number_of_horsepower}л.c \n ");
    }
}

class Steamboat:Device
{
    int _length;
    int _width;
    
    public Steamboat(string name,  int length,int width):base(name)
    {
        Name= name;
        _length= length;
        _width= width;
    }
    public override void Sound()
    {
        Console.WriteLine("Туууууу.");
    }
    public override void Snow()
    {
        Console.WriteLine($"Этот параход называется{_name} имеет длину {_length} метров и ширину {_width} метров");
    }
    public override void Desc()
    {
        Console.WriteLine("Парохо́д — судно, оснащённое поршневой паровой машиной или паровой турбиной в качестве тягового двигателя\n");
    }
}
















/*Money mon =new Money(2,30);
mon.ToString();
Console.WriteLine(mon);

Product prod=new Product("Sugar",mon);
Console.WriteLine(prod);


class Money
{
    protected int _ruble;
    protected int _kopek;

    public int Ruble
    {
        get { return _ruble; }
        set { _ruble = value; }
    }
    public int Kopek
    {
        get { return _kopek; }
        set { 
            if (_kopek > 100)
            {
                _kopek = _kopek % 100;
                _ruble += _kopek / 100;
            }
            else
            _kopek = value; }
    }
    public Money()
    { _ruble =0; _kopek =0; }
    public Money(int ruble, int kopek) {
        this._ruble = ruble;
        this._kopek = kopek;
    }
   
    public override string ToString()
    {
        return $" Колличество {_ruble} руб. {_kopek} коп.";
    }
}
class Product : Money
{
    string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public Product(string _name, Money mon)
    {
        this._name = _name;
        this._ruble = mon.Ruble;
        this._kopek = mon.Kopek;
    }
    public Product(string _name, int ruble, int kopek) : base(ruble, kopek)
    {
        this._name = _name;
        this._ruble = ruble;
        this._kopek = Kopek;
    }

    public override string ToString()
    {
        return $"Стоимость продукта {_name} = {_ruble} руб. {_kopek} коп.";
    }
    public void NewPrice(Product product)
    {
        this._ruble += product.Ruble;
    }
} */ 