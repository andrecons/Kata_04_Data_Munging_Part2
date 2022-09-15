using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_04_Data_Munging_Part2.Objects
{
    public class Row
    {
        private string id { get; set; }
        private decimal firstColumn { get; set; }
        private decimal secondColumn { get; set; }

        public Row() { }

        public Row(string inputId, decimal inputFirstColumn, decimal inputSecondColumn)
        {
            this.id = inputId;
            this.firstColumn = inputFirstColumn;
            this.secondColumn = inputSecondColumn;
        }

        public decimal GetSpread()
        {
            //I have to compute a unsigned value
            decimal spread = firstColumn - secondColumn;
            if (spread < 0)
            { spread = spread * (-1); }
            return spread;
        }

        public string GetId()
        { return id; }
        public decimal GetFirstColumn()
        { return firstColumn; }
        public decimal GetSecondColumn()
        { return secondColumn; }

        public void SettId(string inputId)
        { id = inputId; }
        public void SetFirstColumn(int inputFirstColumn)
        { firstColumn = inputFirstColumn; }
        public void SetSecondColumn(int inputSecondColumn)
        { secondColumn = inputSecondColumn; }

        public string ToString()
        {
            return "id: " + id + ";" + " firstColumn: " + firstColumn + ";" + "secondColumn: " + secondColumn;
        }
    }
}