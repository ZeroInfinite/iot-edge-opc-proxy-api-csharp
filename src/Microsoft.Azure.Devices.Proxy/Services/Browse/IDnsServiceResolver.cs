﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.Devices.Proxy {
    using System;
    /// <summary>
    /// Service browser interface - enumerate service records
    /// </summary>
    public interface IDnsServiceResolver :
        IAsyncEnumerator<DnsServiceEntry>, IDisposable { }
}
