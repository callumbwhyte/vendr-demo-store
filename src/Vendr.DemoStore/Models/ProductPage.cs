﻿using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models.PublishedContent;

namespace Vendr.DemoStore.Models
{
    public partial class ProductPage
    {
        public CollectionPage Collection => this.Parent as CollectionPage;

        public IPublishedContent PrimaryImage => this.Images.FirstOrDefault();

        public IEnumerable<ProductVariant> Variants => this.Children.OfType<ProductVariant>();
    }
}
