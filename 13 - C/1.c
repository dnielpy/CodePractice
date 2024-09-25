#include <stdio.h>

int main()
{
    int num1, num2;
    int suma, resta, multi, div;

    printf("Intgresa el primer numero: ");
    scanf("%d", &num1);

    printf("Intgresa el segundo numero: ");
    scanf("%d", &num2);

    suma = num1 + num2;
    resta = num1 - num2;
    multi = num1 * num2;
    div = num1 / num2;

    printf("Suma: %d\n", suma);
    printf("Resta: %d\n", resta);
    printf("Multiplicación: %d\n", multi);
    printf("División: %d\n", div);
}