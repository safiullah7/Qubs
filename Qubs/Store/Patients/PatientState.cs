using Fluxor;
using Qubs.Models.Patient;
using System.Collections.Generic;

namespace Qubs.Store.Patients
{
    public record PatientState
    {
        public string ErrorMessage { get; set; }
        public bool IsLoadingPatientList { get; set; }
        public List<Patient> Patients { get; set; }
    }

    public class PatientStateFeature : Feature<PatientState>
    {
        public override string GetName() => nameof(PatientState);

        protected override PatientState GetInitialState()
        => new PatientState
        {
            ErrorMessage = null,
            IsLoadingPatientList = false,
            Patients = null
        };
    }
}
