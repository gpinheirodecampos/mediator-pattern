using System;

namespace MediatorPattern
{
    public class Window1 : Window
    {
        public void ButtonClick()
        {
            mediator?.CopyTextFromWindow1();
        }

        public void TypeText(string newText)
        {
            SetText(newText);
            Console.WriteLine($"Janela 1 - Texto digitado: {newText}");
        }
    }
}
