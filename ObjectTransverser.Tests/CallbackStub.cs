﻿using System.Collections.Generic;

namespace HelperClasses.Tests
{
    public class CallbackStub
    {
        public List<object> CallbackObjects { get; } = new List<object>();

        public int Count => CallbackObjects.Count;

        public void Callback(object obj)
        {
            CallbackObjects.Add(obj);
        }
    }
}
