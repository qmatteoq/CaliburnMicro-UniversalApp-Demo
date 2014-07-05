namespace Messages.Messages
{
    public class SimpleMessageInBackground
    {
        public string Text { get; private set; }

        public SimpleMessageInBackground(string text)
        {
            Text = text;
        }
    }
}
