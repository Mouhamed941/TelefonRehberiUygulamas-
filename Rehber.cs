using System.Collections.Generic;
class Rehber
{
    List<Kisi> kisiRehberi = new List<Kisi>();

    public Rehber(){
        kisiRehberi.Add(new Kisi( "MOUHAMED","FARDOUSI","05375679354"));
        kisiRehberi.Add(new Kisi("HUSEİN","MAHSUN","05688895635"));
        kisiRehberi.Add(new Kisi("MOUHAMED","HAZEM","05395698795"));
        kisiRehberi.Add(new Kisi("MEHMET","ARPACIK","05458963124"));
        kisiRehberi.Add(new Kisi("ALİ","AKGÜ","05365461973"));
        
    }
    public void NumaraKaydet(){
        Kisi kisi = new Kisi();
        System.Console.WriteLine("  (1) Yeni Numara Kaydetmek : ");
        System.Console.WriteLine(" Lütfen isim giriniz             : ");
        kisi.Isim = Console.ReadLine();

        System.Console.WriteLine(" Lütfen soyisim giriniz          : ");
        kisi.Soyisim = Console.ReadLine();

        System.Console.WriteLine("Lütfen Numara giriniz     :   ");
        kisi.Numara = Console.ReadLine();

        kisiRehberi.Add(kisi);
        System.Console.WriteLine("yeni numara başarı ile eklendi.");
        System.Console.WriteLine(kisiRehberi[kisiRehberi.Count-1].Isim);
        System.Console.WriteLine(kisiRehberi[kisiRehberi.Count-1].Soyisim);
        System.Console.WriteLine(kisiRehberi[kisiRehberi.Count-1].Numara);
    }

    public void islemlerGörüntüle(){
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :");
            Console.WriteLine("  *******************************************  ");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak﻿");
        }

