using System;
namespace Thuchanhngoaite;
class Program{
    static void Main(string [] args){
        //console.Writeline("Currency Exchange");
        int vnd;
        int usd;
        Console.WriteLine("Enter amount of usd");
        usd = Int32.Parse(Console.ReadLine());
        Console.WriteLine(vnd = usd * 23000);
    }
}