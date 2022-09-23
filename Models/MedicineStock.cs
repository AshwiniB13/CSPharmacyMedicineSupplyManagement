using System;
using System.Collections.Generic;

#nullable disable

namespace CSPharmacyMedicineSupplyManagement.Models
{
    public partial class MedicineStock
    {
        public int Msid { get; set; }
        public string MedicineName { get; set; }
        public string ChemicalComposition { get; set; }
        public string TargetAilment { get; set; }
        public DateTime? DateOfExpiry { get; set; }
        public int? NumberOfTabletsInStock { get; set; }
    }
}
