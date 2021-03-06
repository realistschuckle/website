using System.Collections.Generic;
using Hdnug.Domain.Data.Models;

namespace Hdnug.Web.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Meeting> Meetings { get; set; }
        public IEnumerable<Image> SliderImages { get; set; }
    }
}