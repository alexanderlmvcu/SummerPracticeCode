public class Dog 
{
   private readonly IMakeALoudNoise _noiseMaker;

   public Dog(IMakeALoudNoise noiseMaker){
       _noiseMaker = noiseMaker;
   }

   public string MakeNoise(){
       return _noiseMaker.MakeALoudNoise();
   }
}