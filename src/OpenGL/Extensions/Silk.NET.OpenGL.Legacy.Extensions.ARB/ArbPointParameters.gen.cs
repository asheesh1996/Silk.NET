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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_point_parameters")]
    public unsafe partial class ArbPointParameters : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_point_parameters";
        [NativeApi(EntryPoint = "glPointParameterfARB")]
        public partial void PointParameter([Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPointParameterfARB")]
        public partial void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPointParameterfvARB")]
        public unsafe partial void PointParameter([Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glPointParameterfvARB")]
        public partial void PointParameter([Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glPointParameterfvARB")]
        public unsafe partial void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glPointParameterfvARB")]
        public partial void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        public ArbPointParameters(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

