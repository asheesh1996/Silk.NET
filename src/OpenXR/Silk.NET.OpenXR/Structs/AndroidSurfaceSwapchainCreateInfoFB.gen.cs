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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrAndroidSurfaceSwapchainCreateInfoFB")]
    public unsafe partial struct AndroidSurfaceSwapchainCreateInfoFB
    {
        public AndroidSurfaceSwapchainCreateInfoFB
        (
            StructureType? type = StructureType.TypeAndroidSurfaceSwapchainCreateInfoFB,
            void* next = null,
            AndroidSurfaceSwapchainFlagsFB? createFlags = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (createFlags is not null)
            {
                CreateFlags = createFlags.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "XrAndroidSurfaceSwapchainFlagsFB")]
        [NativeName("Type.Name", "XrAndroidSurfaceSwapchainFlagsFB")]
        [NativeName("Name", "createFlags")]
        public AndroidSurfaceSwapchainFlagsFB CreateFlags;
    }
}
