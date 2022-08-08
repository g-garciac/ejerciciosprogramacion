# Ejercicio **012**

## Los espejos

Se tiene una caja de madera dividida en `f`x`c` partes, es decir, `f` filas por `c` columnas. Dentro de la caja existen `e` espejos colocados en diagonal respecto a las paredes de la caja y colocados en distintas posiciones dentro de la caja. Adicionalmente se tienen `l` láseres colocados en distintas posiciones y orientados o apuntando en alguna de las siguientes direcciones: `norte`, `sur`, `este`, `oeste`.

Consideraciones:
* La fila `1` se encuentra en el sur de la caja o lado inferior, y la fila `f` se encuentra en el norte o lado superior. 
* La columna `1` se encuentra en el oeste o lado izquierdo de la caja, y la columna `c` se encuentra en el este o lado derecho de la caja.
* `e` es un conjunto de espejos donde cada es pejo está dado por su orientación o inclinación: `/` o `\` seguido de un espacio, seguido de la fila, seguido de la columna. Por ejemplo, `\ 3 2,/ 1 4` representa dos espejos: uno inclinado a la izquierda colocado en la fila 3 y columna dos; y otro inclinado a la derecha en la fila 1 y columna 4.
* Los espejos reflectan por ambos lados y siempre su inclinación está a 45 o 135 grados respecto a la parte sur de la caja, lo que implica que un espejo siempre desviará el láser que incida en él en un ángulo de 90 grados.
* `l` es un conjunto de láseres donde cada láser está dado por la dirección a la que apunta, seguido de un espacio, seguido de la fila, seguido de un espacio, seguido de la columna. Por ejemplo `O 3 1,N 7 3` representa dos láseres: uno apuntado o dirigido hacia el oeste y en la fila 3 y columna 1; y el otro hacial el norte en la fila 7 y la columna 3.
* Los láseres nunca se colocarán en la misma posición que un espejo u otro láser.

Dicho esto, en algún momento se encienden los láseres y se pretende saber `r` y `p` para cada láser, donde:

* `r` = Por cuántos espejos es reflejado el lásere antes de que éste llegue a una de las paredes de la caja, o bien `-1` si el láser se quedara dando vueltas indefinidamente en los espejos sin llegar a ninguna pared de la caja.
* `p` = En caso de que el láser sí llegue a una de las paredes de la caja, se desea saber en cuál de las 4 paredes llega: pared norte `N`, pared sur `S`, pared este `E`, pared oeste `O` y en qué posición de la pared: entre `1` y `f` o entre `1` y `c` según corresponda la pared. Por ejemplo si el láser llega a la pared oeste en la fila 4, deberá indicarse como `O 4`. O bien `? ?` en caso de que el láser no llegue a ninguna pared de la caja.
* Como `r` y `p` corresponde a un único láser, pero puede existir más de un láser, entonces deberá especificarse `r` y `p` precedidos por la especificación del láser seprados los tres elementos por una coma `,`. Por ejemplo supongamos que para el láser `O 3 1`, `r` es 4, y `p` es `?`, entonces el resultado debe indicarse así: `O 3 1,4,? ?`, si fueran más de un láser, éstos se separarían usando pipes `|`.

Se sugiere tomar en cuenta para la entrada de datos un archivo que contenga la siguiente estructura:

* Línea 1: `f c`, es decir la cantidad de filas y columnas que tiene la caja separados por un espacio respectivamente
* Línea 2: `e`, es decir el conjunto de espejos indicado como se describió antes.
* Línea 3: `l`, es decir el conjunto de láseres indicado como se describió antes.

### Ejemplo 1

Dados:

`f`=`6`

`c`=`8`

`e`=`/ 5 3,\ 5 6,/ 2 3,/ 1 6`

`l`=`E 1 2`

Visualmente las variables se verían así:

![Ejemplo 1](https://github.com/g-garciac/ejerciciosprogramacion/blob/main/ejercicios/012/ejemplo1.png "Ejemplo 1")

La estructura del archivo de entrada sería así:

```
6 8
/ 5 3,\ 5 6,/ 2 3,/ 1 6
E 1 2
```

El programa debe calcular `r` y `p` quedando el resultado final así: `E 1 2,4,O 2`.

### Ejemplo 2

Dados:

`f`=`6`

`c`=`8`

`e`=`/ 6 1,\ 6 8,/ 5 3,\ 5 4,\ 4 4,\ 4 5,\ 4 6,/ 3 2,\ 3 3,/ 3 5,/ 3 6,/ 3 7,\ 2 5,/ 2 6,\ 1 1,/ 1 8`

`l`=`O 5 2,S 5 5,S 4 3,N 2 3,N 2 7,E 1 4`

Visualmente las variables se verían así:

![Ejemplo 2](https://github.com/g-garciac/ejerciciosprogramacion/blob/main/ejercicios/012/ejemplo2.png "Ejemplo 2")

La estructura del archivo de entrada sería así:

```
6 8
/ 6 1,\ 6 8,/ 5 3,\ 5 4,\ 4 4,\ 4 5,\ 4 6,/ 3 2,\ 3 3,/ 3 5,/ 3 6,/ 3 7,\ 2 5,/ 2 6,\ 1 1,/ 1 8
O 5 2,S 5 5,S 4 3,N 2 3,N 2 7,E 1 4
```

El programa debe calcular `r` y `p` para cada laser, quedando el resultado final así: `O 5 2,0,O 5|S 5 5,8,N 7|S 4 3,-1,? ?|N 2 3,2,S 1|N 2 7,1,E 3|E 1 4,-1, ? ?`.
