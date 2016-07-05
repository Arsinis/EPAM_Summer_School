namespace Parser.Model
{
    public class SentencePunctuation : ISentenceComponent
    {
        public SentencePunctuation(string component)
        {
            Component = component;
        }

        public string Component { get; private set; }
    }
}
