public class Cat 
{
   private readonly IMakeALoudNoise _noiseMaker;

   public Cat(IMakeALoudNoise noiseMaker){
       _noiseMaker = noiseMaker;
   }

   public string MakeNoise(){
       return _noiseMaker.MakeALoudNoise();
   }
}