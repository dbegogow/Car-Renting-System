﻿using System;
using Xunit;
using FluentAssertions;
using MyTested.AspNetCore.Mvc;
using System.Collections.Generic;
using CarRentingSystem.Controllers;
using CarRentingSystem.Services.Cars.Models;

using static CarRentingSystem.Test.Data.Cars;
using static CarRentingSystem.WebConstants.Cache;

namespace CarRentingSystem.Test.Controllers
{
    public class HomeControllerTest
    {
        [Fact]
        public void IndexShouldReturnCorrectViewWithModel()
            => MyController<HomeController>
                .Instance(controller => controller
                    .WithData(TenPublicCars()))
                .Calling(c => c.Index())
                .ShouldHave()
                .MemoryCache(cache => cache
                    .ContainingEntry(entry => entry
                        .WithKey(LatestCarsCacheKey)
                        .WithAbsoluteExpirationRelativeToNow(TimeSpan.FromMinutes(15))
                        .WithValueOfType<List<LatestCarServiceModel>>()))
                .AndAlso()
                .ShouldReturn()
                .View(view => view
                    .WithModelOfType<List<LatestCarServiceModel>>()
                    .Passing(model => model.Should().HaveCount(3)));

        [Fact]
        public void ErrorShouldReturnView()
            => MyController<HomeController>
                .Instance()
                .Calling(c => c.Error())
                .ShouldReturn()
                .View();
    }
}
