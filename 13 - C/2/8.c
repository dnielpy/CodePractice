#include <stdio.h>

int main()
{
    int n;
    printf("Escribe el numero: ");
    scanf("%d", &n);

    for (int i = 0; i <= n; i++)
    {
        char cadena[i];

        for (int z = 0; z < sizeof(cadena)/sizeof(cadena[0]); z++)
        {
            cadena[z] = '*';
        }
        printf(cadena);
        printf("\n");
    }
}
