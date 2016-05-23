using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Sayı gir: ");
		int sayi=Convert.ToInt32(Console.ReadLine());
		
		Console.Write("\n"+1+"\n"+2+"\n");
		for(int i=3;i<sayi;i=i*2){
			Console.WriteLine(i);
		}
	}
}
//http://eodev.com/gorev/8704822
