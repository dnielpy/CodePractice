#include <stdio.h>

int main()
{
	int x, y;

	printf("Escriba el numero: ");
	scanf("%d", &x);

	for (int i = 0; i <= x; i++)
	{
		y += i;
	}

	printf("%d", y);
}
