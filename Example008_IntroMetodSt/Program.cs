// Найти максимальное из 9 чисел
int a1 = 3;
int b1 = 8;
int c1 = 19;

int a2 = 34;
int b2 = 65;
int c2 = 45;

int a3 = 32;
int b3 = 87;
int c3 = 55;

int max = a1;

if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);
