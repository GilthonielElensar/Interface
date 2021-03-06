using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate: Tüzel müşteri
    //miras:inheritance
    //Musteri de olan özellikler TuzelMusteri de de vardır 
    //TüzelMüşterinin ebeveyni Müsteri'dir
    class TuzelMusteri:Musteri  //tüzel müşteri bir müşteri demektir bu
    {
       
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
