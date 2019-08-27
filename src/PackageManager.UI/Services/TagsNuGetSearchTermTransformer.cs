﻿using Neptuo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Services
{
    public class TagsNuGetSearchTermTransformer : INuGetSearchTermTransformer
    {
        private readonly string tags;

        public TagsNuGetSearchTermTransformer(string tags)
        {
            Ensure.NotNull(tags, "tags");
            this.tags = tags;
        }

        public string Transform(string searchTerm)
        {
            if (String.IsNullOrEmpty(tags))
                return searchTerm;

            return $"{searchTerm} tags:{tags}";
        }
    }
}
