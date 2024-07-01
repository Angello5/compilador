using System.Collections.Generic;

namespace GameSharp.SemanticAnalysis
{
    public class SymbolTable
    {
        private readonly Dictionary<string, Symbol> _symbols = new Dictionary<string, Symbol>();

        public void Define(Symbol symbol)
        {
            _symbols[symbol.Name] = symbol;
        }

        public Symbol Resolve(string name)
        {
            return _symbols.TryGetValue(name, out var symbol) ? symbol : null;
        }
    }
}
