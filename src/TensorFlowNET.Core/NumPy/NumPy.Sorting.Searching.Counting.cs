﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Tensorflow.NumPy
{
    public partial class np
    {
        [AutoNumPy]
        public static NDArray argmax(NDArray a, Axis axis = null)
            => new NDArray(math_ops.argmax(a, axis));

        [AutoNumPy]
        public static NDArray argsort(NDArray a, Axis axis = null)
            => new NDArray(math_ops.argmax(a, axis ?? -1));

        [AutoNumPy]
        public static NDArray unique(NDArray a)
            => throw new NotImplementedException("");
    }
}
