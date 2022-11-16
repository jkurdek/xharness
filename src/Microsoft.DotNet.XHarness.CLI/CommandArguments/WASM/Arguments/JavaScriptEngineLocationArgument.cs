﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.DotNet.XHarness.CLI.CommandArguments.Wasm;

internal class JavaScriptEngineLocationArgument : StringArgument
{
    public JavaScriptEngineLocationArgument() : base("js-engine-path=", "Path to the JS engine to be used. This must correspond to the engine specified with -e")
    {
    }
}
