grammar test;
input: EOL* mnemonic* EOF;
mnemonic: (inst WS+ (operand WS*)+ | inst WS*) EOL?
        | emptyline;
inst: TEXT ('_' TEXT)? SUFFIX? | TEXT ('*' | OPERATOR)? SUFFIX?;
operand: device | local_device | wordbit | local_wordbit
        | indirect | local_indirect
        | ref | local_ref | direct_val | unknown_dev
        | literal | label
        ;
indirect_suffix: (INT | MNM_DEC | MNM_HEX | device);
emptyline: WS* EOL;
device: TEXT INT;
wordbit: device '.' INT;
indirect: device ':' indirect_suffix;
ref: '*' device;
local_device: ATMARK device;
local_wordbit: local_device '.' INT;
local_indirect:  local_device ':' indirect_suffix;
local_ref: '*' local_device;
direct_val: INT | MNM_DEC | MNM_HEX;
literal: LITERAL;
label: TEXT;
unknown_dev: '?'+;

MNM_DEC: (K | '#') '-'? (INT+ | INT+ '.' + INT+ | '.' + INT+ | INT+ '.');
MNM_HEX: (H | '$') [0-9a-fA-F]+;
OPERATOR: '+' | '-' | '*' | '/' | '>' | '>>' | '<' | '<<' | '|' | '=';
SUFFIX: '.' TEXT;
LITERAL: '"' TEXT*? '"';
WS: ' ';
EOL: '\r' | '\n' | '\r\n';
ATMARK: '@';

INT: [0-9]+;
TEXT: [a-zA-Z]+;
fragment A: [Aa];
fragment B: [Bb];
fragment H: [Hh];
fragment K: [Kk];
