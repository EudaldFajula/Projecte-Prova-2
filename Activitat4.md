4. A partir d'una màquina senzilla que pot executar 4 operacions (2 punts):

CMP -> 00 MOV-> 01 ADD -> 10  BEQ -> 11

Tradueix a llenguatge de baix nivell les següents instruccions, indicant la instrucció sencera (de 16 bits) en format binari que ha d’executar la màquina:

CMP 3F, 45

CMP -> 00.

Pasar-ho a decimal

3F -> 3 x 16^1 + 15 x 16^0 = 48 + 15 = 63

45 -> 4 x 16^1 + 5 x 16^0 = 64 + 5 = 69

Pasar-ho a binari

63 / 2 = 31 (1), 31 / 2 = 15 (1), 15 / 2 = 7 (1), 7 / 2 = 3 (1), 3 / 2 = 1 (1) = 1 / 2 = 0 (1)

69 / 2 = 34 (1), 34 / 2 = 17 (0), 17 / 2 = 8 (1), 8 / 2 = 4 (0), 4 / 2 = 2 (0), 2 / 2 = 1 (0), 1 / 2 = 0 (1)

Total: 00 111111 1000101

MOV AE, 94

MOV -> 01

Pasar-ho a decimal

AE -> 10 x 16^1 + 14 x 16^0 = 160 + 14 = 174

94 -> 9 x 16^1 + 4 x 16^0 = 144 + 4 = 148

Pasar-ho a binari

174 / 2 = 87 (0), 87 / 2 = 43 (1), 43 / 2 = 21 (1), 21 / 2 = 10 (1), 10 / 2 = 5 (0), 5 / 2 = 2 (1), 2 / 2 = 1 (0), 1 / 2 = 0 (1)

148 / 2 = 73 (0), 73 / 2 = 36 (1), 36 / 2 = 18 (0), 18 / 2 = 9 (0), 9 / 2 = 4 (1), 4 / 2 = 2 (0), 2 / 2 = 1 (0), 1 / 2 = 0 (1)

Total: 01 10101110 10010010

ADD 11, A3

ADD -> 10

Pasar-ho a decimal

11 -> 1 x 16^1 + 1 x 16^0 = 16 + 1 = 17

A3 -> 10 x 16^1 + 3 x 16^0 = 160 + 3 = 163

Pasar-ho a binari

17 / 2 = 8 (1), 8 / 2 = 4 (0), 4 / 2 = 2 (0), 2 / 2 = 1 (0), 1 / 2 = 0 (1)

163 / 2 = 81 (1), 81 / 2 = 40 (1), 40 / 2 = 20 (0), 20 / 2 = 10 (0), 10 / 2 = 5 (0), 5 / 2 = 2 (1), 2 / 2 = 1 (0), 1 / 2 = 0 (1)

Total: 10 10001 10100011

MOV 8A, 77

MOV -> 01

Pasar-ho a decimal

8A -> 8 x 16^1 + 10 x 16^0 = 128 + 10 = 138

77 -> 7 x 16^1 + 7 x 16^0 = 112 + 7 = 119

Pasar-ho a binari

138 / 2 = 69 (0), 69 / 2 = 34 (1), 34 / 2 = 17 (0), 17 / 2 = 8 (1), 8 / 2 = 4 (0), 4 / 2 = 2 (0), 2 / 2 = 1 (0), 1 / 2 = 0 (1)

119 / 2 = 59 (1), 59 / 2 = 29 (1), 29 / 2 = 14 (1), 14 / 2 = 7 (0), 7 / 2 = 3 (1), 3 / 2 = 1 (1), 1 / 2 = 0 (1)

Total: 01 10001010 1110111


Important!! Totes les adreces de memòria estan en base hexadecimal.
