using System;
using System.Globalization;
using System.Text.Json.Serialization;

namespace Qubs.Models.Patient
{
    public class Patient : BaseModel
    {
        public string CompanyName { get; set; }
        public bool AccessGranted { get; set; }
        public string PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string MobilePhone { get; set; }

        [JsonIgnore]
        public DateTime? DateOfBirthAsDateTime
        {
            get
            {
                if (string.IsNullOrWhiteSpace(DateOfBirth) == false)
                {
                    var provider = CultureInfo.InvariantCulture;
                    return DateTime.ParseExact(DateOfBirth, "dd-MM-yyyy", provider);
                }

                return null;

            }
        }
    }
}
