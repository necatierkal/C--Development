namespace NullableTypeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int sayi = null;
            //DateTime tarih = null;
            //char ch = null;

            //Nullable<int> rakam = null;
            int? sayi = null;
            DateTime? date = null;

            if (sayi.HasValue)
            {
                int sayiDegeri = sayi.Value;
                //işleme devam
            }

            string ifade = null;
            string? metin = null;

            if (metin != null)
            {

            }

            string tcNo = "1234435345";
            long deger = long.Parse(tcNo); //Convert.ToInt64(tcNo);
        }
    }
}
