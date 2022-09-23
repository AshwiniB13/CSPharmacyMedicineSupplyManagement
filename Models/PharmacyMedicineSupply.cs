using System;
using System.Collections.Generic;

#nullable disable

namespace CSPharmacyMedicineSupplyManagement.Models
{
    public partial class PharmacyMedicineSupply
    {
        public int Pmsid { get; set; }
        public string PharmacyName { get; set; }
        public string MedicineName { get; set; }
        public int? SupplyCount { get; set; }
    }
}
