﻿using AutoMapper;
using TrauDatShop.Model.Models;
using TrauDatShop.Web.Models;

namespace TrauDatShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {

                cfg.CreateMap<Post, PostViewModel>().MaxDepth(2);
                cfg.CreateMap<PostCategory, PostCategoryViewModel>().MaxDepth(2);
                cfg.CreateMap<Tag, TagViewModel>().MaxDepth(2);

                cfg.CreateMap<ProductCategory, ProductCategoryViewModel>().MaxDepth(2);
                cfg.CreateMap<Product, ProductViewModel>().MaxDepth(2);
                cfg.CreateMap<ProductTag, ProductTagViewModel>().MaxDepth(2);
                cfg.CreateMap<Footer, FooterViewModel>().MaxDepth(2);
                cfg.CreateMap<Slide, SlideViewModel>().MaxDepth(2);
                cfg.CreateMap<Page, PageViewModel>().MaxDepth(2);
                cfg.CreateMap<ContactDetail, ContactDetailViewModel>().MaxDepth(2);
                cfg.CreateMap<ApplicationGroup, ApplicationGroupViewModel>().MaxDepth(2);
                cfg.CreateMap<ApplicationRole, ApplicationRoleViewModel>().MaxDepth(2);
                cfg.CreateMap<ApplicationUser, ApplicationUserViewModel>().MaxDepth(2);




            });
        }
    }
}