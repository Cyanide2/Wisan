// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.IO.Pipelines
{
    internal struct PipeCompletionCallback
    {
        public Action<Exception?, object?> Callback;
        public object? State;

        public PipeCompletionCallback(Action<Exception?, object?> callback, object? state)
        {
            Callback = callback;
            State = state;
        }
    }
}
