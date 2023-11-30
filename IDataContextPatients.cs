using clinic.Entities;

namespace clinic
{
    public interface IDataContextPatients
    {
        
        List<Patient> Patients { get; set; }
 
    }
}
