using System.IO;

namespace GraphCycleFinder.interaction
{
    public static class Writer
    {
        public static void Write(string message)
        {
            var writer = new StreamWriter("out.txt",true);
            writer.WriteLine(message);
            writer.Close();
        }
    }
}