using System;

namespace MediatorPattern
{
    public class Window2 : Window
    {
        public void ButtonClick()
        {
            mediator?.CopyTextFromWindow2();
        }

        public void TypeText(string newText)
        {
            SetText(newText);
            Console.WriteLine($"Janela 2 - Texto digitado: {newText}");
        }
    }
}
