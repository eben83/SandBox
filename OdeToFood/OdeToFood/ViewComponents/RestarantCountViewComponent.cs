using System;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Data;

namespace OdeToFood.ViewComponents
{
    public class RestarantCountViewComponent
        : ViewComponent
    {
        private readonly IRestaurantData restrantData;

        public RestarantCountViewComponent(IRestaurantData restrantData) 
        {
            this.restrantData = restrantData;
        }

        public IViewComponentResult Invoke()
        {
            var count = restrantData.GetCountOfRestarants();
            return View(count);
        }
    }
}
