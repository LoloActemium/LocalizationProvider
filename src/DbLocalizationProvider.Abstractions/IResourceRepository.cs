// Copyright (c) Valdis Iljuconoks. All rights reserved.
// Licensed under Apache-2.0. See the LICENSE file in the project root for more information

using System.Collections.Generic;
using System.Globalization;

namespace DbLocalizationProvider.Abstractions
{
    public interface IResourceRepository
    {
        IEnumerable<CultureInfo> GetAvailableLanguages(bool includeInvariant);
    }
}
