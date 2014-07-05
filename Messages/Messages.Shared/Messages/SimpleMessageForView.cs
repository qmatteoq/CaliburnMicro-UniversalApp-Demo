namespace Messages.Messages
{
    public class SimpleMessageForView
    {
        public string Text { get; private set; }

        public SimpleMessageForView(string text)
        {
            Text = text;
        }
    }
}
