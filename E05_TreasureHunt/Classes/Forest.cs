using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_TreasureHunt.Classes
{
    internal class Forest : IForest
    {
        #region Fields

        Random random = new Random();

        #endregion


        #region Properties
        public int Width { get; }
        public int Height { get; }
        public string Treasure { get; }
        public string Tree { get; }
        public string Lion { get; }
        public string Bear { get; }
        public string Motorcycle { get; }
        public string Tank { get; }
        public string Excavator { get; }
        #endregion

        #region Constructor

        public Forest()
        {
            Width = 10;
            Height = 10;
            Treasure = "T";
            Tree = "R";
            Lion = "L";
            Bear = "B";
            Motorcycle = "M";
            Tank = "K";
            Excavator = "E";
        }

        #endregion


        public void CreateForest()
        {
            string[,] forest = new string[Width, Height];

            (int[] row, int[] column) position = GetRandomPosition();

            HideTreasure(forest, position);
        }

        public (int[] row, int[] column) GetRandomPosition()
        {
            int[] row = new int[7];
            int[] column = new int[7];
            
            for (int i = 0; i < 7; i++)
            {
                row[i] = random.Next(0, Width);
                column[i] = random.Next(0, Height);
            }
            
            return (row, column);
        }   

        public void HideTreasure(string[,] forest, (int[] row, int[] column) position)
        {

            forest[position.row[0], position.column[0]] = Treasure;
        }

        public void HideMotorcycle()
        {
            throw new NotImplementedException();
        }

        public void HideTank()
        {
            throw new NotImplementedException();
        }

        public void HideExcavator()
        {
            throw new NotImplementedException();
        }

        public void HideTree()
        {
            throw new NotImplementedException();
        }

        public void HideLion()
        {
            throw new NotImplementedException();
        }

        public void HideBear()
        {
            throw new NotImplementedException();
        }

        public void MoveUp()
        {
            throw new NotImplementedException();
        }

        public void MoveDown()
        {
            throw new NotImplementedException();
        }

        public void MoveLeft()
        {
            throw new NotImplementedException();
        }

        public void MoveRight()
        {
            throw new NotImplementedException();
        }

        public void CheckPosition()
        {
            throw new NotImplementedException();
        }

        public void CheckTreasure()
        {
            throw new NotImplementedException();
        }

        public void CheckMotorcycle()
        {
            throw new NotImplementedException();
        }

        public void CheckTank()
        {
            throw new NotImplementedException();
        }

        public void CheckExcavator()
        {
            throw new NotImplementedException();
        }

        public void CheckTree()
        {
            throw new NotImplementedException();
        }

        public void CheckLion()
        {
            throw new NotImplementedException();
        }

        public void CheckBear()
        {
            throw new NotImplementedException();
        }

        
    }
}
