// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;

namespace System.Configuration.Internal
{
    public interface IInternalConfigClientHost
    {
        bool IsExeConfig(string configPath);
        bool IsRoamingUserConfig(string configPath);
        bool IsLocalUserConfig(string configPath);
        string GetExeConfigPath();
        string GetRoamingUserConfigPath();
        string GetLocalUserConfigPath();
    }
}
