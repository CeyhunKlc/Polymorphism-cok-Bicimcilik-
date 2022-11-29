namespace kalıtım
{
    public class Hayvanlar:Canlılar
    {
        protected void Adaptasyon(){ 
            Console.WriteLine("Hayvanlar Adaptasyon Kurabilir.");
        }

        public override void UyaranlaraTepki(){ 
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa tepki verir.");
        }
    }

    public class Sürüngenler:Hayvanlar{
        public Sürüngenler(){ 
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            

        }
        public void SürünerekHareketEderler(){ 
             Console.WriteLine("Sürüngenler sürünerek hareket eder.");
        }
    }

    public class Kuslar:Hayvanlar{ 

        public Kuslar(){ 
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
            
        }
        public void ucmak(){ 
             Console.WriteLine("Kuşlar uçar.");
        }
    }
}        