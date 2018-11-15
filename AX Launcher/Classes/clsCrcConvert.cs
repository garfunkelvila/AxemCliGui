using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AX_Launcher.Classes {
    class clsCrcConvert {
        
        public string crc_hex(string i) {
            string myString;
            byte[] DataDSP = new byte[20];
            int x = 0, y = 0;
            string iRow, iCol;
            int mySum = 0;

            myString = i;
            for (x = 0; x <= 39; x += 2) {
                iRow = "&H" + myString.Substring(x + 1, 2);
                //DataDSP[y] = BitConverter.GetBytes(iRow);
                y += 1;
            }

            for (y = 0; y <= 39; y += 2) {
                mySum = (mySum + (DataDSP[y] % 256));
            }

            mySum = (256 - mySum) & 255; //And &HFF
            myString = CatchEmptyString(mySum.ToString("X"));    //Hex$(mySum)
            return myString;
        }

        private string CatchEmptyString(string theString) {
            if (theString == "") {
                return "00";
            }
            if (theString.Length < 2) {
                return "0" + theString;
            }
            return theString;
        }
    }
}
