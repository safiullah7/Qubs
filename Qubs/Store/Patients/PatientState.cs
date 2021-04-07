using Fluxor;
using Qubs.Models.Patient;
using System.Collections.Generic;

namespace Qubs.Store.Patients
{
    public record PatientState
    {
        public string ErrorMessage { get; init; }
        public bool IsLoadingPatientList { get; init; }
        public List<Patient> Patients { get; init; }
        public Patient SelectedPatient { get; init; }
    }

    public class PatientStateFeature : Feature<PatientState>
    {
        public override string GetName() => nameof(PatientState);

        protected override PatientState GetInitialState()
        => new PatientState
        {
            ErrorMessage = null,
            IsLoadingPatientList = false,
            Patients = null,
            SelectedPatient = null
        };
    }
}
