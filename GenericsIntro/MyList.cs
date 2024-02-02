using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    public class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //Geçici olarak referans numarasını buraya tutturdu
            items = new T[items.Length + 1]; //dizinin eleman sayısını artırma
            for (int i = 0; i < tempArray.Length; i++) //tempArrayin lengthi kadar items.lengthe geri al
            {
                items[i] = tempArray[i]; //items eski değerlerine kavuştu
            }

            items[items.Length - 1] = item; //Aslında eklenmek istenen elemanı şu an ekleyebildik
        }
    }
}
