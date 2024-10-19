

Personel  p  = new Personel();
p.Ad="Rıza";


// pointer ile nesnenin bağlantısını keselim!!!
p=null;
// artık nesne ile p arasındaki bağlantı kesildi ve p isimli pointer artık yok!!!

// Garbage Collector : Hiç bir pointer tarafınsan işaret edilmeyen nesneleri toplar demiştik
// şu anda ilk bellek ihtiyacında sıraya göre pointer tarafından işaret edilmeyen nesneler toplanacka
// ve yeni bellek alanları açılacaktır!!
// Garbage collector : manuel olarak devreye sokulsa da manuel çalıştırmak önerilmez
//  Garbage Collector 
GC.Collect();

// destructor : Garbage Collector'un belleği silme aşamasında, çalışan bir yapıdır!! 
// nesne bellekten düşerken, en son olarak yapılacak işler
// veri tabanı bağlantıları
// dosya bağlantıları vb gibi şeyleri kapatmak için kullanılır!!