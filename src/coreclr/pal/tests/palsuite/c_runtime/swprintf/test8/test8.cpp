// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

/*============================================================================
**
** Source:  test8.c
**
** Purpose: Tests swprintf with decimal numbers
**
**
**==========================================================================*/



#include <palsuite.h>
#include "../swprintf.h"

/*
 * Uses memcmp & wcslen
 */

PALTEST(c_runtime_swprintf_test8_paltest_swprintf_test8, "c_runtime/swprintf/test8/paltest_swprintf_test8")
{
    int neg = -42;
    int pos = 42;
    INT64 l = 42;
    
    if (PAL_Initialize(argc, argv) != 0)
    {
        return FAIL;
    }


    DoNumTest(convert("foo %d"), pos, convert("foo 42"));
    DoNumTest(convert("foo %ld"), 0xFFFF, convert("foo 65535"));
    DoNumTest(convert("foo %hd"), 0xFFFF, convert("foo -1"));
    DoNumTest(convert("foo %Ld"), pos, convert("foo 42"));
    DoI64Test(convert("foo %I64d"), l, "0x0000000000000042",
              convert("foo 42"));
    DoNumTest(convert("foo %3d"), pos, convert("foo  42"));
    DoNumTest(convert("foo %-3d"), pos, convert("foo 42 "));
    DoNumTest(convert("foo %.1d"), pos, convert("foo 42"));
    DoNumTest(convert("foo %.3d"), pos, convert("foo 042"));
    DoNumTest(convert("foo %03d"), pos, convert("foo 042"));
    DoNumTest(convert("foo %#d"), pos, convert("foo 42"));
    DoNumTest(convert("foo %+d"), pos, convert("foo +42"));
    DoNumTest(convert("foo % d"), pos, convert("foo  42"));
    DoNumTest(convert("foo %+d"), neg, convert("foo -42"));
    DoNumTest(convert("foo % d"), neg, convert("foo -42"));

    PAL_Terminate();
    return PASS;
}

