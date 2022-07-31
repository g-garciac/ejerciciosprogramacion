# Ejercicio **011**

## Texto en espiral

Dado un texto `t` y un número `n`, calcular una matriz de tamaño `n`x`n`, que contenga cada una de las letras de `t` distribuídas en forma de espiral, iniciando por la esquina superior izquierda de la matriz y finalizando en el interior de la matriz. Si la cantidad de letras del texto es inferior a `n`x`n`, entonces debe comenzarse nuevamente a distribuir la letras del texto.

### Ejemplo 1

Para `t`=`abc`, y `n`=3
El resultado debe ser:

$$
\left(\begin{array}{cc}
a&b&c\\
b&c&a\\
a&c&b\\
\end{array}\right)
$$

### Ejemplo 2

Para `t`=`hola`, y `n`=5
El resultado debe ser:

$$
\left(\begin{array}{cc}
h&o&l&a&h\\
a&h&o&l&o\\
l&a&h&a&l\\
o&l&o&h&a\\
h&a&l&o&h\\
\end{array}\right)
$$

### Ejemplo 3

Para `t`=`yo.solo.se.que.no.se.nada`, y `n`=4
El resultado debe ser:

$$
\left(\begin{array}{cc}
y&o&.&s\\
q&u&e&o\\
.&n&.&l\\
e&s&.&o\\
\end{array}\right)
$$
