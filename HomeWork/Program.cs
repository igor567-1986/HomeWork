using System;
using System.Xml.Linq;
using static System.Console;

Write("Введите число: ");
int number = int.Parse(ReadLine());
WriteLine("Число является палиндромом:"+IsPalindrome(number));

int[] arr = { 1, 2, 3, 4, 2, 4, 5, 3 };
Write("Оригинальный массив: ");
PrintArray(arr);WriteLine();
int[] arr2 = { 2, 3 };
Write("Значения которые надо удалить из массива:");
PrintArray(arr2); WriteLine();
arr =ArrayFiltering(arr, arr2);
Write("Массив после удаления:");
PrintArray(arr); WriteLine();

Shop shop=new Shop("АлиЭкспрес","Internet","Товары народного спроса","(4458)581585","aliespres@gmail.com");
shop.Print();

static bool IsPalindrome(int number)
{
    if (number >= 0 && number < 10)
        return true;
    int numLength = GetLength(number);
    int[] digits = new int[numLength];
    for (int i = numLength - 1; i >= 0; i--)
    {
        digits[i] = number % 10;
        number /= 10;
    }
    for (int i = 0; i < numLength / 2; i++)
    {
        if (digits[i] != digits[numLength - i - 1])
            return false;
    }
    return true;
}
static int GetLength(int num)
{
    int n = 0;
    while (num > 0)
    {
        num /= 10;
        n++;
    }
    return n;
}


static int[] ArrayFiltering(int[] arr,int[] brr)
{
    for(int i = 0; i < brr.Length; i++)
        arr = arr.Where(val => val != brr[i]).ToArray();
    return arr;
}
static int[] PrintArray(int[] arr)
{
    for(int i=0; i<arr.Length; i++)  Write(arr[i]);
    return arr;
}


class Shop
{
    private string StoreName;
    private string Address;
    private string StoreProfile;
    private string TelepfoneStoreNumber;
    private string StoreMail;

    public string store_name {
        get {  return StoreName;   }
        set {  StoreName = value;  }
    }
    public string address  {
        get { return Address; }
        set { Address = value; }
    }
    public string store_profile {
        get { return StoreProfile; }
        set { StoreProfile = value;}
    }
    public string telepfone_store_number{
        get { return TelepfoneStoreNumber; }
        set { TelepfoneStoreNumber = value; }
    }
    public string store_mail { 
        get { return StoreMail; }
        set { StoreMail = value; }
    }
    public  Shop(string StoreName,string Adress,string StoreProfile,string TelepfoneStoreNumber,string StoreMail)
    {
        store_name = StoreName;
        address = Adress;
        store_profile = StoreProfile;
        telepfone_store_number = TelepfoneStoreNumber;
        store_mail= StoreMail;
    }
    public void Print()
    {
        WriteLine($"Название магазина:{StoreName} Адресс: {Address} Направление работы магазина: {StoreProfile} " +
            $"Контактный телефон: {TelepfoneStoreNumber}  E-mail: {StoreMail}");
    }
};