using System;

namespace Ex.Fourth.Abstractions.Test1Handler
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Text document is opened.");
        }
        public override void Create()
        {
            Console.WriteLine("Text document is created.");
        }
        public override void Chenge()
        {
            Console.WriteLine("Text document is changed.");
        }
        public override void Save()
        {
            Console.WriteLine("Text document is saved.");
        }
    }
}
