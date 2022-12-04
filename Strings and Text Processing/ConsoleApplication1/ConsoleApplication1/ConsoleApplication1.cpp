#include<iostream>
#include<math.h>
using namespace std;

void main()
{
	int n;
	cin >> n;
	int temp=n;
	int arr[100];
	int count = 0;
	while (temp != 0)
	{
		arr[count]=temp % 10;
		count++;
		temp /= 10;
	}
	bool isUnique = true;
	for (int i = 0; i < count; i++)
	{
		for (int j = i+1; j < count; j++)
		{
			if (arr[i]==arr[j])
			{
				isUnique = false;
			}
		}
	}

	if (isUnique)
	{
		cout << "Няма повтарящи се цифри! \n";
	}
	else
	{
		cout << "Има повтарящи се цифри! \n";
	}
}