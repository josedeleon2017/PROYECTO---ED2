using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CHAT___Algorithms
{
    public class DiffieHellman
    {
        public BigInteger GeneratorNumber => 20;
        public BigInteger PrimeNumber => 97;


        public int GetPublicKey(int private_key)
        {
            BigInteger key_ToPower = NumberToPower(GeneratorNumber, private_key);
            BigInteger result = key_ToPower % PrimeNumber;
            return (Int32)(result);
        }
        public int GetCommonKey(int public_key, int private_key)
        {
            BigInteger key_ToPower = NumberToPower(public_key, private_key);
            BigInteger result = key_ToPower % PrimeNumber;
            return (Int32)(result);
        }

        private BigInteger NumberToPower(BigInteger base_number, BigInteger power_number)
        {
            if (power_number == 0)
            {
                return 1;
            }
            else
            {
                if (power_number == 1)
                {
                    return base_number;
                }
                else
                {
                    return base_number * NumberToPower(base_number, power_number - 1);
                }
            }
        }
    }
}
