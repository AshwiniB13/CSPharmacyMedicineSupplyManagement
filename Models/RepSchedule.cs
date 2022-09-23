using System;
using System.Collections.Generic;

#nullable disable

namespace CSPharmacyMedicineSupplyManagement.Models
{
    public partial class RepSchedule
    {
        public int Rsid { get; set; }
        public string Name { get; set; }
        public string Doctorname { get; set; }
        public string MeetingSlot { get; set; }
        public DateTime? DateOfMeeting { get; set; }
        public string DoctorContactNumber { get; set; }
        public string TreatingAilment { get; set; }
        public string Medicine { get; set; }
    }
}
