grammar GameSharp;

prog:   statement* ;

statement:
      objectDecl
    | eventHandler
    | actionDecl
    | command
    ;

// Declaración de objetos personajes
objectDecl: 'objeto' ID '{' objectBody '}' ;
objectBody: (propertyDecl ';')* ;
propertyDecl: 'propiedad' ID '=' value ;

// Manejo de eventos como clics o teclado
eventHandler: 'en' eventType '{' command* '}' ;
eventType: 'click' | 'teclaAbajo' | 'teclaArriba' | 'movimientoRaton' ;

// Acciones definidas por el usuario
actionDecl: 'accion' ID '{' command* '}' ;

// Comandos dentro de acciones  de eventos
command: 
      assignment
    | ifStatement
    | whileStatement
    | functionCall
    | printStatement
    ;

// Asignación y expresiones
assignment: ID '=' expr ';' ;
expr: 
      expr ('*' | '/') expr   # Multiplicacionydivision
    | expr ('+' | '-') expr   # AddSub
    | '(' expr ')'            # Parentesis
    | NUMBER                  # Numero
    | ID                      # Identicador
    ;

// Estructuras de control de flujo
ifStatement: 'si' '(' expr ')' '{' command* '}' ;
whileStatement: 'mientras' '(' expr ')' '{' command* '}' ;

// Llamadas a funciones predefinidas
functionCall: ID '(' exprList ')' ';' ;
exprList: expr (',' expr)* ;

// Valores
value: STRING | NUMBER | 'verdadero' | 'falso' | ID ;

// Imprimir en consola 
printStatement: 'imprimir' '(' expr ')' ';' ;

// Tokens
ID     : [a-zA-Z_][a-zA-Z0-9_]* ; // Identificadores
NUMBER : [0-9]+ ;                 // Números enteros
STRING : '"' [^"]* '"' ;          // Cadenas de texto
WS     : [ \t\r\n]+ -> skip ;     // Espacios en blanco y saltos de línea