using System.Reflection.Metadata.Ecma335;

namespace Sınıf_Nedir__Instance__Field__Property;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("A&D Shopping Personel List");

        Shopping personellist = new Shopping();
        personellist.name= "Taha";
        personellist.surname= "BÖREKCİ";
        personellist.personelno=351;
        personellist.department="sales consultant";
        personellist.shoppersonel();
        Console.WriteLine("*****************************************************");

        Shopping personellist2 = new Shopping();
        personellist2.name= "Barış";
        personellist2.surname= "AKAN";
        personellist.personelno=355;
        personellist2.department="administrator";
        personellist2.shoppersonel();
        


    }
}

class Shopping
{

public string name;
public string surname;
public int personelno;
public string department;

public void shoppersonel()//Mağaza personel bilgilerini yazdıran metot
{
   Console.WriteLine("Personel name:{0}",name);
   Console.WriteLine("Personel surname:{0}",surname);
   Console.WriteLine("Personel PersonelNo:{0}",personelno);
   Console.WriteLine("Personel department:{0}",department);

}




}