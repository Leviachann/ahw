using System;

class Program
{
    public static void Func(string text)
    {
        Console.WriteLine(text);
    }

    public class MyClass
    {
        public void Space(string text)
        {
            string withSpaces = "";
            for (int i = 0; i < text.ToString().Length; i++)
            {
                string test = text.ToString().ElementAt(i) + "_";
                withSpaces += test;
            }
            string WithSpacesFinal = withSpaces.Trim();
            Console.WriteLine(WithSpacesFinal);
        }
        public static string Reverse(string str){
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    }
   public class Run:MyClass{
     public void runFunc(string argument){
       Space(argument);
       Reverse(argument);
     }
   }
    public static void Main()
    {
        Console.WriteLine("Enter string");
        var str = Console.ReadLine();
        MyClass cls = new MyClass(str);
        Func funcDell = new Func(params) // params sadece sizin ora vereceyiniz parametrlerdi	
    //burda funcDell-e functionlari verirsiniz	
        Run run = new Run();
        run.runFunc(funcDell, str); //cagiranda Space() ve Reverse() functionlari ise dusmelidir
    }
}