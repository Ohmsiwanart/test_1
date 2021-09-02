using System;
using System.Collections.Generic;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            t_shirt s1 = new t_shirt("L", "red", 500f, "heart");
            t_shirt s2 = new t_shirt("M", "black", 750f, "hair");
            t_shirt s3 = new t_shirt("S", "green", 625f, "tree");
            user all = new user("jame watson","jame@gmail.com");
            address a = new address("Phutthamonthon", "Nakhon Pathom", "10180");
            all.addlist1(s1);
            all.addlist1(s2);
            all.addlist1(s3);
            all.addlist2(a);
            all.shopping_cart();

            Console.WriteLine("TOTAL COST:{0} BATH",s1.price+s2.price+s3.price);
        }
    }
}

class t_shirt
{
    public string size, color, image;
    public float price;

    public t_shirt(string valuesize, string valuecolor, float valueprice, string valueimage)
    {
        size = valuesize;
        color = valuecolor;
        price = valueprice;
        image = valueimage;
    }
}
class user
{
    public string name, email;
    private List<t_shirt> shirts;
    private List<address> addresses;

    public user(string valuename, string valueemail)
    {
        name = valuename;
        email = valueemail;
        shirts = new List<t_shirt>();
        addresses = new List<address>();
    }

    public void addlist1(t_shirt t_)
    {
        shirts.Add(t_);
    }

    public void addlist2(address ad)
    {
        addresses.Add(ad);
    }

    public void shopping_cart()
    {
        shirts.ForEach(value => { Console.WriteLine("SIZE:{0}   COLOR:{1}  PRICE:{2} BATH  IMAGE:{3}"
            , value.size, value.color, value.price, value.image); });
        Console.WriteLine("NAME:{0}", name);
        Console.WriteLine("E-MAIL:{0}", email);
        addresses.ForEach(value => { Console.WriteLine("STREET:{0} CITY:{1} ZIPCODE:{2}"
            ,value.street, value.city, value.zipcode); });  
    }
}

class address
{
    public string street, city, zipcode;

    public address(string valuestreet, string valuecity, string valuezipcode)
    {
        street = valuestreet;
        city = valuecity;
        zipcode = valuezipcode;
    }
}

