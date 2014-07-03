namespace Messages.Messages
{
    public class SimpleMessage
    {
        public string Text { get; private set; }

        public SimpleMessage(string text)
        {
            Text = text;
        }
    }
}
