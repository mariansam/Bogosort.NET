# Bogosort.NET
The best sorting algorithm in C#!

# Installation
This should be available as a NuGet package ASAP!

# Usage
The usage of this package is pretty straight-forward. Here is an example.
```cs
using System;
using System.Collections.Generic;
using Bogosort;

namespace Bogosort.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 0, 3, 4, 7, 4, 16, 9, 147, 9, 14 };
            list.Bogosort();
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
```

## **Enjoy!**