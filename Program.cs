using System;

namespace CRUDApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            HeaderComponent header = new HeaderComponent();
            MenuComponent menu = new MenuComponent();
            CRUDComponent crud = new CRUDComponent();
            FooterComponent footer = new FooterComponent();

            header.Display();
            menu.Display();
            crud.Create();
            crud.Read();
            crud.Update();
            crud.Delete();
            footer.Display();
            Console.ReadLine();
        }
    }
}