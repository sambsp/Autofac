﻿using Autofac.Core.Resolving;

namespace Autofac.Core.Diagnostics
{
    /// <summary>
    /// Event data for the <see cref="DefaultDiagnosticTracer.OperationCompleted"/> event.
    /// </summary>
    public sealed class OperationTraceCompletedArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationTraceCompletedArgs"/> class.
        /// </summary>
        /// <param name="operation">The operation for which a trace has completed.</param>
        /// <param name="traceContent">The content of the trace.</param>
        public OperationTraceCompletedArgs(ResolveOperationBase operation, string traceContent)
        {
            Operation = operation;
            TraceContent = traceContent;
        }

        /// <summary>
        /// Gets the operation for which a trace is available.
        /// </summary>
        public ResolveOperationBase Operation { get; }

        /// <summary>
        /// Gets the content of the trace.
        /// </summary>
        public string TraceContent { get; }
    }
}