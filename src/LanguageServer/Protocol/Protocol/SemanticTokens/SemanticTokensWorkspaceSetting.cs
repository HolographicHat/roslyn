﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Roslyn.LanguageServer.Protocol;

using System.Text.Json.Serialization;

/// <summary>
/// Capabilities specific to the semantic token requests scoped to the workspace.
/// <para>
/// See the <see href="https://microsoft.github.io/language-server-protocol/specifications/specification-current/#semanticTokensWorkspaceClientCapabilities">Language Server Protocol specification</see> for additional information.
/// </para>
/// </summary>
/// <remarks>Since LSP 3.16</remarks>
internal sealed class SemanticTokensWorkspaceSetting
{
    /// <summary>
    /// Gets or sets a value indicating whether the client implementation
    /// supports a refresh request sent from the server to the client.
    /// </summary>
    /// <remarks>
    /// Note that this event is global and will force the client to refresh all
    /// semantic tokens currently shown. It should be used with absolute care
    /// and is useful for situation where a server for example detect a project
    /// wide change that requires such a calculation.
    /// </remarks>
    [JsonPropertyName("refreshSupport")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool RefreshSupport { get; set; }
}
