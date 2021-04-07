using Fluxor;
using Microsoft.Extensions.Logging;
using Qubs.Models.Patient;
using Qubs.Services;
using Qubs.Store.Patients.Actions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Qubs.Store.Patients.Effects
{
    public class LoadPatientsEffect : Effect<LoadPatientsAction>
    {
        private readonly CustomHttp http;
        private readonly ILogger<LoadPatientsEffect> logger;

        public LoadPatientsEffect(CustomHttp http, ILogger<LoadPatientsEffect> logger)
        {
            this.http = http;
            this.logger = logger;
        }

        public async override Task HandleAsync(LoadPatientsAction action, IDispatcher dispatcher)
        {
            try
            {
                await Task.Delay(1000);
                //var response = await http.GetListAsync<Response<List<ShippingNotification>>>("/api/v1/ShippingNotification/shippingnotification");
                //dispatcher.Dispatch(new LoadPatientsSuccessAction(response.Content));

                List<Patient> patients = new List<Patient>()
                {
                    new Patient
                    {
                        Domain = "",
                        Sk = "",
                        CompanyName = "Company Name",
                        PatientId = "pat id",
                        FirstName = "pat fname",
                        LastName = "pat lname",
                        DateOfBirth = "28-10-1994",
                        Gender = "Male",
                        MobilePhone = "65487954654"
                    },
                    new Patient
                    {
                        Domain = "",
                        Sk = "",
                        CompanyName = "Company Name",
                        PatientId = "pat 2 id",
                        FirstName = "pat 2 fname",
                        LastName = "pat 2 lname",
                        DateOfBirth = "28-10-1994",
                        Gender = "Female",
                        MobilePhone = "65487954654"
                    },
                    new Patient
                    {
                        Domain = "",
                        Sk = "",
                        CompanyName = "Company Name",
                        PatientId = "pat 3 id",
                        FirstName = "pat 3 fname",
                        LastName = "pat 3 lname",
                        DateOfBirth = "28-10-1994",
                        Gender = "Male",
                        MobilePhone = "65487954654"
                    }
                };
                logger.LogInformation("About to call success action with list:" + patients.Count);
                dispatcher.Dispatch(new LoadPatientsSuccessAction(patients));
            }
            catch (Exception ex)
            {
                dispatcher.Dispatch(new LoadPatientsFailureAction(ex.Message));
            }
        }
    }
}
