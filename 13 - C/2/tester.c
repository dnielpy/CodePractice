#include <stdio.h>

int main()
{

    int n;

    printf("Ingrese la cantidad: ");

    scanf("%d", &n);

    for (int i = 0; i <= n; i++)
    {
        printf("*");
    }
}