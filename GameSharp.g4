grammar GameSharp;

options {
	language = CSharp;
}

prog: statement*;

statement: objectDecl | actionDecl | command;

// Declaración de objetos personajes
objectDecl: 'objeto' ID '{' objectBody '}';
objectBody: (propertyDecl ';')*;
propertyDecl: 'propiedad' ID '=' value;

// Acciones definidas por el usuario
actionDecl: 'accion' ID '{' command* '}';

// Comandos dentro de acciones de eventos
command:
	assignment
	| ifStatement
	| whileStatement
	| printStatement
	| readStatement
	| functionCall;

// Asignación y expresiones
assignment: ID ('.' ID)? '=' expr ';';
expr: value (op value)*;
comp_expr: expr (comp_op expr)?;
value: STRING | NUMBER | BOOL | objectProperty | ID;
objectProperty: ID '.' ID;

// Operaciones
op: '+' | '-' | '*' | '/';
comp_op: '>' | '<' | '>=' | '<=' | '==' | '!=';

// Estructuras de control de flujo
ifStatement:
	'si' '(' comp_expr ')' '{' command* '}' elseStatement?;
elseStatement: 'sino' '{' command* '}';
whileStatement: 'mientras' '(' comp_expr ')' '{' command* '}';

// Imprimir en consola 
printStatement: 'imprimir' '(' expr ')' ';';

// Leer de la consola y asignar a una variable
readStatement: 'leer' '(' ID ')' ';';

// Llamada a funciones definidas por el usuario
functionCall: ID ('(' ')')? ';';

// Tokens
ID: [a-zA-Z_][a-zA-Z0-9_]*; // Identificadores
NUMBER: [0-9]+; // Números enteros
STRING:
	'"' (~["\\] | '\\' .)* '"'; // Cadenas de texto, escapando comillas dobles y backslashes
BOOL: 'verdadero' | 'falso'; // Booleanos
WS: [ \t\r\n]+ -> skip; // Espacios en blanco y saltos de línea