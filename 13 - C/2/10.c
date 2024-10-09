#include <stdio.h>

int main(){

    int n, x = 1;

    printf("Escribe el Numero: ");

    scanf("%d", &n);

    for(int i = 1; i <= n; i++){
        x = x*i;
    }

    printf("%d", x);
}