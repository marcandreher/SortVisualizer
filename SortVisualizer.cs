using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class SortVisualizer
    {
        private int[] _toSort;
        private int _highestFill = 29;
        private string _render = "";
        // 126 long int array, up to 27 per int
        public SortVisualizer(int[] _toSort)
        {
            this._toSort = _toSort;
        }

        public void UpdateVisualizer()
        {
        _render = string.Empty;
            for(int i = 0; i < _highestFill; i++)
            {
                for(int y = 0; y < 120; y++)
                {
                    if(_toSort[y] <= i)
                    {
                        _render += "█";
                    }
                    else
                    {
                        _render += " ";
                    }
                }
                _render += "\n";
               
            }
        Console.SetCursorPosition(0, 0);
        Console.Write(_render);

        }

   
      

    }


