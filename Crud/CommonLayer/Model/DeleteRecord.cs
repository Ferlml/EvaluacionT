﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.CommonLayer.Model
{
    public class DeleteRecordRequest
    {
        public int Id { get; set; }
    }

    public class DeleteRecordResponse
    {
        public bool IsSuccess { get; set; }
        public string Mensaje { get; set; }
    }
}
