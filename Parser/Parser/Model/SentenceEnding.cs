namespace Parser.Model
{
    public class SentenceEnding: ISentenceComponent
    {
        public SentenceEnding(string component)
        {
            Component = component;
        }

        public string Component { get; private set; }
    }
}
