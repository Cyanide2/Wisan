// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System.Runtime.InteropServices;
using System;

internal class NullableTest
{
    private static bool BoxUnboxToNQ(ValueType o)
    {
        return Helper.Compare((ImplementOneInterface)o, Helper.Create(default(ImplementOneInterface)));
    }

    private static bool BoxUnboxToQ(ValueType o)
    {
        return Helper.Compare((ImplementOneInterface?)o, Helper.Create(default(ImplementOneInterface)));
    }

    private static int Main()
    {
        ImplementOneInterface? s = Helper.Create(default(ImplementOneInterface));

        if (BoxUnboxToNQ(s) && BoxUnboxToQ(s))
            return ExitCode.Passed;
        else
            return ExitCode.Failed;
    }
}


