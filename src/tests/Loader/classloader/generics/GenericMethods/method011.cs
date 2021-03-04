// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Threading;

interface IFoo 
{
	U Function<U>(U u);		
}

class Foo : IFoo
{
	public virtual U Function<U>(U u)
	{
		return u;
	}
		
}

public class Test
{
	public static int counter = 0;
	public static bool result = true;
	public static void Eval(bool exp)
	{
		counter++;
		if (!exp)
		{
			result = exp;
			Console.WriteLine("Test Failed at location: " + counter);
		}
	
	}
	
	public static int Main()
	{
		IFoo f = new Foo();

		Eval(f.Function<int>(1).Equals(1));
		Eval(f.Function<string>("string").Equals("string"));
		
		
		if (result)
		{
			Console.WriteLine("Test Passed");
			return 100;
		}
		else
		{
			Console.WriteLine("Test Failed");
			return 1;
		}
		
	}
}

