# Ejercicio **003**

## Lista de números primos circulares

Calcular la lista de números primos circulares que existen entre `2` y un número `n` mayor o igual a `2`.

* Definamos un número primo circular como aquel cuyas `rotaciones` también son números primos.
* Definamos `rotación` de un número como las distintas combinaciones al ir rotando sus dígitos, por ejemplo las rotaciones para `1234` serían los números: `1234`, `2341`, `3412`, `4123`. Las rotaciones para 2048 serían los números: `2048`, `482`, `4820`, `8204`.

Calcular la lista de números primos circulares que existen entre 2 y n.

### Ejemplo

Dado `n=200`, los números primos circulares son: `2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, 97, 113, 131, 197`. En ésta lista de números, el número `197` es primo circular ya que todas sus rotaciones: `197, 971, 719` son números primos.