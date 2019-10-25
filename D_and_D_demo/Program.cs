using D_and_D_demo.Actions;
using D_and_D_demo.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_and_D_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            CreatureFromFileReader creatureTable = new CreatureFromFileReader();
            creatureTable.CreateCreatureList();
            //TryLINQ tryLINQ = new TryLINQ();
            //tryLINQ.ShowCreaturesNames();
            //tryLINQ.MaxArmorClass();
            //tryLINQ.SortByClaws();
            //tryLINQ.CreatureSearch();
            //tryLINQ.ShowCreatureDemage();
            //tryLINQ.MaxDemage();
            //tryLINQ.AverageDemage();
            //tryLINQ.SortByLevelAndHitpoints();
            //tryLINQ.SumHPOf1LvlCreatures();
            FightClub club = new FightClub();
            //club.RandomFight();
            club.ChoosenCreturesFight();
            Console.ReadLine();
        }           
    }
}
