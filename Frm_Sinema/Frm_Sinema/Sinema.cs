using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frm_Sinema
{
    class Sinema
    {
        int toplamKoltukSayısı;
        int bosKoltukSayisi;
        double bakiye;
        string solanNo;

        double TAM = 15.0;
        double INDIRIMLI = 10.0;

       
       public Sinema(string salonn,int koltuksayi)
        {
            toplamKoltukSayısı = koltuksayi;
            solanNo = salonn;
            bosKoltukSayisi = toplamKoltukSayısı;
            bakiye = 0;

        }
        public void BiletSat(bool indirimli) //bilet satiş Bir bilet satar ve bu işlem sonrası bir koltuk sayısını azaltır ve bakiyeyi arttırır.
        {
            bosKoltukSayisi--;
            if (indirimli)
                bakiye += INDIRIMLI;
            else
                bakiye += TAM;
        }
        public void BiletIptal(bool indirimli)//bilet iade
        {
            bosKoltukSayisi++;
            if (indirimli)
                bakiye -= INDIRIMLI;
            else
                bakiye -= TAM;
        }
        public int BosKoltukOgren()//boş koltuk sayısı
        {
            return bosKoltukSayisi;
        }
        public double BakiyeOgren()//bakiye öğren
        {
            return bakiye;
        }
    }
}