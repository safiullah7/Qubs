using Qubs.Models;
using Qubs.Store.Counter;
using Fluxor;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Qubs.Store.Patients.Actions;

namespace Qubs.Services
{
    public class StateFacade
    {
        private readonly IDispatcher dispatcher;
        private readonly ILogger<StateFacade> logger;
        private readonly CustomHttp http;

        public StateFacade(IDispatcher dispatcher, ILogger<StateFacade> logger, CustomHttp http)
        {
            this.dispatcher = dispatcher;
            this.logger = logger;
            this.http = http;
        }

        public void AddCounter(int count)
        {
            logger.LogInformation("Dispatched AddCounter action");
            dispatcher.Dispatch(new AddCounter(count));
        }

        public void LoadPatients()
        {
            logger.LogInformation("Dispatched LoadPatients action");
            dispatcher.Dispatch(new LoadPatientsAction());
        }
    }
}
