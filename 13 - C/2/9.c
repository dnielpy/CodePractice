#include <stdio.h>

int main()
{
    int x;

    printf("Escribe el numero: ");
    scanf("%d", &x);

    int counter = 0;

    for (int i = 1; i <= 10; i++)
    {
        if (x == 1){
            printf("Es primo");
            break;
        }
        int s = x % i;
        if (x % i == 0){
            counter++;
        }
    }

    if (counter > 3)
    {
        printf("No es primo");
    }
    else
    {
        printf("Es primo");
    }
    
}