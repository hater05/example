﻿int a = 1;
int b = 25;
int c = 64;
int d = 8;
int e = 13;

int max = a;

if (a > max ) max = a;
if (b > max ) max = b;
if (c > max ) max = c;
if (d > max ) max = d;
if (e > max ) max = e;

Console.Write("max = ");
Console.WriteLine(max);