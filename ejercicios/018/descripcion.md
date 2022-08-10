# Ejercicio **018**

## Mínimo absoluto circular

Dada una secuencia de números enteros `S`, definamos recorrido circular de `S` a la acción de tomar cualquier número de la secuencia y a continuación tomar cada uno de los siguientes números hasta el final, y sí el número que inicialmente se tomó fue de enmedio, enconces continuar con los primeros números de la secuencia hasta dar la vuelta completa a la secuencia. Por ejemplo, dado `S`=`2,-4,6,8,-1,3,-5` y tomando como inicio del recorrido la posición 2 (las posiciones inician en 0), es decir, el número 6, entonces el recorrido circular de la secuencia será: `6,8,-1,3,-5,2,-4`.

Dado un recorrido circular de una secuencia, llamemos sumas del recorrido a cada una de las sumas del número actual con el número siguiente. Por ejemplo para la misma secuencia `S` e iniciando en la posición 2, las sumas del recorrido serían `6,14,13,16,11,13,9`, es decir se inicia con **6**, seguido de **14**:6+8, seguido de **13**:14+(-1), seguido de **16**:13+3 y así sucesivamente.

Llamemos Absoluto circular al valor absoluto de la suma del valor máximo y el valor mínimo alcanzado en las sumas del recorrido circular dada una determinada posición inicial, por ejemplo para `S` y dada la posición inicial 2, sería `22` ya que el valor máximo alcanzado en las sumas es `16`, y el valor mínimo alcanzado es `6`, por lo que se suman ambos `16+6` y el resultado es el valor absoluto de dicha suma: `|16+6|`.

Problemática: Escribir un programa que dada una secuencia de números, determine en qué posición de la secuencia debe inciarse un recorrido circular para que el Absoluto circular sea el mínimo posible.

### Ejemplo

Para `S`=`2,-4,6,-8,-1,3,-5` el programa debe obtener `2`.

Ya que al iniciar el recorrido en la posición `2` se tienen las siguientes sumas del recorrido circular: `6,-2,-3,0,-5,-3,-7`, donde `6` es la suma máxima alcanzada y `-7` es la suma mínima alcanzada, y `|6+(-7)|`=`1` es el mínimo ya que:

* Iniciando el recorrido en la posición 0, el Absoluto circular es 3
* Iniciando el recorrido en la posición 1, el Absoluto circular es 7
* Iniciando el recorrido en la posición 2, el Absoluto circular es 1
* Iniciando el recorrido en la posición 3, el Absoluto circular es 19
* Iniciando el recorrido en la posición 4, el Absoluto circular es 5
* Iniciando el recorrido en la posición 5, el Absoluto circular es 4
* Iniciando el recorrido en la posición 6, el Absoluto circular es 11

Y el mínimo Absoluto circular de todos ellos es 1.