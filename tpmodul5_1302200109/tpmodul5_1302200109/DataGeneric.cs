using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302200109
{
    internal class DataGeneric<T>
    {
        public T Data { get; set; }

        public DataGeneric(T data)
        {
            Data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {Data}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat objek DataGeneric dengan tipe int dan mengisi data dengan nilai 1302200109
            DataGeneric<int> dataObj = new DataGeneric<int>(1302200109);

            // Memanggil method PrintData untuk mencetak data yang tersimpan
            dataObj.PrintData();
        }
    }
}
