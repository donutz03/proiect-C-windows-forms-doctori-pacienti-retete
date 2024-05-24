namespace _2_1056_HODOROAGA_IONUT.Entities
{
    public class Prescription
    {

        public int Id { get; set; }
        public int IdPacient {  get; set; }
        public string PacientName { get; set; }
        public int IdDoctor { get; set; }
        public string DoctorName{ get; set; }
        public string Description { get; set; }

    }

}
