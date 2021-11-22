using System;
using System.Collections.Generic;

namespace introConcept
{
    class Program
    {
        static void Main(string[] args)
        {

            int d = 0; //gün olarak geçen süre...
            int elapsedTimeInDays = 0;
            int daysSinceCreation = 0;
            int gecenGunSayisi = 0;

            int hitPoint = 0;

            List<string> accounts = new List<string>();
            List<string> accountList = new List<string>();


            //İğrenç isimlendirme örnekleri
            //Bunu yazan yazılımcı kör oldu :(
            //var o = 0;
            //var l = 1;
            //var ol = 01;

            //int a = 1;
            //if (o==l)
            //{
            //    a = ol;
            //}
            //else
            //{
            //    l = ol;
            //}

            //int intYas = 0;
            object productDetailResponse = null;
            object addNewProductRequest = null;
            var age =41;
        }

        private static List<int[]> cells = new List<int[]>();
        static List<int[]> getFlaggedCells()
        {
            List<int[]> flaggedCells = new List<int[]>();
            foreach (var cell in cells)
            {
                if (cell[0]==(int)FlagState.Flagged)
                {
                    flaggedCells.Add(cell);
                }
            }
            return flaggedCells;
        }
        
             
    }

    public enum FlagState { 
        Flagged=4,
        NonFlagged=0
    }
}
