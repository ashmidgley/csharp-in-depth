using static System.Math;

namespace PrimeLibrary
{
    public class PrimeService
    {
        public bool isPrime(int candidate) 
        {
            if(candidate < 2)
                return false;
            for(int i = 2; i <= Sqrt(candidate); i++) {
                if(candidate % i == 0)
                    return false;
            }
            return true;
        }
    }
}
