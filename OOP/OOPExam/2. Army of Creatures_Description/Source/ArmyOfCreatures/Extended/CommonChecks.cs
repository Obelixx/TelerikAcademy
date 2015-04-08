namespace ArmyOfCreatures.Extended
{
    using System;

    public static class CommonChecks
    {

        public static void CheckForNull(object obj, string massage = null)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(massage);
            }
        }
        
    }
}
