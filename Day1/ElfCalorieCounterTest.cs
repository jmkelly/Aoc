using Shouldly;

namespace Day1
{
    public class ElfCalorieCounterTest
    {
        [Theory]
        [InlineData(5, 24000, 4)]
        public void GivenStringInputTheElfCalorieCounterShouldReturnTheMaximium(int elves, int maximum, int position)
        {
            string input =
                @"
                        1000
                        2000
                        3000

                        4000

                        5000
                        6000

                        7000
                        8000
                        9000

                        10000";

            ElfCalorieCounter elfcalorieCounter = new(input);
            //var result = elfcalorieCounter.GetMaximum();
            elfcalorieCounter.Elves().Count.ShouldBe(elves);
            elfcalorieCounter.GetMaximumCalories().ShouldBe(maximum);
            elfcalorieCounter.GetMaximumElfPosition().ShouldBe(position);
        }
    }
}
