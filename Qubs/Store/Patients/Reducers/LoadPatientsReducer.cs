using Fluxor;
using Qubs.Models.Patient;
using Qubs.Store.Patients.Actions;
using System.Collections.Generic;

namespace Qubs.Store.Patients.Reducers
{
    public static class LoadPatientsReducer
    {
        [ReducerMethod]
        public static PatientState OnLoadPatients(PatientState state, LoadPatientsAction _)
        {
            return state with
            {
                IsLoadingPatientList = true
            };
        }

        [ReducerMethod]
        public static PatientState OnLoadSuccess(PatientState state, LoadPatientsSuccessAction action)
        {
            return state with
            {
                IsLoadingPatientList = false,
                Patients = action.Patients
            };
        }

        [ReducerMethod]
        public static PatientState OnLoadPatientsFailure(PatientState state, LoadPatientsFailureAction action)
        {
            return state with
            {
                IsLoadingPatientList = false,
                ErrorMessage = action.Error
            };
        }
    }
}
