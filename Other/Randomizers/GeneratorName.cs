namespace Learn1.Other.Randomizers
{
    public class GeneratorName : IGenerator<string>
    {
        public string Generate()
        {
            char[] vowel = { 'a', 'e', 'o', 'i' };
            char[] constantletters = { 'f','r','t','p','w'};
            return GenName(vowel, constantletters);
        }
        protected static string GenName(char[] vowel, char[] constantletters)
        {
            string retName = "";
            byte hardcounter = 0;
            for (int i = 0; i < Randomizer.RandNum(3, 8); i++)
            {
                if (hardcounter > 1 || Randomizer.RandNum(0, 3) != 0)
                {
                    retName += vowel[Randomizer.RandNum(0, vowel.Length)];
                    hardcounter = 0;
                }
                else
                {
                    retName += constantletters[Randomizer.RandNum(0, constantletters.Length)];
                    hardcounter++;
                }
                if (i == 0) { retName = retName.ToUpper(); }
            }
            return retName;
        }  
    }
}
