namespace MediatorPattern
{
    public abstract class Window
    {
        protected IMediator? mediator;
        protected string text = "";

        public void SetMediator(IMediator m)
        {
            mediator = m;
        }

        public virtual void SetText(string newText)
        {
            text = newText;
        }

        public virtual string GetText()
        {
            return text;
        }
    }
}
