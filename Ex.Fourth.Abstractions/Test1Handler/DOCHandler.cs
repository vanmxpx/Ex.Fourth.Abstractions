using System;

namespace Ex.Fourth.Abstractions.Test1Handler
{
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Word document is opened.");
        }
        public override void Create()
        {
            Console.WriteLine("Word document is created.");
        }
        public override void Chenge()
        {
            Console.WriteLine("Word document is changed.");
        }
        public override void Save()
        {
            Console.WriteLine("Word document is saved.");
        }
    }
}

