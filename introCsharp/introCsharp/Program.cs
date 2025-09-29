namespace introCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba, Dünya");

            /*
             * primitive -> ilkel
             * complex -> karmaşık
             */

            /*
             * -sayısal
             * -sözel
             * -mantıksal
             */

            //sayısal
            //tam sayılar
            byte maxByte = 255;
            sbyte maxSByte = 127;

            short maxShort = 32767;
            ushort maxUShort = 65535;

            int defaultInteger = 565;
            uint dUint = 6524;

            long veryBigNumber = 2122121545445454;
            ulong bigThanBigNumber = 454545455454;

            //ondalıklı sayılar:
            double pi = 3.14;
            float fPi = 3.14f;
            decimal dPi = 0.000000000000000000000000000000001M;

            //Sözel
            char letter = '*';
            string companyName = "Türk Telekom";
            String company2 = "Bişey";

            Console.WriteLine(companyName);

            



        }
    }
}
