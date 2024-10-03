#include <stdio.h>

int main(){
	
	float hours, minutes, seconds, final;

	printf("Ingrese las horas: ");
	scanf("%f", &hours);


	printf("Ingrese losminutos: ");
	scanf("%f", &minutes);

	printf("Ingrese las segundos: ");
	scanf("%f", &seconds);

	final = (hours * 3600) + (minutes * 60) + seconds;

	printf("hay un total de: %f", final);
}