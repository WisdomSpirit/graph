using System.Linq;
using GraphCycleFinder.interaction;

namespace GraphCycleFinder
{
    internal static class Program
    {
        public static void Main()
        {
            Cleaner.Clean();
            var graph = Parser.Parse(Reader.Read());
            var result = CycleFinder.Cycle(graph);
            if (result == null)
            {
                Writer.Write("A");
                return;
            }

            var sequence = result;
            Writer.Write("N");
            var str = sequence.Aggregate("", (current, integer) => current + (integer + " "));
            
            str?.Remove(str.Length-1);
            Writer.Write(str);
        }
    }
}