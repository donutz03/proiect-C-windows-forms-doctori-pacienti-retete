﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1056_HODOROAGA_IONUT.Entities
{
    [Serializable]
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }

    }

}
