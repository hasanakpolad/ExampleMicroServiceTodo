﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMicroServiceUser.DataAccess.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurNmae { get; set; }
        public string Role { get; set; }
    }
}
