using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2_1056_HODOROAGA_IONUT.Entities
{

    [Serializable]
    public class Prescription
    {
        public int Id { get; set; }
        public int IdPacient {  get; set; }
        public string Pacient { get; set; }
        public int IdDoctor { get; set; }
        public string Doctor{ get; set; }
        public string Description { get; set; }

    }

}
