#include <stdio.h>
#include <math.h>

int main(){
    float hip, cat1, cat2;
    
    printf("Ingrese el valor del primer cateto: ");
    scanf("%f", &cat1);

    printf("Ingrese el valor del segundo cateto: ");
    scanf("%f", &cat2);

    hip = sqrt(pow(cat1, 2) + pow(cat2, 2));

    printf("%f", hip);
}