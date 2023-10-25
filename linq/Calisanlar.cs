internal class Calisanlar
{
    public Calisanlar()
    {
    }

    public int cal_id { get; set; }
    public string cal_ad { get; set; }
    public int cal_maas { get; internal set; }
    public string cal_cinsiyet { get; internal set; }
    public int cal_is_tarihi { get; internal set; }
}