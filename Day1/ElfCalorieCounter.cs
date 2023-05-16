namespace Day1
{
    internal class ElfCalorieCounter
    {
        private readonly string input;

        public ElfCalorieCounter(string input)
        {
            this.input = input;
        }

        public List<Elf> Elves()
        {
            string[] splits = input.Split('\n');
            int counter = 0;
            List<Elf> elves = new();
            for (int i = 0; i < splits.Length; i++)
            {
                if (!string.IsNullOrEmpty(splits[i].Trim()))
                {
                    counter = counter
                        + Convert.ToInt32(splits[i].Trim());
                }
                else
                {
                    elves.Add(new Elf { Calories = counter });
                    counter = 0;
                }
            }
            return elves;
        }

        internal int GetMaximumCalories()
        {
            return Elves().Max(e => e.Calories);
        }

        internal int GetMaximumElfPosition()
        {
            List<Elf> elves = Elves();
            Elf elf = elves.First(e => e.Calories == GetMaximumCalories());

            return elves.IndexOf(elf);
        }
    }
}
