public class Personel
{
    public int Id { get; set; }
    public string Ad { get; set; }


    // Ctor!!!
    public Personel()
    {
        // bu blok ,nesne bellege çıkarken, 
    }

    ~Personel()
    {
    // nesne bellekten silinirken çalışan metottur
    // nesne bellekten düşerken yapılacak işler için kullanılır!!!

    // c# da bellek yönetimi : 

    // Garbage Collector : Çöp toplayıcı bellek temizleme aracı var
    // bu çöp toplayısı  : belirli zamanlarda ve yazılımın bellege ihtiyacı olduğu anlarda
    // bellekte temizlik yapmaktadır!!!!

    // C# da çöp toplanyıcısı : hiç bir pointer tarafından işaret edilmeyen nesneleri temizler!!
    Console.WriteLine("Temizlendi");



    }

    // OLEDB!!
}
