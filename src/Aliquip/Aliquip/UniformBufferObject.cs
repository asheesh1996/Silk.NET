﻿// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Runtime.InteropServices;
using Silk.NET.Maths;

namespace Aliquip
{
    [StructLayout(LayoutKind.Explicit)]
    public struct UniformBufferObject
    {
        [FieldOffset(0)]
        public Matrix4X4<float> Model;
        [FieldOffset(64)]
        public Matrix4X4<float> View;
        [FieldOffset(128)]
        public Matrix4X4<float> Projection;

        public UniformBufferObject(Matrix4X4<float> model, Matrix4X4<float> view, Matrix4X4<float> projection)
        {
            Model = model;
            View = view;
            Projection = projection;
        }
    }
}
