﻿using System.Web.Mvc;
using EPiServer.Commerce.Catalog.ContentTypes;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace EPiServer.Reference.Commerce.Site.Features.Product.Controllers
{
    [TemplateDescriptor(Inherited = true)]
    public class VariationPartialController : PartialContentController<VariationContent>
    {
        private readonly IProductService _productService;

        public VariationPartialController(IProductService productService)
        {
            _productService = productService;
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public override ActionResult Index(VariationContent currentContent)
        {
            return PartialView("_ProductViewModel", _productService.GetProductViewModel(currentContent));
        }
    }
}