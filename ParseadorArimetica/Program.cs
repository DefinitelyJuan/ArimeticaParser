using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;

namespace ParseadorArimetica
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = "5+6+9+3-1";
            ICharStream stream = CharStreams.fromString(input);
            arimeticaLexer lexer = new arimeticaLexer(stream);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            arimeticaParser parser = new arimeticaParser(tokens);
            arimeticaParser.ArimeticaContext tree = parser.arimetica();
            arimetica.Arimetica arimetica = new arimetica.Arimetica();
            int res = arimetica.Visit(tree);
            Console.ReadLine();
        }
    }
}
