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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    public static class ArbViewportArrayOverloads
    {
        public static unsafe void DepthRangeArray(this ArbViewportArray thisApi, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.DepthRangeArray(first, count, in v.GetPinnableReference());
        }

        public static unsafe void GetDouble(this ArbViewportArray thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<double> data)
        {
            // SpanOverloader
            thisApi.GetDouble(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetDouble(this ArbViewportArray thisApi, [Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<double> data)
        {
            // SpanOverloader
            thisApi.GetDouble(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetFloat(this ArbViewportArray thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<float> data)
        {
            // SpanOverloader
            thisApi.GetFloat(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetFloat(this ArbViewportArray thisApi, [Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<float> data)
        {
            // SpanOverloader
            thisApi.GetFloat(target, index, out data.GetPinnableReference());
        }

        public static unsafe void ScissorArray(this ArbViewportArray thisApi, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.ScissorArray(first, count, in v.GetPinnableReference());
        }

        public static unsafe void ScissorIndexed(this ArbViewportArray thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.ScissorIndexed(index, in v.GetPinnableReference());
        }

        public static unsafe void ViewportArray(this ArbViewportArray thisApi, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ViewportArray(first, count, in v.GetPinnableReference());
        }

        public static unsafe void ViewportIndexed(this ArbViewportArray thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ViewportIndexed(index, in v.GetPinnableReference());
        }

    }
}

