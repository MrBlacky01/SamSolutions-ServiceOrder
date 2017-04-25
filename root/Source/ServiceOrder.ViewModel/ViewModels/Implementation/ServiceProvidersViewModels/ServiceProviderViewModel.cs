﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ServiceOrder.ViewModel.ViewModels.Implementation.RegionViewModels;
using ServiceOrder.ViewModel.ViewModels.Implementation.ServiceTypeViewModels;

namespace ServiceOrder.ViewModel.ViewModels.Implementation.ServiceProvidersViewModels
{
    public class ServiceProviderViewModel
    {
        public string Id { get; set; }
        
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Discription")]
        public string Description { get; set; }

        [Display(Name = "Services")]
        public List<ServiceTypeViewModel> Services { get; set; }
        
        [Display(Name = "Services")]       
        public List<RegionEntityViewModel> Regions { get; set; }
    }

    public class ProviderRegion
    {
        public int Id { get; set; }
        
        [Display(Name = "Region")]
        public string Title { get; set; }
    }

    public class ServiceShortViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
    }
}
