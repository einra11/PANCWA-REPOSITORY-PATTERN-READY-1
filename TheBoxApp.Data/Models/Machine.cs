using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TheBoxApp.Data.Models
{
    public class Machine
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Ip { get; set; }
        public string? Mac { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public string? Status { get; set; }
        public string? Type { get; set; }
        public string? Os { get; set; }
        public string? OsVersion { get; set; }
        public string? OsArchitecture { get; set; }
        public string? OsSerialNumber { get; set; }
        public string? OsLicenseKey { get; set; }
        public string? OsLicenseExpDate { get; set; }
        public string? OsLicenseExpStatus { get; set; }
        public string? OsLicenseType { get; set; }
        public string? OsLicenseStatus { get; set; }
        public string? OsLicenseNotes { get; set; }
        public string? OsLicenseVendor { get; set; }
        public string? OsLicenseVendorContact { get; set; }
        public string? OsLicenseVendorEmail { get; set; }
        public string? OsLicenseVendorPhone { get; set; }
        public string? OsLicenseVendorWebsite { get; set; }
        public string? OsLicenseVendorNotes { get; set; }
        public string? OsLicenseVendorSupportExpDate { get; set; }
        public string? OsLicenseVendorSupportExpStatus { get; set; }
        public string? OsLicenseVendorSupportType { get; set; }
        public string? OsLicenseVendorSupportStatus { get; set; }
        public string? OsLicenseVendorSupportNotes { get; set; }
        public string? OsLicenseVendorSupportVendor { get; set; }
        public string? OsLicenseVendorSupportVendorContact { get; set; }
        public string? OsLicenseVendorSupportVendorEmail { get; set; }
        public string? OsLicenseVendorSupportVendorPhone { get; set; }
        public string? OsLicenseVendorSupportVendorWebsite { get; set; }
        public string? OsLicenseVendorSupportVendorNotes { get; set; }
        public string? OsLicenseVendorSupportVendorSupportExpDate { get; set; }
        public string? OsLicenseVendorSupportVendorSupportExpStatus { get; set; }
        public string? OsLicenseVendorSupportVendorSupportType { get; set; }
        public string? OsLicenseVendorSupportVendorSupport { get; set; }

        public MachineDashBoardProperties? MachineDashBoardProperties { get; set; }
    }

    public class MachineDashBoardProperties 
    {
        public int id { get; set; }
        [Required]
        [Column(TypeName = "jsonb")]
        public string? context { get; set; }

    }
}
