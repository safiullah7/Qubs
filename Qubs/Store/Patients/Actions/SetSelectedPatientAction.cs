using Qubs.Models.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qubs.Store.Patients.Actions
{
    public class SetSelectedPatientAction
    {
        public SetSelectedPatientAction(Patient patient)
        {
            Patient = patient;
        }

        public Patient Patient { get; }
    }
}
