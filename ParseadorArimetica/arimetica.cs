using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseadorArimetica
{
    class arimetica
    {
        internal class Arimetica : arimeticaBaseVisitor<int>
        {
            public override int Visit(IParseTree tree)
            {
                return base.Visit(tree);
            }

            public override int VisitArimetica([NotNull] arimeticaParser.ArimeticaContext context)
            {
                Console.WriteLine(context.GetText());
                return base.VisitArimetica(context);
            }

            public override int VisitExpresion([NotNull] arimeticaParser.ExpresionContext context)
            {
                Console.WriteLine(context.GetText());
                return base.VisitExpresion(context);
            }

            public override int VisitFactor([NotNull] arimeticaParser.FactorContext context)
            {
                Console.WriteLine(context.GetText());
                return base.VisitFactor(context);
            }


            public override int VisitTermino([NotNull] arimeticaParser.TerminoContext context)
            {
                Console.WriteLine(context.GetText());
                return base.VisitTermino(context);
            }
        }
    }
}
