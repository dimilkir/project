
namespace App10
{
    class Safe
    {
        Jewels contents = new Jewels();
        string safeCombination = "12345";

        public Jewels Open(string combination)
        {
            if (combination == safeCombination)
            {
                return contents;
            } 
            else
            {
                return null;
            }
        }

        public void PickLock(Locksmith lockpicker)
        {
            lockpicker.WriteDownCombination(safeCombination);
        }
    }
}
