public class Bear 
{
   private readonly IMakeALoudNoise _noiseMaker;

   public Bear(IMakeALoudNoise noiseMaker){
       _noiseMaker = noiseMaker;
   }

   public string MakeNoise(){
       return _noiseMaker.MakeALoudNoise();
   }
}