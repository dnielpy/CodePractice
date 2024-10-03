#include <stdio.h>

int main()
{
    float celcius, fahrenheit;

    printf("Escriba los grados Celcius: ");
    scanf("%f", &celcius);

    fahrenheit = (celcius * (9.0 / 5.0)) + 32.0;
    printf("Equivalen a: %f Fahrenheit", fahrenheit);
}