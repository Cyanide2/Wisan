// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.ObjectModel;

namespace System.UnitTesting
{
    public class ExpectationCollection<TInput, TOutput> : Collection<Expectation<TInput, TOutput>>
    {
        public void Add(TInput input, TOutput output)
        {
            Add(new Expectation<TInput, TOutput>(input, output));
        }
    }
}
