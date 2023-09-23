using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVNwin.Models
{
    public class OrderIDsViewModel
    {
        public int? ID { get; set; }
        public readonly List<SelectListItem> OrderIdSelectedList;
        public OrderIDsViewModel(List<int> orderIds)
        {
            OrderIdSelectedList = new List<SelectListItem>();
                foreach(var no in orderIds)
            {
                OrderIdSelectedList.Add(new SelectListItem { Text = $"{no}", Value = $"{no}" });
            }
        }
    }
}
