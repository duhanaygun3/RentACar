﻿using RentACar.Models.Entities.Concreate;

namespace RentACar.DTOs.Response
{
    public class GetCarModelByIdResponse
    {
        public int id { get; set; }

        public string name { get; set; }


        public int brandId { get; set; }

        //public Brand brand { get; set; }
    }
}
