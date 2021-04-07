using Fluxor;
using Qubs.Store.Patients.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qubs.Store.Patients.Reducers
{
    public static class SetSelectedPatientReducer
    {
        [ReducerMethod]
        public static PatientState OnSetSelectedPatientReducer(PatientState state, SetSelectedPatientAction action)
        {
            return state with
            {
                SelectedPatient = state.Patients.First(x => x.Domain == action.Patient.Domain && x.Sk == action.Patient.Sk)
            };
        }
    }
}
