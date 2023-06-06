// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

using Fundamentals.Lesson4;
using Microsoft.CSharp.RuntimeBinder;

namespace Fundamentals
{
    public class DynamicTests
    {
        [Fact]
        public void UseAsString_WhenInputValueIsInvalid_ThrowsError()
        {
            Action method = () => Dynamic.UseAsString(1);
            Assert.Throws<RuntimeBinderException>(method);
        }
    }
}
