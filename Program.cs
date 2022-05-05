using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuyruk_Queue_
{
    class Program
    {
        class Queue
        {
            int[] Data;
            int Head;
            int Tail;

            public Queue(int capacity)
            {
                Data = new int[capacity];
                Head = 0;
                Tail = 0;
            }
            #region Helper Methods
            public bool isEmpty()
            {
                return (Head == Tail);
            }

            public bool isFull()
            {
                return (Tail == Data.Length);
            }

            public int Capacity()
            {
                return Data.Length; 
            }
            #endregion

            public void Enqueue(int i)
            {
                if(Tail == Data.Length)
                    Console.WriteLine("Kuyruk Dolu");
                Data[Tail] = i;
                Tail++;
            }

            public int Dequeue()
            {
                if(Tail == Head)
                {
                    Console.WriteLine("Liste Boş.");
                    return 0;
                }
                // Data[Tail] olmamasına dikkat ediniz, biz burada First in Firt out (Fifo) felsefesi ile çalışıyoruz.
                int i = Data[Head];
                Head++;
                return i;
            }
        }

        static void Main(string[] args)
        {
            Queue Q = new Queue(10);

            Q.Enqueue(5);
            Q.Enqueue(45);
            Q.Enqueue(10155);

            int FirstValue = Q.Dequeue();
            Console.WriteLine("Ekrana yazdırılan sıra numarası: " + FirstValue);

            int SecondValue = Q.Dequeue();
            Console.WriteLine("Ekrana yazdırılan sıra numarası: " + SecondValue);

            Console.WriteLine(Q.Capacity());

            Console.ReadLine();
        }
    }
}
