using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCevap.Enabled = false;
            txtSoru.Enabled = false;
            MessageBox.Show("Merhaba Passaparola yarışmasına hoşgeldiniz. Soruları cevaplamak için 15 saniye süreniz vardır. Cevap kutucuğuna cevapları küçük harflerle yazıp 'ENTER' tuşuna basınız. Bir sonraki soruya geçmek için de 'Sonraki' butonuna tıklayın. BAŞARILAR! ","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
        int sayac = 16;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            BtnCenter.Text = sayac.ToString();
            if (sayac == 0)
            {
                timer1.Stop();
                sayac = 16;
                txtCevap.Enabled = false;
                BtnCevapla.Enabled = true;
                MessageBox.Show("Süreniz bitmiştir lütfen diğer soruya geçiniz.","Süre Bitti",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void BtnPas_Click(object sender, EventArgs e)
        {
           
            timer1.Stop();
            sayac = 16;
            timer1.Start();
            
            BtnCevapla.Enabled = false;
            txtCevap.Enabled = true;
            soruno++;
            txtCevap.Text = "";
            groupBox1.Text = "SORU " + soruno.ToString();
            if (soruno == 1)
            {
                txtSoru.Text = "Kahramanmaraş hangi bölgede yer alır?";
                BtnA.BackColor = Color.Yellow;
            }
            if (soruno == 2)
            {
                txtSoru.Text = "Misketin diğer adı nedir?";
                btnB.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                txtSoru.Text = "Robinson Crusoe'nun adada karşılaştığı yerliye taktığı isim nedir?";
                BtnC.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                txtSoru.Text = "Belirli bir amacı gerçekleştirmek için kurulan yasal topluluk nedir?";
                BtnD.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                txtSoru.Text = "Yeni kelimesinin zıttı nedir?";
                BtnE.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                txtSoru.Text = "Kuzey Afrika'da bir ülke";
                BtnF.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                txtSoru.Text = "Çocuk değil, yaşlı değil. Yaşlı ve gencin ortası nedir?";
                BtnG.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                txtSoru.Text = "Karadenizde çok tüketilen bir balık türü";
                BtnH.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                txtSoru.Text = "Uzak anlamına gelen bir sıfat?";
                BtnI.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                txtSoru.Text = "Eti yenilen bir çiftlik hayvanı?";
                Button_i.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                txtSoru.Text = "Uzak doğu Asya'da bir ülke, Kore'nin komşusu?";
                btnJ.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                txtSoru.Text = "İnsanların kitap okuduğu , kitap aldığı yer neresidir?";
                btnK.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                txtSoru.Text = "Misket limonunun diğer adı nedir?";
                BtnL.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                txtSoru.Text = "Orta Doğu'da, Dicle ve Fırat nehirleri arasında kalan; günümüzde Irak, kuzeydoğu Suriye, Güneydoğu Anadolu Bölgesi ve güneybatı İran topraklarından oluşan bölge?";
                BtnM.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                txtSoru.Text = "Kişinin kendi görüşlerini belirtmeyen, herkese göre aynı olan ifade nedir?";
                BtnN.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                txtSoru.Text = "Öğrencilerin haftada 5 gün gittiği yer neresidir?";
                BtnO.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                txtSoru.Text = "Kızartması yapılan insanların genelde sevdiği kahverengi sebze nedir?";
                BtnP.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                txtSoru.Text = "Bilim kurgu filmlerinde dünyayı ele geçiren insansı makineler?";
                BtnR.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                txtSoru.Text = "Haftanın bir günü?";
                BtnS.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                txtSoru.Text = "Yumurtlayan, eti tüketilen bir çiftlik hayvanı?";
                BtnT.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                txtSoru.Text = "Hatırlamamak anlamına gelen bir fiil?";
                BtnU.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                txtSoru.Text = "Türkiye'de kedisi meşhur bir şehir?";
                BtnV.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                txtSoru.Text = "Güney yarıkürede Aralık,Ocak,Şubat aylarını içeren mevsim?";
                BtnY.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                txtSoru.Text = "Siyah beyaz çizgili bir hayvan?";
                BtnZ.BackColor = Color.Yellow;
            }

            if (soruno == 25)
            {
                soruno = 0;
                MessageBox.Show("Yarışma sonra ermiştir. Toplam doğru sayınız: " + LblDogru.Text + " Toplam yanlış sayınız: " + LblYanlis.Text);
            }

        }

        private void txtCevap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Stop();
                sayac = 16;
                
                switch (soruno)
                {
                    case 1:
                        if (txtCevap.Text == "akdeniz")
                        {
                            BtnA.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                            
                        }
                        else
                        {
                            BtnA.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;

                        }
                        break;
                    case 2:
                        if (txtCevap.Text == "bilye")
                        {
                            btnB.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        else
                        {
                            btnB.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        break;
                    case 3:
                        if (txtCevap.Text == "cuma")
                        {
                            BtnC.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        else
                        {
                            BtnC.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        break;
                    case 4:
                        if (txtCevap.Text == "devlet")
                        {
                            BtnD.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        else
                        {
                            BtnD.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        break;
                    case 5:
                        if (txtCevap.Text == "eski")
                        {
                            BtnE.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        else
                        {
                            BtnE.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        break;
                    case 6:
                        if (txtCevap.Text == "fas")
                        {
                            BtnF.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        else
                        {
                            BtnF.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        break;
                    case 7:
                        if (txtCevap.Text == "genç")
                        {
                            BtnG.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        else
                        {
                            BtnG.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        break;
                    case 8:
                        if (txtCevap.Text == "hamsi")
                        {
                            BtnH.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        else
                        {
                            BtnH.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        break;
                    case 9:
                        if (txtCevap.Text == "ırak")
                        {
                            BtnI.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        else
                        {
                            BtnI.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        break;
                    case 10:
                        if (txtCevap.Text == "inek")
                        {
                            Button_i.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        else
                        {
                            Button_i.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        break;
                    case 11:
                        if (txtCevap.Text == "japonya")
                        {
                            btnJ.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        else
                        {
                            btnJ.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        break;
                    case 12:
                        if (txtCevap.Text == "kütüphane")
                        {
                            btnK.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        else
                        {
                            btnK.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        break;
                    case 13:
                        if (txtCevap.Text == "lime")
                        {
                            BtnL.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        else
                        {
                            BtnL.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        break;
                    case 14:
                        if (txtCevap.Text == "mezopotamya")
                        {
                            BtnM.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        else
                        {
                            BtnM.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        break;
                    case 15:
                        if (txtCevap.Text == "nesnel")
                        {
                            BtnN.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        else
                        {
                            BtnN.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        break;
                    case 16:
                        if (txtCevap.Text == "okul")
                        {
                            BtnO.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        else
                        {
                            BtnO.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        break;
                    case 17:
                        if (txtCevap.Text == "patates")
                        {
                            BtnP.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        else
                        {
                            BtnP.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        break;
                    case 18:
                        if (txtCevap.Text == "robot")
                        {
                            BtnR.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        else
                        {
                            BtnR.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        break;
                    case 19:
                        if (txtCevap.Text == "salı")
                        {
                            BtnS.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        else
                        {
                            BtnS.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        break;
                    case 20:
                        if (txtCevap.Text == "tavuk")
                        {
                            BtnT.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        else
                        {
                            BtnT.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        break;
                    case 21:
                        if (txtCevap.Text == "unutmak")
                        {
                            BtnU.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        else
                        {
                            BtnU.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        break;
                    case 22:
                        if (txtCevap.Text == "van")
                        {
                            BtnV.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        else
                        {
                            BtnV.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        break;
                    case 23:
                        if (txtCevap.Text == "yaz")
                        {
                            BtnY.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        else
                        {
                            BtnY.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        break;
                    case 24:
                        BtnCevapla.Text = "BİTİR";
                        if (txtCevap.Text == "zebra")
                        {
                            BtnZ.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        else
                        {
                            BtnZ.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            txtCevap.Enabled = false;
                            BtnCevapla.Enabled = true;
                        }
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BtnCevapla.Text = "Sonraki";
            timer1.Start();
            BtnCevapla.Enabled = false;
            txtCevap.Enabled = true;
            soruno++;
            txtCevap.Text = "";
            
            groupBox1.Text = "SORU " + soruno.ToString();
            if (soruno == 1)
            {
                txtSoru.Text = "Kahramanmaraş hangi bölgede yer alır?";
                BtnA.BackColor = Color.Yellow;
            }
            if (soruno == 2)
            {
                txtSoru.Text = "Misketin diğer adı nedir?";
                btnB.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                txtSoru.Text = "Robinson Crusoe'nun adada karşılaştığı yerliye taktığı isim nedir?";
                BtnC.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                txtSoru.Text = "Belirli bir amacı gerçekleştirmek için kurulan yasal topluluk nedir?";
                BtnD.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                txtSoru.Text = "Yeni kelimesinin zıttı nedir?";
                BtnE.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                txtSoru.Text = "Kuzey Afrika'da bir ülke";
                BtnF.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                txtSoru.Text = "Çocuk değil, yaşlı değil. Yaşlı ve gencin ortası nedir?";
                BtnG.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                txtSoru.Text = "Karadenizde çok tüketilen bir balık türü";
                BtnH.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                txtSoru.Text = "Uzak anlamına gelen bir sıfat?";
                BtnI.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                txtSoru.Text = "Eti yenilen bir çiftlik hayvanı?";
                Button_i.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                txtSoru.Text = "Uzak doğu Asya'da bir ülke, Kore'nin komşusu?";
                btnJ.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                txtSoru.Text = "İnsanların kitap okuduğu , kitap aldığı yer neresidir?";
                btnK.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                txtSoru.Text = "Misket limonunun diğer adı nedir?";
                BtnL.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                txtSoru.Text = "Orta Doğu'da, Dicle ve Fırat nehirleri arasında kalan; günümüzde Irak, kuzeydoğu Suriye, Güneydoğu Anadolu Bölgesi ve güneybatı İran topraklarından oluşan bölge?";
                BtnM.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                txtSoru.Text = "Kişinin kendi görüşlerini belirtmeyen, herkese göre aynı olan ifade nedir?";
                BtnN.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                txtSoru.Text = "Öğrencilerin haftada 5 gün gittiği yer neresidir?";
                BtnO.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                txtSoru.Text = "Kızartması yapılan insanların genelde sevdiği kahverengi sebze nedir?";
                BtnP.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                txtSoru.Text = "Bilim kurgu filmlerinde dünyayı ele geçiren insansı makineler?";
                BtnR.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                txtSoru.Text = "Haftanın bir günü?";
                BtnS.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                txtSoru.Text = "Yumurtlayan, eti tüketilen bir çiftlik hayvanı?";
                BtnT.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                txtSoru.Text = "Hatırlamamak anlamına gelen bir fiil?";
                BtnU.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                txtSoru.Text = "Türkiye'de kedisi meşhur bir şehir?";
                BtnV.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                txtSoru.Text = "Güney yarıkürede Aralık,Ocak,Şubat aylarını içeren mevsim?";
                BtnY.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                txtSoru.Text = "Siyah beyaz çizgili bir hayvan?";
                BtnZ.BackColor = Color.Yellow;
            }

            if (soruno == 25)
            {
                soruno = 0;
                MessageBox.Show("Yarışma sonra ermiştir. Toplam doğru sayınız: " + LblDogru.Text + " Toplam yanlış sayınız: " + LblYanlis.Text);
            }
        }
    }
}
