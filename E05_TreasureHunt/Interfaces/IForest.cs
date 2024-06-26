using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_TreasureHunt
{
    internal interface IForest
    {
        #region Properties

        // string[,] forest = new string[10, 10];

        int Width { get; }
        int Height { get; }
        string Treasure { get; }
        string Motorcycle { get; }
        string Tank { get; }
        string Excavator { get; }
        string Tree { get; }
        string Lion { get; }
        string Bear { get; }

        #endregion

        #region Methods and Functions

        void CreateForest();
        void HideTreasure(string[,] forest, (int[] row, int[] column) position);
        void HideMotorcycle();
        void HideTank();
        void HideExcavator();
        void HideTree();
        void HideLion();
        void HideBear();
        void MoveUp();
        void MoveDown();
        void MoveLeft();
        void MoveRight();
        void CheckPosition();
        void CheckTreasure();
        void CheckMotorcycle();
        void CheckTank();
        void CheckExcavator();
        void CheckTree();
        void CheckLion();
        void CheckBear();


        #endregion
    }
}
