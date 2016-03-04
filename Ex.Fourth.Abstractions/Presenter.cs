using System;

namespace Ex.Fourth.Abstractions
{
    partial class Presenter
    {
        public void RunFirstExersize()
        {
            Handler handler = new Handler();

            handler.RunHandler("Diplom", DocumentFormat._doc);
            handler.RunHandler("MySite", DocumentFormat._xml);
            handler.RunHandler("Hans Solo", DocumentFormat._txt);

            Console.WriteLine("Enter key to open next exersize");
            Console.ReadLine();
        }

        public void RunSecondExersize()
        {
            Player KMPlayer = new Player();

            KMPlayer.Play("BMTH - Doomed");

            Console.WriteLine("Enter key to open next exersize");
            Console.ReadLine();
        }
    }
}
