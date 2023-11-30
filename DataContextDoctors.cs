using clinic.Entities;

namespace clinic
{
    public class DataContextDoctors
    {
        public List<Doctor> Doctors { get; set; }
        public DataContextDoctors()
        {
           Doctors = new List<Doctor> { new Doctor { Id =1,Name="Shakom Levi",Status=true},
                                                                 new Doctor { Id =2,Name="Yosef Cohen",Status=true},
                                                                 new Doctor { Id =3,Name="Yael Ben-David",Status=true}};

        }
    }
}
