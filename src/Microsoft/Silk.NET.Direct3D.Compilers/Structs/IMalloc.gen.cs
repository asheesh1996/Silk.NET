// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D.Compilers
{
    [Guid("00000002-0000-0000-c000-000000000046")]
    [NativeName("Name", "IMalloc")]
    public unsafe partial struct IMalloc
    {
        public static readonly Guid Guid = new("00000002-0000-0000-c000-000000000046");

    }
}
