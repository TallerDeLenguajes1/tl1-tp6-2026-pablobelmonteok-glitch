¿String es una tipo por valor o un tipo por referencia? 
Es una de tipo por referencia porque vive en el heap,pero es raro poque se comorta como de valor.

Secuencias de escape de caracteres:
\'   - Comilla simple (0x0027)
\"   - Comilla doble (0x0022)
\\   - Barra invertida (0x005C)
\0   - Carácter nulo (0x0000)

Control de texto y cursor:
\a   - Alerta / Campana (0x0007)
\b   - Retroceso / Backspace (0x0008)
\e   - Carácter de escape (0x001B)
\f   - Avance de página / Form feed (0x000C)
\n   - Nueva línea / Salto de línea (0x000A)
\r   - Retorno de carro / Carriage return (0x000D)
\t   - Tabulación horizontal (0x0009)
\v   - Tabulación vertical (0x000B)

Secuencias de escape Unicode:
\uHHHH       - Unicode UTF-16 (4 dígitos HEX, intervalo: 0000 - FFFF). Ejemplo: \u00E7 = "ç"
\U00HHHHHH   - Unicode UTF-32 (8 dígitos HEX, intervalo: 000000 - 10FFFF). Ejemplo: \U0001F47D = "👽"
\xH[H][H][H] - Unicode de longitud variable (intervalo: 0 - FFFF). Ejemplo: \xE7, \x0E7 o \x00E7 = "ç"

 ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
 lo que sucede es que @ se usa para hacer una cadena de texto mas limpia mientras que  $ sirve para vincular el valor de alguna varia a travez de {}. 