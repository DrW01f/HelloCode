int Max (int arg1, int arg2, int arg3)
{
int result = arg1;

if (arg2 > result) result = arg2;
if (arg3 > result) result = arg3;
}


int a1 = 5515;
int b1 = 21; 
int c1 = 39;

int a2 = 12;
int b2 = 2311;
int c2 = 32;

int a3 = 13;
int b3 = 23;
int c3 = 313;

int max = a1;

if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

Console.WriteLine(max);
