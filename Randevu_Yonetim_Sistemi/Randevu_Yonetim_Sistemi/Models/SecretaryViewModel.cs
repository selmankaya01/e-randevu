﻿using Randevu_Yonetim_Sistemi.Data.Entity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Randevu_Yonetim_Sistemi.Models
{
    public class SecretaryViewModel
    {
        public AppUser User { get; set; }
        public IEnumerable<AppUser> Dentists { get; set; }
        public List<SelectListItem> DentistsSelectList { get; internal set; }
    }
}
