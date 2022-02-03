using System;
using System.Collections.Generic;
using System.Linq;
namespace conversione_basi
{
    public class cb
    {
        public  double num;
        public int b;

    public void set (double num, int b){

        this.num = num;
        this.b = b;

    }

    public void conv (int base1) {
        double n =0;
        n = todec(num,b);
        
        //Console.WriteLine(n);
        num = tobase(n,base1);
       
        b = base1;
    }

    public void print (){
        Console.WriteLine($"Numero = {num} in base {b}");
    }

    public static double todec(double num ,int ba){
        
        int vir = split(num,1);
        int[] a = GetIntArray(split(num,0));
        double ris=0;
        double v = 0;
        for(int i = 0; i<a.Length;i++){

        ris = ris+a[i]*Math.Pow(ba,a.Length-i-1);

       // Console.WriteLine($"{a[i]} * {ba}^{a.Length-i-1} = "+ a[i]*(Math.Pow(ba,(a.Length-i-1))));
        }

        if(vir != 0){

        int[] b = GetIntArray(vir);
        
        for(int i = 0; i<b.Length;i++){
        v = v+b[i]*Math.Pow(ba,-i-1);
        
        //Console.WriteLine($"{b[i]} * {ba}^{-i-1} = "+ b[i]*(Math.Pow(ba,(-i-1))));
        }
        //Console.WriteLine(v);
        }

        //Console.WriteLine(ris+v);
        
        return Math.Round(ris+v,2);
    }

    public static double tobase (double n, int b){

        int qt = split(n,0); //quoto
        double dec = 0;
        
        List<int> ris = new List<int>();
        List<int> risdec = new List<int>();
        while (qt>0){
            ris.Add(qt % b);
            //Console.WriteLine($"{qt} / {b} con resto {qt % b}");
            qt = qt / b;
        
        }
        
        double qtd = split(n); //quoto
        int prec = 5;
        
        
        if(split(n,1) != 0){
            while (prec>0){
                //Console.WriteLine($"{Math.Round(qtd,3)} * {b} = {Math.Round(qtd*b,3)} ");
                qtd = qtd*b;
                
                
                risdec.Add(Convert.ToInt32(Math.Floor(qtd)));
                if (qtd*b>=b){qtd = qtd % 1;}
             
            
            prec--;
            
            
            }
        
       //foreach (int d in risdec){Console.WriteLine(d);}
        
        int[] arisdec = risdec.ToArray();
        dec = arisdec.Select((t, i) => t * Math.Pow(10, arisdec.Length - i - 1)).Sum();
        while (dec>1)dec = dec/10;
        
         for(int i = 0; i<arisdec.Length;i++){

            if(arisdec[i]==0){dec = dec/10;} else break;
            
         }
        
        
        }

        ris.Reverse();
        
        int[] aris = ris.ToArray();
        
        double risint =  aris.Select((t, i) => t * Convert.ToInt32(Math.Pow(10, aris.Length - i - 1))).Sum();

        return risint+dec;
        
    }

    private static int split (double n, int q){
        int[] ris = {0,0};
        
        
        string s = Convert.ToString(n);
        string[] s1 = s.Split(',',2);
        ris[0] = Convert.ToInt32(s1[0]);
        
        if(s1.Length>1){
            //Console.WriteLine(s1[1]);
            ris[1] = Convert.ToInt32(s1[1]);
            
            }

        return ris[q];

        
    }

    private static double split (double n){
       

        return n%1;}


    private static int[] GetIntArray(int num)
{
    List<int> listOfInts = new List<int>();
    while(num > 0)
    {
        listOfInts.Add(num % 10);
        num = num / 10;
    }
    listOfInts.Reverse();
    return listOfInts.ToArray();
}
}}



