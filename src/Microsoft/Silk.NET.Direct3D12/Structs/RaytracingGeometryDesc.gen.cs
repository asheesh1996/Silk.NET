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
    [NativeName("Name", "D3D12_RAYTRACING_GEOMETRY_DESC")]
    public unsafe partial struct RaytracingGeometryDesc
    {
        public RaytracingGeometryDesc
        (
            RaytracingGeometryType? type = null,
            RaytracingGeometryFlags? flags = null,
            RaytracingGeometryDescUnion? anonymous = null,
            RaytracingGeometryTrianglesDesc? triangles = null,
            RaytracingGeometryAabbsDesc? aABBs = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (triangles is not null)
            {
                Triangles = triangles.Value;
            }

            if (aABBs is not null)
            {
                AABBs = aABBs.Value;
            }
        }


        [NativeName("Type", "D3D12_RAYTRACING_GEOMETRY_TYPE")]
        [NativeName("Type.Name", "D3D12_RAYTRACING_GEOMETRY_TYPE")]
        [NativeName("Name", "Type")]
        public RaytracingGeometryType Type;

        [NativeName("Type", "D3D12_RAYTRACING_GEOMETRY_FLAGS")]
        [NativeName("Type.Name", "D3D12_RAYTRACING_GEOMETRY_FLAGS")]
        [NativeName("Name", "Flags")]
        public RaytracingGeometryFlags Flags;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12_L12484_C5")]
        [NativeName("Name", "anonymous1")]
        public RaytracingGeometryDescUnion Anonymous;
#if NETSTANDARD2_1
        public ref RaytracingGeometryTrianglesDesc Triangles
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.Triangles;
        }
#else
        public RaytracingGeometryTrianglesDesc Triangles
        {
            get => Anonymous.Triangles;
            set => Anonymous.Triangles = value;
        }
#endif

#if NETSTANDARD2_1
        public ref RaytracingGeometryAabbsDesc AABBs
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.AABBs;
        }
#else
        public RaytracingGeometryAabbsDesc AABBs
        {
            get => Anonymous.AABBs;
            set => Anonymous.AABBs = value;
        }
#endif

    }
}
