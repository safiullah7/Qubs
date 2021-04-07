using System;

namespace Qubs.Models.Filter
{
    public class PatientFilter
    {
        public string Accession { get; set; }
        public string PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string StudyDate { get; set; }
        public string Description { get; set; }
    }
}
