using AlloyCommerce.Business.Rendering;
using EPiServer.Commerce.Catalog.ContentTypes;
using EPiServer.Commerce.Catalog.DataAnnotations;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlloyCommerce.Models.Catalog
{
    [CatalogContentType(DisplayName ="Category/Node",
        GroupName ="Commerce",
        MetaClassName ="Alloy_Node", 
        GUID = "094A1AFE-727A-44A0-A074-36BA07F2D092")]
    public class AlloyNode : NodeContent, ISiteContent
    {
        public virtual string LanguageBranch
        {
            get { return this.Language.Name; }
        }

        public virtual string MetaTitle { get; set; }
        public virtual string MetaDescription { get; set; }
    }
}