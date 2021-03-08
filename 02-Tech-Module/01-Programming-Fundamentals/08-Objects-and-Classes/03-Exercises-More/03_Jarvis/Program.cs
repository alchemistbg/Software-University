using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Jarvis
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal energyCapacity = decimal.Parse(Console.ReadLine());

			string input = Console.ReadLine();

			Robot Jarvis = new Robot();

			while (input != "Assemble!")
			{
				string[] inputArr = input.Split(' ');

				//Creating the head
				if (inputArr[0] == "Head")
				{
					if (Jarvis.RobotHead == null)
					{
						Jarvis.RobotHead = new Head();
						Jarvis.RobotHead.EnergyConsumption = decimal.Parse(inputArr[1]); ;
						Jarvis.RobotHead.IQ = decimal.Parse(inputArr[2]); ;
						Jarvis.RobotHead.SkinMaterial = inputArr[3];
					}
					else
					{
						if (Jarvis.RobotHead.EnergyConsumption > decimal.Parse(inputArr[1]))
						{
							Jarvis.RobotHead.EnergyConsumption = decimal.Parse(inputArr[1]); ;
							Jarvis.RobotHead.IQ = decimal.Parse(inputArr[2]); ;
							Jarvis.RobotHead.SkinMaterial = inputArr[3];
						}
					}
				}

				//Creating the torso
				if (inputArr[0] == "Torso")
				{
					if (Jarvis.RobotTorso == null)
					{
						Jarvis.RobotTorso = new Torso();
						Jarvis.RobotTorso.EnergyConsumption = decimal.Parse(inputArr[1]); ;
						Jarvis.RobotTorso.ProcessorSize = double.Parse(inputArr[2]); ;
						Jarvis.RobotTorso.HousingMaterial = inputArr[3];
					}
					else
					{
						if (Jarvis.RobotTorso.EnergyConsumption > decimal.Parse(inputArr[1]))
						{
							Jarvis.RobotTorso.EnergyConsumption = decimal.Parse(inputArr[1]); ;
							Jarvis.RobotTorso.ProcessorSize = double.Parse(inputArr[2]); ;
							Jarvis.RobotTorso.HousingMaterial = inputArr[3];
						}
					}
				}

				//Creating the arms
				if (inputArr[0] == "Arm")
				{
					Arm arm = new Arm();
					arm.EnergyConsumption = decimal.Parse(inputArr[1]);
					arm.ReachDistance = decimal.Parse(inputArr[2]);
					arm.Fingers = decimal.Parse(inputArr[3]);

					if (Jarvis.RobotArms == null)
					{
						Jarvis.RobotArms = new List<Arm>();
					}

					if (Jarvis.RobotArms.Count < 2)
					{
						Jarvis.RobotArms.Add(arm);
					}
					else
					{
						if (Jarvis.RobotArms[0].EnergyConsumption > arm.EnergyConsumption || Jarvis.RobotArms[1].EnergyConsumption > arm.EnergyConsumption)
						{
							if (Jarvis.RobotArms[0].EnergyConsumption == Jarvis.RobotArms[1].EnergyConsumption)
							{
								if (Jarvis.RobotArms[0].EnergyConsumption > arm.EnergyConsumption)
								{
									Jarvis.RobotArms[0] = arm;
								}
							}
							else
							{
								Jarvis.RobotArms = Jarvis.RobotArms.OrderByDescending(x => x.EnergyConsumption).ToList();
								Jarvis.RobotArms[0] = arm;
							}
						}
					}
				}

				//Creating the legs
				if (inputArr[0] == "Leg")
				{
					Leg leg = new Leg();
					leg.EnergyConsumption = decimal.Parse(inputArr[1]);
					leg.Strength = decimal.Parse(inputArr[2]);
					leg.Speed = decimal.Parse(inputArr[3]);

					if (Jarvis.RobotLegs == null)
					{
						Jarvis.RobotLegs = new List<Leg>();
					}

					if (Jarvis.RobotLegs.Count < 2)
					{
						Jarvis.RobotLegs.Add(leg);
					}
					else
					{
						if (Jarvis.RobotLegs[0].EnergyConsumption > leg.EnergyConsumption || Jarvis.RobotLegs[1].EnergyConsumption > leg.EnergyConsumption)
						{
							if (Jarvis.RobotLegs[0].EnergyConsumption == Jarvis.RobotLegs[1].EnergyConsumption)
							{
								if (Jarvis.RobotLegs[0].EnergyConsumption > leg.EnergyConsumption)
								{
									Jarvis.RobotLegs[0] = leg;
								}
							}
							else
							{
								Jarvis.RobotLegs = Jarvis.RobotLegs.OrderByDescending(x => x.EnergyConsumption).ToList();
								Jarvis.RobotLegs[0] = leg;
							}
						}
					}
				}

				input = Console.ReadLine();
			}

			//if (Jarvis.RobotHead == null || Jarvis.RobotTorso == null || Jarvis.RobotArms.Count < 2 || Jarvis.RobotLegs.Count < 2)
			//{
			//	Console.WriteLine("We need more parts!");
			//}
			//else
			{
				//decimal TotalEnergyConsumption = 0l;
				//TotalEnergyConsumption = Jarvis.RobotHead.EnergyConsumption + Jarvis.RobotHead.EnergyConsumption + (decimal)Jarvis.RobotArms.Sum(x => x.EnergyConsumption) + (decimal)Jarvis.RobotLegs.Sum(x => x.EnergyConsumption);

				//if (TotalEnergyConsumption > energyCapacity)
				//{
				//	Console.WriteLine("We need more power!");
				//}
				//else
				//{
				Console.WriteLine("Jarvis:");
				Console.WriteLine(Jarvis.RobotHead.ToString());
				Console.WriteLine(Jarvis.RobotTorso.ToString());
				foreach (var arm in Jarvis.RobotArms.OrderBy(x => x.EnergyConsumption))
				{
					Console.WriteLine(arm.ToString());
				}
				foreach (var leg in Jarvis.RobotLegs.OrderBy(x => x.EnergyConsumption))
				{
					Console.WriteLine(leg.ToString());
				}
				//}
			}

		}
	}

	class Head
	{
		public decimal EnergyConsumption { get; set; }
		public decimal IQ { get; set; }
		public string SkinMaterial { get; set; }

		public Head()
		{

		}

		public override string ToString()
		{
			string HeadStat = $"#Head:\r\n###Energy consumption: {EnergyConsumption}\r\n###IQ: {IQ}\r\n###Skin material: {SkinMaterial}";
			return HeadStat;
		}

	}

	class Torso
	{
		public decimal EnergyConsumption { get; set; }
		public double ProcessorSize { get; set; }
		public string HousingMaterial { get; set; }

		public Torso()
		{

		}

		public override string ToString()
		{
			string TorsoStat = $"#Torso:\r\n###Energy consumption: {EnergyConsumption}\r\n###Processor size: {ProcessorSize:F1}\r\n###Corpus material: {HousingMaterial}";
			return TorsoStat;
		}
	}

	class Arm
	{
		public decimal EnergyConsumption { get; set; }
		public decimal ReachDistance { get; set; }
		public decimal Fingers { get; set; }

		public Arm()
		{

		}

		public override string ToString()
		{
			string ArmStat = $"#Arm:\r\n###Energy consumption: {EnergyConsumption}\r\n###Reach: {ReachDistance}\r\n###Fingers: {Fingers}";
			return ArmStat;
		}
	}

	class Leg
	{
		public decimal EnergyConsumption { get; set; }
		public decimal Strength { get; set; }
		public decimal Speed { get; set; }

		public Leg()
		{

		}

		public override string ToString()
		{
			string LegStat = $"#Leg:\r\n###Energy consumption: {EnergyConsumption}\r\n###Strength: {Strength}\r\n###Speed: {Speed}";
			return LegStat;
		}
	}

	class Robot
	{
		public Head RobotHead { get; set; }
		public Torso RobotTorso { get; set; }
		public List<Arm> RobotArms { get; set; }
		public List<Leg> RobotLegs { get; set; }

		public Robot()
		{
			RobotHead = new Head();
			RobotTorso = new Torso();
			RobotArms = new List<Arm>();
			RobotLegs = new List<Leg>();
		}
	}
}
