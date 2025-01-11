using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFrameworkDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var msbList = new IMsbList();

            //var arrayList = new ArrayList();

            var msbList = new MsbList();
            msbList.Ekle("Salih");
            msbList.Ekle("Mustafa");
            msbList.Ekle("Engin");
            msbList.Ekle("Zeynep");

            //msbList.ElemanSayisi = 5;

            Console.WriteLine("Eleman Sayısı:{0}", msbList.ElemanSayisi);

            var ilkKayit = msbList[0];

            msbList[2] = "Gözde";

            msbList.Sil(1);

            for (int i = 0; i < msbList.ElemanSayisi; i++)
            {
                Console.WriteLine(msbList[i]);
            }




            Console.ReadLine();
        }
    }
}
