using Qubs.Models.Patient;
using System.Collections.Generic;

namespace Qubs.Store.Patients.Actions
{
    public class LoadPatientsAction
    {
    }

    public class LoadPatientsSuccessAction
    {
        public LoadPatientsSuccessAction(List<Patient> patients)
        {
            Patients = patients;
        }

        public List<Patient> Patients { get; }
    }

    public class LoadPatientsFailureAction
    {
        public LoadPatientsFailureAction(string error)
        {
            Error = error;
        }

        public string Error { get; }
    }
}
