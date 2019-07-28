grammar test;
input: EOL* mnemonic* EOF;
mnemonic: (inst WS+ (operand WS*)+ | inst WS*) EOL?
        | emptyline;
inst_suffix: SUFFIX;
inst: TEXT (UNDERBAR TEXT)? inst_suffix? | TEXT operator? inst_suffix?;
operand: device | local_device | wordbit | local_wordbit
        | indirect | local_indirect
        | ref | local_ref | direct_val | unknown_dev
        | literal | label | local_label
        ;
indirect_suffix: (INT | MNM_DEC | MNM_HEX | device);
operator: OPERATOR | ASTARISK;//「*」をOPERATORに含めるとおかしくなる
emptyline: WS* EOL;
device: TEXT INT;
local_device: ATMARK device;
wordbit: device DOT INT;
local_wordbit: local_device DOT INT;
indirect: device COLON indirect_suffix;
local_indirect:  local_device COLON indirect_suffix;
ref: ASTARISK device;
local_ref: ASTARISK local_device;
label: UNDERBAR? TEXT;
local_label: ATMARK label;
direct_val: INT | MNM_DEC | MNM_HEX;
literal: LITERAL;
unknown_dev: '?'+;

MNM_DEC: (K | '#') '-'? (INT+ | INT+ '.' + INT+ | '.' + INT+ | INT+ '.');
MNM_HEX: (H | '$') [0-9a-fA-F]+;
ASTARISK: '*';
COLON: ':';
DOT: '.';
ATMARK: '@';
UNDERBAR: '_';
OPERATOR: '+' | '-' | '/' | '>' | '>>' | '<' | '<<' | '|' | '=' | '~';
SUFFIX: DOT TEXT;
LITERAL: '"' TEXT*? '"';
WS: ' ';
EOL: '\r' | '\n' | '\r\n';

INT: [0-9]+;
TEXT: [a-zA-Z]+;
fragment A: [Aa];
fragment B: [Bb];
fragment C: [Cc];
fragment D: [Dd];
fragment E: [Ee];
fragment F: [Ff];
fragment G: [Gg];
fragment H: [Hh];
fragment I: [Ii];
fragment J: [Jj];
fragment K: [Kk];
fragment L: [Ll];
fragment M: [Mm];
fragment N: [Nn];
fragment O: [Oo];
fragment Q: [Qq];
fragment S: [Ss];
fragment T: [Tt];
fragment U: [Uu];
fragment V: [Vv];
fragment W: [Ww];
fragment X: [Xx];
fragment Y: [Yy];
fragment Z: [Zz];
