using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.SymbolStore;
using System.Linq;
using Data.Entities;

namespace Tests.TranslateNG
{
    public class TestDataBuilder
    {
        public static Languages WithLanguages()
        {
            return new Languages
            {
                Id = new Guid()
            };
        }
    }
}