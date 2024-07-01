using System;

namespace GameSharp.SemanticAnalysis
{
    public class SemanticException : Exception
    {
        public SemanticException(string message) : base(message)
        {
        }
    }
}
