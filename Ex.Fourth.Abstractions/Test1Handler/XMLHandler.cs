using System;

namespace Ex.Fourth.Abstractions.Test1Handler
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("XML document is opened.");
        }
        public override void Create()
        {
            Console.WriteLine("XML document is created.");
        }
        public override void Chenge()
        {
            Console.WriteLine("XML document is changed.");
        }
        public override void Save()
        {
            Console.WriteLine("XML document is saved.");
        }
    }
}
