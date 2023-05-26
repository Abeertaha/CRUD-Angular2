using System;

namespace CRUDApplication
{
    class CRUDComponent
    {
        public void Create()
        {
            Console.WriteLine("CREATE");
            Console.WriteLine("Enter the data to start:");
            string? data = Console.ReadLine();
            Console.WriteLine("New data created: " + data);
        }

        public void Read()
        {
            Console.WriteLine("READ");
            Console.WriteLine("Reading data.....");
        }

        public void Update()
        {
            Console.WriteLine("UPDATE");
            Console.WriteLine("Enter the id to update:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the updated data:");
            string? data = Console.ReadLine();
            Console.WriteLine("Data updated: ID-" + id + ", Data-" + data);
        }

        public void Delete()
        {
            Console.WriteLine("DELETE");
            Console.WriteLine("Enter the data ID to delete:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Deleting data with ID: " + id);
            Console.WriteLine("Data deleted successfully.");
        }
    }
}