using System;

namespace Project_Euler_Problems.Problems
{
    public class P008
    {
        /* Problem 8
         * Largest product in a series
         * The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.
         * Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?
         */
        public static void Start()
        {
            P008 p8 = new P008();
            string giantNumber =
                "73167176531330624919225119674426574742355349194934969835203127745063262395783180169848018694788518" +
                "43858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304" +
                "35576689664895044524452316173185640309871112172238311362229893423380308135336276614282806444486645" +
                "23874930358907296290491560440772390713810515859307960866701724271218839987979087922749219016997208" +
                "88093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441" +
                "57221553975369781797784617406495514929086256932197846862248283972241375657056057490261407972968652" +
                "41453510047482166370484403199890008895243450658541227588666881164271714799244429282308634656748139" +
                "19123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421" +
                "75069416589604080719840385096245544436298123098787992724428490918884580156166097919133875499200524" +
                "06368991256071760605886116467109405077541002256983155200055935729725716362695618826704282524836008" +
                "23257530420752963450";
            p8.ThirteenDigitsWithGreatestProduct(giantNumber);
        }

        private void ThirteenDigitsWithGreatestProduct(string giantNumber)
        {
            long largestProduct = 0;
            string largestProductSection = "";

            for (int i = 0; i < giantNumber.Length - 13; i++)
            {
                long productOfDigits = 1;
                string section = giantNumber.Substring(i, 13);

                foreach (char num in section)
                {
                    productOfDigits *= int.Parse(num.ToString());
                }

                if (productOfDigits > largestProduct)
                {
                    Console.WriteLine(
                        $"Previous Product: {largestProduct} \n Previous Section: {largestProductSection}");
                    largestProduct = productOfDigits;
                    largestProductSection = section;
                }
            }

            Console.WriteLine(
                $"The largest product of thirteen digits is: {largestProduct} \n The section was: {largestProductSection}");
        }
    }
}