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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPipelineCoverageReductionStateCreateInfoNV")]
    public unsafe partial struct PipelineCoverageReductionStateCreateInfoNV
    {
        public PipelineCoverageReductionStateCreateInfoNV
        (
            StructureType? sType = StructureType.PipelineCoverageReductionStateCreateInfoNV,
            void* pNext = null,
            uint? flags = null,
            CoverageReductionModeNV? coverageReductionMode = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (coverageReductionMode is not null)
            {
                CoverageReductionMode = coverageReductionMode.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkPipelineCoverageReductionStateCreateFlagsNV")]
        [NativeName("Type.Name", "VkPipelineCoverageReductionStateCreateFlagsNV")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkCoverageReductionModeNV")]
        [NativeName("Type.Name", "VkCoverageReductionModeNV")]
        [NativeName("Name", "coverageReductionMode")]
        public CoverageReductionModeNV CoverageReductionMode;
    }
}
