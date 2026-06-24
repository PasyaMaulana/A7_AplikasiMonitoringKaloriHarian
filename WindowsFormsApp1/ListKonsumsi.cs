using System;

namespace AMKH
{
    public class ListKonsumsi
    {
        public string NamaItem { get; set; }
        public decimal Kalori { get; set; }
        public string Tipe { get; set; }
        public DateTime TanggalKonsumsi { get; set; }
        public decimal TargetKalori { get; set; }
    }
}