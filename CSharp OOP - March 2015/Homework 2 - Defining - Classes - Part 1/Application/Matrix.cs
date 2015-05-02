namespace Application
{
    using System;
    using System.Collections;
    using System.Text;

    /*
        Problem 8. Matrix
        Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).      
      
        Problem 9. Matrix indexer
        • Implement an indexer  this[row, col]  to access the inner matrix cells.

        Problem 10. Matrix operations
        • Implement the operators  +  and  -  
        (addition and subtraction of matrices of the same size) and  *  for matrix multiplication.
        • Throw an exception when the operation cannot be performed.
        • Implement the  true  operator (check for non-zero elements).

     */
    public class Matrix<T>
    {
        // fields
        private T[,] matrix;
        private int rows;
        private int cols;

        public Matrix (int rows, int cols)
        {
            this.Rows = rows;
            this.Columns = cols;
            this.matrix = new T[rows, cols];
        }

        // properties
        public int Columns
        {
            get { return this.cols; }

            set 
            {
                if (value < 1)
                {
                    throw new ArgumentException("Argument must be > 0");
                }

                this.cols = value;
            }
        }

        public int Rows
        {
            get { return this.rows; }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Argumet must be > 0");
                }

                this.rows = value;
            }
        }

        // methods

        // overloaded operators
        public static Matrix<T> operator*(Matrix<T> lhs, Matrix<T> rhs)
        {
            Matrix<T> resultMatrix = new Matrix<T>(lhs.Rows, rhs.Columns);

            for (int i = 0; i < resultMatrix.Rows; i++)
            {
                for (int j = 0; j < resultMatrix.Columns; j++)
                {
                    resultMatrix[i, j] = (dynamic)0;
                    for (int k = 0; k < lhs.Columns; k++)
                    {
                        resultMatrix[i, j] += (dynamic)lhs[i, k] * (dynamic)rhs[k, j];
                    }
                }
            }

            return resultMatrix;
        }

        public static Matrix<T> operator+(Matrix<T> lhs, Matrix<T> rhs)
        {
            if (lhs.Columns != rhs.Columns || lhs.Rows != rhs.Rows)
            {
                throw new ArgumentException("Matrix must be the same size");
            }

            Matrix<T> newMatrix = new Matrix<T>(lhs.Rows, lhs.Columns);

            for (int i = 0; i < lhs.Rows; i++)
            {
                for (int j = 0; j < lhs.Columns; j++)
                {
                    newMatrix[i, j] = (dynamic)lhs[i, j] + (dynamic)rhs[i, j];
                }
            }

            return newMatrix;
        }

        public static Matrix<T> operator-(Matrix<T> lhs, Matrix<T> rhs)
        {
            if (lhs.Columns != rhs.Columns || lhs.Rows != rhs.Rows)
            {
                throw new ArgumentException("Matrix must be the same size");
            }

            Matrix<T> newMatrix = new Matrix<T>(lhs.Rows, lhs.Columns);

            for (int i = 0; i < lhs.Rows; i++)
            {
                for (int j = 0; j < lhs.Columns; j++)
                {
                    newMatrix[i, j] = (dynamic)lhs[i, j] - (dynamic)rhs[i, j];
                }
            }

            return newMatrix;
        }

        public static bool operator true (Matrix<T> lhs)
        {
            for (int i = 0; i < lhs.Rows; i++)
            {
                for (int j = 0; j < lhs.Columns; j++)
                {
                    if ((dynamic)lhs[i, j] > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator false(Matrix<T> lhs)
        {
            for (int i = 0; i < lhs.Rows; i++)
            {
                for (int j = 0; j < lhs.Columns; j++)
                {
                    if ((dynamic)lhs[i, j] > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // indexer
        public T this[int row, int col]
        {
            get 
            {
                if (row >= 0 && row < this.rows &&
                    col >= 0 && col < this.cols)
                {
                    return this.matrix[row, col];
                }
                else
                {
                    throw new ArgumentException (string.Format ("Argument row({0} of {1}) or column({2} of {3}) is out of range.", 
                        row, this.rows, col, this.cols));
                }
            }

            set
            {
                if (row >= 0 && row < this.rows &&
                   col >= 0 && col < this.cols)
                {
                    this.matrix[row, col] = value;
                }
                else
                {
                    throw new ArgumentException(string.Format("Argument row({0} of {1}) or column({2} of {3}) is out of range.",
                        row, this.rows, col, this.cols));
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.cols; j++)
                {
                    sb.AppendFormat("{0} ", this.matrix[i, j]);
                }
                sb.Append('\n');
            }
            return sb.ToString();
        }
    }
}
