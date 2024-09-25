#include <stdio.h>

int main(){
	
	float par1, par2, par3, prom_par, final, trabfinal, nota_final;
	
	printf("Ingrese la nota del parcial #1:");
	scanf("%f", &par1);

	printf("Ingrese la nota del parcial #2:");
	scanf("%f", &par2);

	printf("Ingrese la nota del parcial #3:");
	scanf("%f", &par3);

	printf("Ingrese la prueba final:");
	scanf("%f", &final);

	printf("Ingrese la nota del trabajo final:");
	scanf("%f", &trabfinal);


	prom_par = (par1 + par2 + par3) / 3;

	nota_final = (prom_par * 0.55) + (0.30 * final) + (0.15 * trabfinal);

	printf("La nota final es: %f", nota_final);

}