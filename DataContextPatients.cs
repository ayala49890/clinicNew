using clinic.Entities;

namespace clinic
{
    public class DataContextPatients : IDataContextPatients
    {
        public List<Patient> Patients { get; set ; }

        public DataContextPatients()
        {
             Patients = new List<Patient> { new Patient { Id =1,Name="Moshe Levi",Status=true},
                                                          new Patient { Id =2,Name="Yosef Cohen",Status=true},
                new Patient { Id =3,Name="Yael David",Status=true}};


    }
}
}
