//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Gamecsharp.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
#pragma warning disable CS3021 // Type or member does not need a CLSCompliant attribute because the assembly does not have a CLSCompliant attribute
public partial class GamecsharpLexer : Lexer {
#pragma warning restore CS3021 // Type or member does not need a CLSCompliant attribute because the assembly does not have a CLSCompliant attribute
    protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		ID=25, NUMBER=26, STRING=27, WS=28;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "ID", "NUMBER", 
		"STRING", "WS"
	};


	public GamecsharpLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public GamecsharpLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'objeto'", "'{'", "'}'", "';'", "'propiedad'", "'='", "'en'", "'click'", 
		"'teclaAbajo'", "'teclaArriba'", "'movimientoRaton'", "'accion'", "'*'", 
		"'/'", "'+'", "'-'", "'('", "')'", "'si'", "'mientras'", "','", "'verdadero'", 
		"'falso'", "'imprimir'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, "ID", "NUMBER", "STRING", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Gamecsharp.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static GamecsharpLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,28,216,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,1,0,1,
		0,1,0,1,0,1,0,1,0,1,0,1,1,1,1,1,2,1,2,1,3,1,3,1,4,1,4,1,4,1,4,1,4,1,4,
		1,4,1,4,1,4,1,4,1,5,1,5,1,6,1,6,1,6,1,7,1,7,1,7,1,7,1,7,1,7,1,8,1,8,1,
		8,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,
		1,9,1,9,1,9,1,10,1,10,1,10,1,10,1,10,1,10,1,10,1,10,1,10,1,10,1,10,1,10,
		1,10,1,10,1,10,1,10,1,11,1,11,1,11,1,11,1,11,1,11,1,11,1,12,1,12,1,13,
		1,13,1,14,1,14,1,15,1,15,1,16,1,16,1,17,1,17,1,18,1,18,1,18,1,19,1,19,
		1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,20,1,20,1,21,1,21,1,21,1,21,1,21,
		1,21,1,21,1,21,1,21,1,21,1,22,1,22,1,22,1,22,1,22,1,22,1,23,1,23,1,23,
		1,23,1,23,1,23,1,23,1,23,1,23,1,24,1,24,5,24,191,8,24,10,24,12,24,194,
		9,24,1,25,4,25,197,8,25,11,25,12,25,198,1,26,1,26,5,26,203,8,26,10,26,
		12,26,206,9,26,1,26,1,26,1,27,4,27,211,8,27,11,27,12,27,212,1,27,1,27,
		0,0,28,1,1,3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,9,19,10,21,11,23,12,25,13,
		27,14,29,15,31,16,33,17,35,18,37,19,39,20,41,21,43,22,45,23,47,24,49,25,
		51,26,53,27,55,28,1,0,5,3,0,65,90,95,95,97,122,4,0,48,57,65,90,95,95,97,
		122,1,0,48,57,2,0,34,34,94,94,3,0,9,10,13,13,32,32,219,0,1,1,0,0,0,0,3,
		1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,
		0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,
		1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,0,31,1,0,0,0,0,33,1,0,0,0,0,35,1,0,0,
		0,0,37,1,0,0,0,0,39,1,0,0,0,0,41,1,0,0,0,0,43,1,0,0,0,0,45,1,0,0,0,0,47,
		1,0,0,0,0,49,1,0,0,0,0,51,1,0,0,0,0,53,1,0,0,0,0,55,1,0,0,0,1,57,1,0,0,
		0,3,64,1,0,0,0,5,66,1,0,0,0,7,68,1,0,0,0,9,70,1,0,0,0,11,80,1,0,0,0,13,
		82,1,0,0,0,15,85,1,0,0,0,17,91,1,0,0,0,19,102,1,0,0,0,21,114,1,0,0,0,23,
		130,1,0,0,0,25,137,1,0,0,0,27,139,1,0,0,0,29,141,1,0,0,0,31,143,1,0,0,
		0,33,145,1,0,0,0,35,147,1,0,0,0,37,149,1,0,0,0,39,152,1,0,0,0,41,161,1,
		0,0,0,43,163,1,0,0,0,45,173,1,0,0,0,47,179,1,0,0,0,49,188,1,0,0,0,51,196,
		1,0,0,0,53,200,1,0,0,0,55,210,1,0,0,0,57,58,5,111,0,0,58,59,5,98,0,0,59,
		60,5,106,0,0,60,61,5,101,0,0,61,62,5,116,0,0,62,63,5,111,0,0,63,2,1,0,
		0,0,64,65,5,123,0,0,65,4,1,0,0,0,66,67,5,125,0,0,67,6,1,0,0,0,68,69,5,
		59,0,0,69,8,1,0,0,0,70,71,5,112,0,0,71,72,5,114,0,0,72,73,5,111,0,0,73,
		74,5,112,0,0,74,75,5,105,0,0,75,76,5,101,0,0,76,77,5,100,0,0,77,78,5,97,
		0,0,78,79,5,100,0,0,79,10,1,0,0,0,80,81,5,61,0,0,81,12,1,0,0,0,82,83,5,
		101,0,0,83,84,5,110,0,0,84,14,1,0,0,0,85,86,5,99,0,0,86,87,5,108,0,0,87,
		88,5,105,0,0,88,89,5,99,0,0,89,90,5,107,0,0,90,16,1,0,0,0,91,92,5,116,
		0,0,92,93,5,101,0,0,93,94,5,99,0,0,94,95,5,108,0,0,95,96,5,97,0,0,96,97,
		5,65,0,0,97,98,5,98,0,0,98,99,5,97,0,0,99,100,5,106,0,0,100,101,5,111,
		0,0,101,18,1,0,0,0,102,103,5,116,0,0,103,104,5,101,0,0,104,105,5,99,0,
		0,105,106,5,108,0,0,106,107,5,97,0,0,107,108,5,65,0,0,108,109,5,114,0,
		0,109,110,5,114,0,0,110,111,5,105,0,0,111,112,5,98,0,0,112,113,5,97,0,
		0,113,20,1,0,0,0,114,115,5,109,0,0,115,116,5,111,0,0,116,117,5,118,0,0,
		117,118,5,105,0,0,118,119,5,109,0,0,119,120,5,105,0,0,120,121,5,101,0,
		0,121,122,5,110,0,0,122,123,5,116,0,0,123,124,5,111,0,0,124,125,5,82,0,
		0,125,126,5,97,0,0,126,127,5,116,0,0,127,128,5,111,0,0,128,129,5,110,0,
		0,129,22,1,0,0,0,130,131,5,97,0,0,131,132,5,99,0,0,132,133,5,99,0,0,133,
		134,5,105,0,0,134,135,5,111,0,0,135,136,5,110,0,0,136,24,1,0,0,0,137,138,
		5,42,0,0,138,26,1,0,0,0,139,140,5,47,0,0,140,28,1,0,0,0,141,142,5,43,0,
		0,142,30,1,0,0,0,143,144,5,45,0,0,144,32,1,0,0,0,145,146,5,40,0,0,146,
		34,1,0,0,0,147,148,5,41,0,0,148,36,1,0,0,0,149,150,5,115,0,0,150,151,5,
		105,0,0,151,38,1,0,0,0,152,153,5,109,0,0,153,154,5,105,0,0,154,155,5,101,
		0,0,155,156,5,110,0,0,156,157,5,116,0,0,157,158,5,114,0,0,158,159,5,97,
		0,0,159,160,5,115,0,0,160,40,1,0,0,0,161,162,5,44,0,0,162,42,1,0,0,0,163,
		164,5,118,0,0,164,165,5,101,0,0,165,166,5,114,0,0,166,167,5,100,0,0,167,
		168,5,97,0,0,168,169,5,100,0,0,169,170,5,101,0,0,170,171,5,114,0,0,171,
		172,5,111,0,0,172,44,1,0,0,0,173,174,5,102,0,0,174,175,5,97,0,0,175,176,
		5,108,0,0,176,177,5,115,0,0,177,178,5,111,0,0,178,46,1,0,0,0,179,180,5,
		105,0,0,180,181,5,109,0,0,181,182,5,112,0,0,182,183,5,114,0,0,183,184,
		5,105,0,0,184,185,5,109,0,0,185,186,5,105,0,0,186,187,5,114,0,0,187,48,
		1,0,0,0,188,192,7,0,0,0,189,191,7,1,0,0,190,189,1,0,0,0,191,194,1,0,0,
		0,192,190,1,0,0,0,192,193,1,0,0,0,193,50,1,0,0,0,194,192,1,0,0,0,195,197,
		7,2,0,0,196,195,1,0,0,0,197,198,1,0,0,0,198,196,1,0,0,0,198,199,1,0,0,
		0,199,52,1,0,0,0,200,204,5,34,0,0,201,203,7,3,0,0,202,201,1,0,0,0,203,
		206,1,0,0,0,204,202,1,0,0,0,204,205,1,0,0,0,205,207,1,0,0,0,206,204,1,
		0,0,0,207,208,5,34,0,0,208,54,1,0,0,0,209,211,7,4,0,0,210,209,1,0,0,0,
		211,212,1,0,0,0,212,210,1,0,0,0,212,213,1,0,0,0,213,214,1,0,0,0,214,215,
		6,27,0,0,215,56,1,0,0,0,5,0,192,198,204,212,1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}