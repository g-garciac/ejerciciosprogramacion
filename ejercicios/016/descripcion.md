# Ejercicio **016**

## Caja fuerte

Se tiene una caja fuerte cuya cerradura se abre girando discos concentricos: `D1`, `D2`,..., siendo `D1` el disco del exterior, los discos tienen una secuencia de caracteres. Para abrir la caja se giran los discos concentricos en sentido horario `SH` o en sentido contra horario `CH`. 

Este es un ejemplo de una cerradura `C1` de tamaño 3, es decir, tiene un sólo disco `D1` (conformado por los caracteres ABCDEFGH):
$$
\left(\begin{array}{cc}
A&B&C\\
H&I&D\\
G&F&E\\
\end{array}\right)
$$
Este es un ejemplo de una cerradura `C2` de tamaño 4, es decir, tiene dos discos (`D1` el exterior conformado por los caracteres ABCDHLPONMIE y `D2` el interior conformado por FGKJ):
$$
\left(\begin{array}{cc}
A&B&C&D\\
E&F&G&H\\
I&J&K&L\\
M&N&O&P\\
\end{array}\right)
$$

Para dejar más claro el funcionamiento de giro de los discos, veámos unos ejemplos con las cerraduras anteriores `C1` y `C2`:

* Si giramos tres veces el único disco `D1` de la cerradura `C1` en sentido horario `SH` (dicha acción se puede resumir como `D1 3 SH`), ahora la cerradura quedaría así:
$$
\left(\begin{array}{cc}
F&G&H\\
E&I&A\\
D&C&B\\
\end{array}\right)
$$
* Si de la cerradura `C2` giramos una vez el disco uno `D1` en sentido contra horario `CH`, y giramos dos veces el disco `D2` en sentido horario `SH` (dicha acción se puede resumir como `D1 1 CH,D2 2 SH`), ahora la cerradura quedaría así:
$$
\left(\begin{array}{cc}
B&C&D&H\\
A&K&J&L\\
E&G&F&P\\
I&M&N&O\\
\end{array}\right)
$$

Problema: Se pretende que dada una cerradura en estado cerrado, se determinen el menor número de giros de sus discos, necesarios para llegar a su estado abierto.

### Ejemplo

Dada la siguiente cerradura en estado abierto:
$$
\left(\begin{array}{cc}
A&P&R&O&G&R\\
A&M&A&R&S&E\\
A&P&R&E&N&D\\
E&P&R&O&G&R\\
A&M&A&N&D&O\\
M&U&C&H&O&O\\
\end{array}\right)
$$
Y su análogo estado cerrado:
$$
\left(\begin{array}{cc}
C&U&M&A&E&A\\
H&A&R&S&N&A\\
O&M&R&R&G&A\\
O&P&O&E&D&P\\
O&P&M&A&N&R\\
R&D&E&R&G&O\\
\end{array}\right)
$$

La cantidad mínima de pasos para abrir la cerradura sería la siguiente: `D1 7 CH,D2 1 SH,D3 3 SH`, es decir:

* Girar 7 veces en contra horario el disco `D1` (el del exterior)
* Girar 1 vez en sentido horario el disco `D2`
* Girar 3 veces en sentido horario el disco `D3` (el del interior)