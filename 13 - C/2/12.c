#include <stdio.h>

int main(){

    int n;

    printf("Escribe el numero: ");
    scanf("%d", &n);

    int x[n];

    x[0] = 0;
    x[1] = 1;
    printf("%d \n%d \n", 0, 1);
    for(int i = 2; i < n; i++){
        x[i] = x[i-1] + x[i-2];
        printf("%d \n", x[i]);
    }
}