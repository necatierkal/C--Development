using System;

namespace InterfaceFrameworkDemo
{ 
    public interface IMsbList
    {
        void Ekle(object eleman);
        void Sil(int indexNo);
        int ElemanSayisi { get; }
        object this[int index]
        {
            get;
            set;    
        }
    }
}
