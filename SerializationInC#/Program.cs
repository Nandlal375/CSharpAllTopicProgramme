using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //======= Serilization Start =================//

            //string path = @"D:\SerializationConcept\Sample.exe";
            //Employee emp = new Employee(241, "Adil");
            //FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(fileStream, emp);
            //fileStream.Close();
            //Console.WriteLine("File Create Succeffuly........ ===> " + path);
            //Console.ReadLine();


            //======= Serilization End =================//


            //<======== Desirilization Start ===================>

            string path = @"D:\SerializationConcept\Sample.txt";
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            Employee emp = (Employee)bf.Deserialize(fileStream);
            Console.WriteLine("Id ==> " + emp.Id);
            Console.WriteLine("Name ==> " + emp.Name);
            fileStream.Close();
            Console.ReadLine();
            //<======== Desirilization End ===================>

        }
    }
}
