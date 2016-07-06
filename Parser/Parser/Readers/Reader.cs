using System.IO;

namespace Parser.Readers
{
    public class Reader
    {
        public string Reading(string filename)
        {
            return File.ReadAllText(filename);
        }
    }
}
