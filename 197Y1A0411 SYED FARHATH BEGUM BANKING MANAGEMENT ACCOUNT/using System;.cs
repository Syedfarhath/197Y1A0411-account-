using System;

class printUnion {


static int printUnion( int [] arr1,int [] arr2, int m, int n)

{
int i = 0, j = 0;
while (i < m && j < n) {
if (arr1[i] < arr2[j])
Console.Write(arr1[i++] + " " );
else if (arr2[j] < arr1[i])
Console.Write(arr2[j++] + " " );
else {
Console.Write(arr2[j++] + " " );
i++;
}
}
while (i < m)
Console.Write(arr1[i++] + " " );
while (j < n)
Console.Write(arr2[j++] + " " );
return 0;
}
public static void Main()
{

int [] arr1 = { 5,2,3,4,7,1};

int [] arr2 = { 4,1,3,5 };

int m = arr1.Length;

int n = arr2.Length;

printUnion(arr1, arr2, m, n);

}

}




