    public class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        // add a public "getter" property to access health
        public int Health
        {
            get { return health; }
        }

        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string nam)
        {
            Name = nam;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        // Add a constructor to assign custom values to all fields
        public Human(string nam, int stg, int intel, int dex, int hlt)
        {
            Name = nam;
            Strength = stg;
            Intelligence = intel;
            Dexterity = dex;
            health = hlt;
        }
        public Human(string nam, int intel, int dex, int hlt)
        {
            Name = nam;
            Strength = 0;
            Intelligence = intel;
            Dexterity = dex;
            health = hlt;
        }




        // Build Attack method
        public virtual int Attack(Human target)
        {
            int dmg = Strength * 5;
            target.health -= dmg;
            return target.health;
        }
    }