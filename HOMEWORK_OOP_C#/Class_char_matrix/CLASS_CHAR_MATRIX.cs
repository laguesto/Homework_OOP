using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_char_matrix
{
    public class CLASS_CHAR_MATRIX
    {
        private char[,] matrix;

        public CLASS_CHAR_MATRIX(char[,] matrix) //конструктор
        {
            this.matrix = matrix;
        }


        public string this[int column] // індексатор 
        {
            get
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);
            
                string result = "";

                for (int i = 0; i < rows; i++)
                {
                    result += matrix[i, column];
                }

                return result;
            }

            set
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);               
     
                for (int i = 0; i < rows; i++)
                {
                    matrix[i, column] = value[i];
                }
            }
        }
        

        public int Digit_Count //Властивість  
        {
            get
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                int count = 0;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (char.IsDigit(matrix[i, j]))
                            count++;
                    }
                }

                return count;
            }
        }


    }
}
