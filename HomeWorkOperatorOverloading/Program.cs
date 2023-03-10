

Shop shop = new Shop("АлиЭкспрес", "Internet", "Товары народного спроса", "(4458)581585", "aliespres@gmail.com", 1000);
Console.WriteLine(shop);
shop = shop + 100;
Console.WriteLine(shop);
shop-=100;
Console.WriteLine(shop);
Shop shop1 = new Shop("АлиЭкспрес", "Internet", "Товары народного спроса", "(4458)581585", "aliespres@gmail.com", 1100);
shop1 += 100;
Console.WriteLine(shop1);
Console.WriteLine(shop);
Console.WriteLine(shop==shop1);
class Shop
{
    private string _storeName;
    private string _address;
    private string _storeProfile;
    private string _telepfoneStoreNumber;
    private string _storeMail;
    private int _storeArea;

    public string store_name
    {
        get { return _storeName; }
        set { _storeName = value; }
    }
    public string address
    {
        get { return _address; }
        set { _address = value; }
    }
    public string store_profile
    {
        get { return _storeProfile; }
        set { _storeProfile = value; }
    }
    public string telepfone_store_number
    {
        get { return _telepfoneStoreNumber; }
        set { _telepfoneStoreNumber = value; }
    }
    public string store_mail
    {
        get { return _storeMail; }
        set { _storeMail = value; }
    }
    public int store_area
    {
        get { return _storeArea; }
        set { _storeArea = value; }
    }
    public Shop(string StoreName, string Adress, string StoreProfile, string TelepfoneStoreNumber, string StoreMail,int StoreArea)
    {
        store_name = StoreName;
        address = Adress;
        store_profile = StoreProfile;
        telepfone_store_number = TelepfoneStoreNumber;
        store_mail = StoreMail;
        store_area= StoreArea;
    }
    public override  string ToString()
    {
        return $"Название магазина:{_storeName} Адресс: {_address} Направление работы магазина: {_storeProfile} " +
            $"Контактный телефон: {_telepfoneStoreNumber}  E-mail: {_storeMail} Площадь магазина {_storeArea}кв.м.";
    }

    public static Shop operator +(Shop answer ,int area)
    {
        answer.store_area += area;
        return answer;
    }
    public static Shop operator -(Shop answer, int area)
    {
        answer.store_area -= area;
        return answer;
    }
    public static bool operator == (Shop left,Shop right)
    {
        return left.store_area == right.store_area ;
    }
    public static bool operator != (Shop left,Shop right)
    {
        return left.store_area != right.store_area;
    }
    public static bool operator < (Shop left,Shop right)
    {
        return left.store_area < right.store_area;
    }
    public static bool operator > (Shop left,Shop right)
    {
        return left.store_area > right.store_area;
    }
    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }
}