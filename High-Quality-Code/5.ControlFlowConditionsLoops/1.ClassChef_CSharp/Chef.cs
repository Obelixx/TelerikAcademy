namespace _1.ClassChef_CSharp
{
    /// <summary>
    /// Sample Chef class - DONT USE IT!
    /// </summary>
    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();
            this.Peel(potato);
            this.Peel(carrot);
            this.Cut(potato);
            this.Cut(carrot);

            Bowl bowl = this.GetBowl();
            bowl.Add(potato);
            bowl.Add(carrot);
        }

        public Bowl Cook(Vegetable vegetable)
        {
            this.Peel(vegetable);
            this.Cut(vegetable);
            Bowl bowl = this.GetBowl();
            bowl.Add(vegetable);
            return bowl;
        }

        private void Peel(Vegetable vegetable)
        {
            vegetable.Peel = false; 
        }

        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private void Cut(Vegetable vegetable)
        {
            vegetable.Whole = false;
        }
    }
}