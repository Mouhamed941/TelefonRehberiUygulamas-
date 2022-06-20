public class Kisi
{
    private string isim;
    private string soyisim;
    private string numara;

    public string Isim { get => isim; set => isim = value; }

    

    public string Soyisim { get => soyisim; set => soyisim = value; }
    public string Numara { get => numara; set => numara = value; }
    public Kisi(string isim, string soyisim, string numara)
        {
            Isim = isim;
            Soyisim = soyisim;
            Numara = numara;
        }
    public  Kisi(){

    }
}