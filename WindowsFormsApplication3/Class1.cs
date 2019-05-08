using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class BitmapImageDetails
    {
        public int totalRed, totalGreen, totalBlue;
        public int averageRed, averageGreen, averageBlue;

        // totalRed
        int GetTotalRed()
        {
            return totalRed;                    // 1
        }
        void SetTotalRed(int totred)
        {
            totalRed = totred;                     // 2
        }
        //averageRed
        int GetAverageRed()
        {
            return averageRed;                  // 3
        }
        void SetAverageRed(int avgred)
        {
            averageRed = avgred;                // 4
        }

        //totalBlue
        //int GetTotalBlue();
        void SetTotalBlue(int totBlue)
        {
            totalBlue = totBlue;                    // 5
        }
        //averageBlue
        int GetAverageBlue()
        {
            return averageBlue;                 // 6 
        }
        void SetAverageBlue(int avgBlue)
        {
            averageBlue = avgBlue;              // 7
        }

        //totalGreen
        int GetTotalGreen()
        {
            return totalGreen;
        }
        void SetTotalGreen(int totGreen)
        {
            totalGreen = totGreen;
        }
        //averageGreen
        int GetAverageGreen()
        {
            return averageGreen;
        }
        void SetAverageGreen(int avgGreen)
        {
            averageGreen = avgGreen;
        }

    }
}
