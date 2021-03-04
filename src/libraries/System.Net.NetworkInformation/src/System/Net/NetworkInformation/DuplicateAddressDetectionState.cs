// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Net.NetworkInformation
{
    /// <summary>
    /// Specifies the current state of an IP address.
    /// </summary>
    public enum DuplicateAddressDetectionState
    {
        Invalid = 0,
        Tentative,
        Duplicate,
        Deprecated,
        Preferred,
    }
}
