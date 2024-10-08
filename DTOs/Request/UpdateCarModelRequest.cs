﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using RentACar.Models.Entities.Concreate;

namespace RentACar.DTOs.Request
{
    public class UpdateCarModelRequest
    {
        public int id {  get; set; }
        public string name { get; set; }

        public int brandId { get; set; }

        [ValidateNever]
        public string PictureUrl { get; set; }
    }
}
