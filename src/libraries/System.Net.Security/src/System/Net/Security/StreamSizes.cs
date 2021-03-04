// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Net
{
    internal partial struct StreamSizes
    {
        public int Header
        {
            get;
            private set;
        }

        public int Trailer
        {
            get;
            private set;
        }

        public int MaximumMessage
        {
            get;
            private set;
        }
    }
}
