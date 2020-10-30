namespace domain.common
{
	public class Attributes
	{
		public int Vitality { get; set; }
		public int Strength { get; set; }
		public int Dexterity { get; set; }
		public int Knowledge { get; set; }

		public int HealthPoints => 100 * (Vitality / 10);
		public int ActionPoints => 20 * (Dexterity / 10);
		public int PhysicalAttackPoints => 50 * (Strength / 10);
		public int PhysicalDefensePoints => 30 * (Strength / 10);
		public int MagicalAttackPoints => 50 * (Knowledge / 10);
		public int MagicalDefensePoints => 30 * (Knowledge / 10);
	}
}
