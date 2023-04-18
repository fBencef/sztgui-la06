namespace la06.Backend
{
    public class Message
    {

        public string Content { get; set; }
        public DateTime Sent { get; set; }
        public string Sender { get; set; }

        public Message(string content, DateTime sent, string sender)
        {
            Content = content;
            Sent = sent;
            Sender = sender;
        }

    }
}