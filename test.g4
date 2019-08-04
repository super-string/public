grammar test;
input: EOL*? (mnemonic (EOL+ mnemonic)*)? EOL? EOF;
mnemonic: inst (WS+ operand (WS+ operand)*)+ | inst WS* | comment;
inst: IDENT (OPERATOR | ASTERISK)? SUFFIX?;
operand: indirect
        | index_ref
        | device
        | local_or_tm
        | direct_value
        | QUESTION+
        | LITERAL;
device: UINT | IDENT REAL_DOT_DIGIT?;
direct_value: REAL_FULL | REAL_DIGIT_DOT | REAL_DOT_DIGIT | DEC | SINT | UINT | HEX | FLOAT | EXP;
local_or_tm: (AT | SHARP) device;
indirect: ASTERISK (IDENT | index_ref | local_or_tm);
index_ref: ((UINT | IDENT) | local_or_tm) COLON (DEC | SINT | UINT | IDENT);
comment: COMMENT;

UINT: DIGIT;
SINT: (PLUS | MINUS) (DIGIT | REAL);
DEC: (K | SHARP) (SINT | UINT | EXP);
IDENT: (DIGIT | TEXT)+;
REAL_DOT_DIGIT: DOT DIGIT;
REAL_FULL: DIGIT DOT DIGIT;
REAL_DIGIT_DOT: DIGIT DOT;

HEX: (H | '$') [0-9a-fA-F]+;
FLOAT: (K | SHARP) (EXP | REAL);
EXP: (DIGIT | REAL | SINT) E (DIGIT | SINT);

SUFFIX: DOT TEXT;
LITERAL: DQ (DQ DQ | N_DQ)* DQ;
COMMENT: SEMICOLON NOT_EOL+;
AT: '@';
QUESTION: '?';
COLON: ':';
OPERATOR: '~' | '=' | '<<' | '>>' | '<>' | '<' | '>' | '|' | '<=' | '>=' | PLUS | MINUS | '/' | '^' | '&';
ASTERISK: '*';
SHARP: '#';

EOL: '\r' | '\n' | '\r\n';
WS: ' ';

fragment REAL: REAL_FULL | REAL_DOT_DIGIT | REAL_DIGIT_DOT;
fragment TEXT: [_a-zA-Z]+;
fragment E: [Ee];
fragment H: [Hh];
fragment K: [Kk];
fragment DIGIT: [0-9]+;
fragment PLUS: '+';
fragment MINUS: '-';
fragment DOT: '.';
fragment DQ: '"';
fragment N_DQ: ~["];
fragment SEMICOLON: ';';
fragment NOT_EOL: ~[\r\n];