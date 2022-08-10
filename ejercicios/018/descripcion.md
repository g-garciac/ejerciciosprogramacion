# Ejercicio **018**

## Mínimo absoluto circular

Dada una secuencia de números enteros `S`, definamos recorrido circular de `S` a la acción de tomar cualquier número de la secuencia y a continuación tomar cada uno de los siguientes números hasta el final, y sí el número que inicialmente se tomó fue de enmedio, enconces continuar con los primeros números de la secuencia hasta dar la vuelta completa a la secuencia. Por ejemplo, dado `S`=`2,-4,6,8,-1,3,-5` y tomando como inicio del recorrido el número 6, entonces el recorrido circular de la secuencia será: `6,8,-1,3,-5,2,-4`.

Dado un recorrido circular de una secuencia, llamemos sumas del recorrido a cada una de las sumas del número actual con el número siguiente. Por ejemplo para la misma secuencia `S` y el número inicial 6, las sumas del recorrido serían `6,14,13,16,11,13,9`, es decir se inicia con **6**, seguido de **14**:6+8, seguido de **13**:14+(-1), seguido de **16**:13+3 y así sucesivamente.

Llamemos Absoluto circular al valor absoluto de la suma del valor máximo y el valor mínimo alcanzado en las sumas del recorrido, es decir, `22` ya que `22`=`|16+6|`

Problemática: Escribir un programa que dada una secuencia de números, determine en qué elemento de la secuencia se debe inciar el recorrido circular para que el Absoluto circular sea el mínimo posible.

### Ejemplo

Dado `S`=`3,1,-2,2,-5`. Si se inicia en la posición 4, el valor máximo de la suma será 2 y el valor mínimo será –3. El absoluto circular es 1, y es el mínimo posible para `S`.