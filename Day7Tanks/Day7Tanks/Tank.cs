using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WorldOfTanks
{
    public class Tank
    {
        public string TheNameOfTank { get; set; }// название танка
        public int LevelTankAmmunition { get; set; } //уровень боекомплекта танка
        public int TankArmor { get; set; } // уровень брони
        public int MobilityOfTank { get; set; } // уровень маневренности

        public Tank()
        {

        }
        public Tank(string TheNameOfTank, int LevelTankAmmunition, int TankArmor, int MobilityOfTank)
        {
            this.TheNameOfTank = TheNameOfTank;
            this.LevelTankAmmunition = LevelTankAmmunition;
            this.TankArmor = TankArmor;
            this.MobilityOfTank = MobilityOfTank;
        }
        public void ShowTanks()
        {
            Console.WriteLine("Название танка:\t\t\t" + TheNameOfTank);
            Console.WriteLine("Уровень боекомплекта танка:\t" + LevelTankAmmunition);
            Console.WriteLine("Уровень брони:\t\t\t" + TankArmor);
            Console.WriteLine("Уровень маневренности:\t\t" + MobilityOfTank);
        }
        public static Tank operator *(Tank FirstTank, Tank SecondTank)
        {

            if (FirstTank.LevelTankAmmunition > SecondTank.LevelTankAmmunition && FirstTank.TankArmor > SecondTank.TankArmor
                || FirstTank.LevelTankAmmunition > SecondTank.LevelTankAmmunition && FirstTank.MobilityOfTank > SecondTank.MobilityOfTank
                || FirstTank.TankArmor > SecondTank.TankArmor && FirstTank.MobilityOfTank > SecondTank.MobilityOfTank
                || FirstTank.LevelTankAmmunition > SecondTank.LevelTankAmmunition && FirstTank.TankArmor > SecondTank.TankArmor && FirstTank.MobilityOfTank > SecondTank.MobilityOfTank)
            {
                return FirstTank;
            }
            else if (FirstTank.LevelTankAmmunition < SecondTank.LevelTankAmmunition && FirstTank.TankArmor < SecondTank.TankArmor
                || FirstTank.LevelTankAmmunition < SecondTank.LevelTankAmmunition && FirstTank.MobilityOfTank < SecondTank.MobilityOfTank
                || FirstTank.TankArmor < SecondTank.TankArmor && FirstTank.MobilityOfTank < SecondTank.MobilityOfTank
                || FirstTank.LevelTankAmmunition < SecondTank.LevelTankAmmunition && FirstTank.TankArmor < SecondTank.TankArmor && FirstTank.MobilityOfTank > SecondTank.MobilityOfTank)
            {
                return SecondTank;
            }
            return SecondTank;
        }
    }
}
