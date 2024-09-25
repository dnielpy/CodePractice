#include <stdio.h>

int main(){

	float total, final;

	printf("Ingrese el total a pagar: ");

	scanf("%f", &total);	

	
	final = total * 0.15;

	printf("Tiene que pagar: %f", final);	

}