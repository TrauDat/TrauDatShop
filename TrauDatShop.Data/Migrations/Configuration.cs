namespace TrauDatShop.Data.Migrations
{
    using Common;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Diagnostics;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TrauDatShop.Data.TrauDatShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TrauDatShop.Data.TrauDatShopDbContext context)
        {
            CreateProductCategorySample(context);
            CreateSlide(context);
            //  This method will be called after migrating to the latest version.
            CreatePage(context);
            CreateContactDetail(context);



        }
        private void CreateUser(TrauDatShopDbContext context)
        {
            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new TrauDatShopDbContext()));

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new TrauDatShopDbContext()));

            //var user = new ApplicationUser()
            //{
            //    UserName = "TrauDat",
            //    Email = "traudat2212@gmail.com",
            //    EmailConfirmed = true,
            //    BirthDay = DateTime.Now,
            //    FullName = "Technology Education"

            //};

            //manager.Create(user, "123654$");

            //if (!roleManager.Roles.Any())
            //{
            //    roleManager.Create(new IdentityRole { Name = "Admin" });
            //    roleManager.Create(new IdentityRole { Name = "User" });
            //}

            //var adminUser = manager.FindByEmail("traudat2212@gmail.com");

            //manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }
        private void CreateProductCategorySample(TrauDatShop.Data.TrauDatShopDbContext context)
        {
            if (context.ProductCategories.Count() == 0) {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
            {
                new ProductCategory() { Name = "Điện lạnh", Alias="dien-lanh", Status=true },
                new ProductCategory() { Name = "Viễn thông", Alias="vien-thong", Status=true },
                new ProductCategory() { Name = "Đồ gia dụng", Alias="do-gia-dung", Status=true },
                new ProductCategory() { Name = "Mỹ phẩm", Alias="my-pham", Status=true },
            };
                context.ProductCategories.AddRange(listProductCategory);
                context.SaveChanges();
            }
            

        }
        private void CreateFooter(TrauDatShopDbContext context)
        {
            if (context.Footers.Count(x => x.ID == CommonConstants.DefaultFooterId) ==0)
            {
                string content = "";
            }
        }
        private void CreateSlide(TrauDatShopDbContext context)
        {
            if (context.Slides.Count() == 0)
            {
                List<Slide> listSlide = new List<Slide>()
                {
                    new Slide() {   Name = "Slide 1",DisplayOrder=1,Status=true,
                                    Url ="#",
                                    Image ="/Assets/client/images/bag.jpg",
                                    Content =@"<h2>FLAT 50% 0FF</h2>
                                    <label>FOR ALL PURCHASE <b>VALUE</b></label>
                                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et </p>
                                    <span class=""on-get"">GET NOW</span>" },
                    new Slide() {   Name = "Slide 2",DisplayOrder=2,Status=true,
                                    Url ="#",
                                    Image ="/Assets/client/images/bag1.jpg",
                                    Content =@"<h2>FLAT 50% 0FF</h2>
                                    <label>FOR ALL PURCHASE <b>VALUE</b></label>
                                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et </p>
                                    <span class=""on-get"">GET NOW</span>" },
                };
                context.Slides.AddRange(listSlide);
                context.SaveChanges();
            }
        }

        private void CreatePage(TrauDatShopDbContext context)
        {
            if(context.Pages.Count() == 0)
            {
                try { 
                var page = new Page()
                {
                    Name = "Giới thiệu",
                    Alias = "gioi-thieu",
                    Content = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.
                                Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.
                                Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Status = true        
                };
                context.Pages.Add(page);
                context.SaveChanges();
                }
                catch(DbEntityValidationException ex) {
                    foreach (var eve in ex.EntityValidationErrors)
                    {
                        Trace.WriteLine($"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation error.");
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Trace.WriteLine($"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
                        }
                    }

                }
            }
        }
        private void CreateContactDetail(TrauDatShopDbContext context)
        {
            if (context.ContactDetails.Count() == 0)
            {
                try
                {
                    var contactDetail = new TrauDatShop.Model.Models.ContactDetail()
                    {
                        Name = "Trâu Đất Shop",
                        Address = "Số 86B khóm 1 phường 8 TP Cà Mau",
                        Email =  "traudat2212@gmail.com",
                        Lat = 9.1737778,
                        Lng = 105.142239,
                        Phone = "01679995384",
                        Website = "http://traudatshop.com",
                        Other = "",
                        Status = true
                    };
                    context.ContactDetails.Add(contactDetail);
                    context.SaveChanges();
                }
                catch(DbEntityValidationException ex)
                {
                    foreach (var eve in ex.EntityValidationErrors)
                    {
                        Trace.WriteLine($"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation error.");
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Trace.WriteLine($"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
                        }
                    }

                }
            }
        }

    }
}
