using Ex.Fourth.Abstractions.Test1Handler;
using System;
using System.Collections.Generic;

namespace Ex.Fourth.Abstractions
{
    enum DocumentFormat
    {
        _txt, _doc, _xml
    }
    class Handler
    {
        private List<AbstractHandler> costumeHandler = new List<AbstractHandler>();
        public Handler()
        {
            costumeHandler.Add(new TXTHandler());
            costumeHandler.Add(new DOCHandler());
            costumeHandler.Add(new XMLHandler());
        }

        public void RunHandler(string name, DocumentFormat dock)
        {
            Console.WriteLine("\n*---Handler---*");
            Console.WriteLine("Chosen file {0}{1}", name, dock);
            costumeHandler[Convert.ToInt16(dock)].Create();
            costumeHandler[Convert.ToInt16(dock)].Open();
            costumeHandler[Convert.ToInt16(dock)].Chenge();
            costumeHandler[Convert.ToInt16(dock)].Save();
        }


    }
}

