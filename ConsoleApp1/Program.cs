namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Öt szó vesszővel elválasztva: ");
        string[] szavak= Console.ReadLine().Split(",");
        string[] szavak_forditva=new string[5];
        for (int i = 0; i < 5; i++)
        {
            szavak_forditva[i]=Visszafele(szavak[i]);
            //System.Console.Write($"{Visszafele(szavak[i])} ");
            System.Console.WriteLine(szavak_forditva[i]); 
        }
        

    }

    private static string Visszafele(string szo)
    {
        string megforditott="";
        for (int i = szo.Length-1; i >= 0; i--)
        {
            megforditott+=(szo[i]);
        }
        return megforditott;
    }
}
