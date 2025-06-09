using System;

namespace MediatorPattern
{
    public class ConcreteMediator : IMediator
    {
        private Window1 window1 = new Window1();
        private Window2 window2 = new Window2();

        public ConcreteMediator()
        {
            window1.SetMediator(this);
            window2.SetMediator(this);
        }

        public void CopyTextFromWindow1()
        {
            string textToCopy = window1.GetText();
            window2.SetText(textToCopy);
            Console.WriteLine($"Texto copiado da Janela 1 para Janela 2: {textToCopy}");
        }

        public void CopyTextFromWindow2()
        {
            string textToCopy = window2.GetText();
            window1.SetText(textToCopy);
            Console.WriteLine($"Texto copiado da Janela 2 para Janela 1: {textToCopy}");
        }

        public Window1 GetWindow1() => window1;
        public Window2 GetWindow2() => window2;
    }
}
