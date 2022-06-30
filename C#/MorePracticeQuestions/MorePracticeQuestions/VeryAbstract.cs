using System;
namespace MorePracticeQuestions
{
    public abstract class VeryAbstract
    {
        public VeryAbstract()
        {
        }

        public static float CalculateWattage(int voltage, float current)
        {
            return (float)voltage * current;
        }
    }
}
