namespace kalıtım
{
     public class Bitkiler:Canlılar
    {
        protected void FotosentezYapmak(){ 
            Console.WriteLine("Bitkiler Fotosentez Yapar.");
        }
        public override void UyaranlaraTepki()
        {
          //  base.UyaranlaraTepki();
            Console.WriteLine("Bitkiler güneşe tepki verir.");
        }
    }
    public class TohumluBitkiler:Bitkiler{ 
        public TohumluBitkiler(){ 
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
            
        }
        public void TohumlaCogalma(){ 
            Console.WriteLine("Tohumlu bitkiler Tohumla Çoğalır.");
        }
    }

    public class TohumsuzBitkiler:Bitkiler{
         public TohumsuzBitkiler(){ 
            base.FotosentezYapmak();
             base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            
            
        } 
       public void SporlaCogalma(){ 
            Console.WriteLine("Tohumsuz bitkiler sporla Çoğalır.");
        } 
    }
}        