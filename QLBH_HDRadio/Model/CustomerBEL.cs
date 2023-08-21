using System;

namespace QLBH_HDRadio.Model
{
    internal class CustomerBEL
    {
        public int Mahang { get; set; }
        public string Tenhang { get; set; }
        public LoaiBEL Loai { get; set; }
        public decimal Dongia { get; set; }
        public decimal Dongiakm { get; set; }
        public string Anh {get; set;}

        public string LoaiTenloai
        {
            get { return Loai.Tenloai; }
        }
    }
}
