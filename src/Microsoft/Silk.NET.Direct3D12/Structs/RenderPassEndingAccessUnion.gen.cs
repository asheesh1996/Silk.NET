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

namespace Silk.NET.Direct3D12
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12_L17477_C5")]
    public unsafe partial struct RenderPassEndingAccessUnion
    {
        public RenderPassEndingAccessUnion
        (
            RenderPassEndingAccessResolveParameters? resolve = null
        ) : this()
        {
            if (resolve is not null)
            {
                Resolve = resolve.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS")]
        [NativeName("Type.Name", "D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS")]
        [NativeName("Name", "Resolve")]
        public RenderPassEndingAccessResolveParameters Resolve;
    }
}
