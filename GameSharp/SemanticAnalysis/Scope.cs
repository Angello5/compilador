using System.Collections.Generic;

namespace GameSharp.SemanticAnalysis
{
    public class Scope
    {
        private readonly Dictionary<string, Symbol> symbols = new Dictionary<string, Symbol>();
        private readonly Scope parentScope;

        public Scope(Scope parentScope)
        {
            this.parentScope = parentScope;
        }

        public void Define(Symbol symbol)
        {
            symbols[symbol.Name] = symbol;
        }

        public Symbol Resolve(string name)
        {
            if (symbols.TryGetValue(name, out var symbol))
            {
                return symbol;
            }
            return parentScope?.Resolve(name);
        }
    }
}

