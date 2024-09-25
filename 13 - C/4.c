#include <stdio.h>
#include <math.h>

int main()
{

    float r, c;

    printf("Ingrese el radio de la circunferencia: ");
    scanf("%f", &r);

    c = 2 * M_PI * r;

    printf("La longitud de la circunferencia es: %f", c);
}