    public void NumaraSil(){
        bool bulundu = false;
        string silmeyeDevam = "2";
        while (silmeyeDevam == "2" )
        {
             System.Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:    ");
             string isimYadaSoyisim  = Console.ReadLine().Trim().ToUpper();
        
            foreach (var item in kisiRehberi)
                {
                    string[] isimVeSoyisimDizisi = new string[kisiRehberi.Count];
                    isimVeSoyisimDizisi = isimYadaSoyisim.Split(' ');
                    if (isimVeSoyisimDizisi[0] != null &&  isimVeSoyisimDizisi[1] !=null)
                    {
                        if (isimVeSoyisimDizisi[0]==item.Isim && isimVeSoyisimDizisi[1] == item.Soyisim)
                        {   
                            System.Console.WriteLine($"{item.Isim} {item.Soyisim} kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                            if (Convert.ToChar(Console.ReadLine().ToLower()) =='y')
                            {
                                kisiRehberi.RemoveAt(kisiRehberi.IndexOf(item));
                                System.Console.WriteLine($"{item.Isim} {item.Soyisim} kişi silindi");
                                silmeyeDevam = "1";
                                break;
                                bulundu = true;
                            }
                            else
                            {
                                continue;
                            }
                        
                        }
                        
                    }
                }
       
            if (bulundu)
            {
                //else if (isimVeSoyisimDizisi[0]!=item.Isim && isimVeSoyisimDizisi[1]!= item.Soyisim)
                        //{
                            System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                            System.Console.WriteLine("* Silmeyi sonlandırmak için : (1)");

                            System.Console.WriteLine("* Yeniden denemek için      : (2)");
                            silmeyeDevam = Console.ReadLine();
                            
                                
                        //}
            }
        }
    
    }


    public void NumaraGuncelle(){

        string guncellemeyeDevam = "2";
        while (guncellemeyeDevam=="2")
        {
            System.Console.WriteLine(" Lütfen numarasını guncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string guncellenecekIsim = Console.ReadLine().ToUpper();
            foreach (var item in kisiRehberi)
            {
                if ((kisiRehberi.IndexOf(item) == kisiRehberi.Count - 1) &&
                    !(guncellenecekIsim.ToUpper() == item.Isim.ToLower() ||
                    guncellenecekIsim.ToUpper() == item.Soyisim.ToLower()))
                {
                     System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                     System.Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");

                     System.Console.WriteLine("* Yeniden denemek için      : (2)");
                     guncellemeyeDevam = Console.ReadLine();
                }
                 else if (guncellenecekIsim.ToUpper() == item.Isim.ToUpper() ||
                    guncellenecekIsim.ToUpper() == item.Soyisim.ToUpper())
                    {

                        System.Console.WriteLine(item.Isim + " " + item.Soyisim + " : " + item.Numara + " kişi bilgileri güncellenmek üzere, onaylıyor musunuz ?(y/n)");

                        if (Convert.ToChar(Console.ReadLine()) == 'y')
                        {
                            System.Console.WriteLine("Lütfen güncel isim giriniz              : ");
                            item.Isim = Console.ReadLine();
                            System.Console.WriteLine("Lütfen güncel soyisim giriniz           : ");
                            item.Soyisim = Console.ReadLine();
                            System.Console.WriteLine("Lütfen güncel telefon numarası giriniz  : ");
                            item.Numara = Console.ReadLine();
                            System.Console.WriteLine(item.Isim + " " + item.Soyisim + " : " + item.Numara + " kişi olarak güncellendi");
                            //kisiKartiRehberi.RemoveAt(kisiKartiRehberi.IndexOf(item));
                            System.Console.WriteLine();
                            guncellemeyeDevam = "1";

                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
            }
             
        }
        
    }

    public void rehberiListelemek()
    {
        System.Console.WriteLine(" Rehber'de toplam " + kisiRehberi.Count + " adet kişi kartı vardır.");

            //rehberli listele
            foreach (var item in kisiRehberi)
            {
                System.Console.WriteLine(item.Isim + " " + item.Soyisim + " : " + item.Numara);

            }
    }

    public void aramaYap(){
        System.Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
        System.Console.WriteLine(" **********************************************");
        System.Console.WriteLine(" İsim veya soyisime göre arama yapmak için: (1)");
        System.Console.WriteLine(" Telefon numarasına göre arama yapmak için: (2)");
        string aramatipi = Console.ReadLine();
        if (aramatipi =="1")

        {
            System.Console.WriteLine(" İsim veya soyisime göre arama yapmak için isim ya da soyisim giriniz");

            string isimYaDaSoyisim = Console.ReadLine();
            foreach (var item in kisiRehberi)
                {
                    if ((kisiRehberi.IndexOf(item) == kisiRehberi.Count - 1) &&
                    !(isimYaDaSoyisim.ToUpper() == item.Isim.ToUpper() ||
                    isimYaDaSoyisim.ToUpper() == item.Soyisim.ToUpper()))
                    {

                        if (!kisiRehberi.Contains(item))
                            System.Console.WriteLine("Rehber sonuna gelindi, aradığınız krtiterlere uygun veri rehberde bulunamadı.");
                        else
                            System.Console.WriteLine("Rehber sonuna gelindi, aradığınız krtiterlere uygun başka veri rehberde bulunamadı.");
                    }
                    else if (isimYaDaSoyisim.ToUpper() == item.Isim.ToUpper() ||
                    isimYaDaSoyisim.ToUpper() == item.Soyisim.ToUpper())
                    {

                        System.Console.WriteLine("İsim: " + item.Isim + "\n Soyisim: " + item.Soyisim + "\n Telefon Numarası: " + item.Numara);

                    }


                }
        }

        else if (aramatipi == "2")
            {
                System.Console.WriteLine(" Telefon numarasına göre arama yapmak için telefon numarasını giriniz");

                string telefonNumarasi = Console.ReadLine();

                foreach (var item in kisiRehberi)
                {
                    if ((kisiRehberi.IndexOf(item) == kisiRehberi.Count - 1) &&
                    !(telefonNumarasi.ToLower() == item.Numara.ToLower()))
                    {
                        if (!kisiRehberi.Contains(item))
                            System.Console.WriteLine("Rehber sonuna gelindi, aradığınız krtiterlere uygun veri rehberde bulunamadı.");
                        else
                            System.Console.WriteLine("Rehber sonuna gelindi, aradığınız krtiterlere uygun başka veri rehberde bulunamadı.");

                    }
                    else if (telefonNumarasi.ToLower() == item.Numara.ToLower())
                    {

                        System.Console.WriteLine("İsim: " + item.Isim + "\n Soyisim: " + item.Soyisim + "\n Telefon Numarası: " + item.Numara);

                    }


                }
    }
    }
}