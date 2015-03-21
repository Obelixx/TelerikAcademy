namespace Matrix
{
    using System;

    class Matrix<T> where T : IConvertible
    {
        private int rows;
        private int cols;
        private T[,] matrix;

        public int Rows
        {
            get { return rows; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Cant build matrix with zero or less then zero rows!");
                }
                else
                {
                    rows = value;
                }
            }
        }

        public int Cols
        {
            get { return cols; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Cant build matrix with zero or less then zero columns!");
                }
                else
                {
                    cols = value;
                }
            }
        }

        private int rowIndex
        {
            get
            {
                return (rowIndex);
            }
            set
            {
                if (value < 0 || value > Rows - 1)
                {
                    throw new ArgumentOutOfRangeException("Row index must exist in the matrix!");
                }
            }
        }
        private int colIndex
        {
            get
            {
                return (colIndex);
            }
            set
            {
                if (value < 0 || value > Cols - 1)
                {
                    throw new ArgumentOutOfRangeException("Column index must exist in the matrix!");
                }
            }
        }

        public Matrix(int rowsCount, int colsCount)
        {
            Rows = rowsCount;
            Cols = colsCount;
            this.matrix = new T[Rows, Cols];
        }

        public T this[int rowIndex, int colIndex]
        {
            get { return (matrix[rowIndex, colIndex]); }
            set { matrix[rowIndex, colIndex] = value; }
        }

        public static Matrix<T> operator +(Matrix<T> A, Matrix<T> B)
        {
            if (A.Rows != B.Rows || A.Cols != B.Cols)
            {
                throw new ArgumentException("Matrix A and Matrix B must be with the same size!");
            }
            Matrix<T> result = new Matrix<T>(A.Rows, A.Cols);

            for (int i = 0; i <= A.Rows; i++)
            {
                for (int j = 0; j < A.Cols; j++)
                {
                    result[i, j] = (dynamic)A[i, j] + B[i, j];
                }
            }
            return (result);
        }

        public static Matrix<T> operator -(Matrix<T> A, Matrix<T> B)
        {
            if (A.Rows != B.Rows || A.Cols != B.Cols)
            {
                throw new ArgumentException("Matrix A and Matrix B must be with the same size!");
            }
            Matrix<T> result = new Matrix<T>(A.Rows, A.Cols);

            for (int i = 0; i <= A.Rows; i++)
            {
                for (int j = 0; j < A.Cols; j++)
                {
                    result[i, j] = (dynamic)A[i, j] - B[i, j];
                }
            }
            return (result);
        }

        public static Matrix<T> operator *(Matrix<T> A, Matrix<T> B)
        {
            if (A.Rows != B.Cols)
            {
                throw new ArgumentException("Matrix A rows must be equal to Matrix B columns!");
            }
            Matrix<T> result = new Matrix<T>(A.Rows, B.Cols);

            for (int i = 0; i <= A.Rows; i++)
            {
                for (int j = 0; j <= B.Cols; j++)
                {
                    for (int ind = 0; ind <= A.Cols; ind++)
                    {
                        result[i, j] += (dynamic)A[i, ind] * B[ind, j];
                    }
                }
            }
            return (result);
        }

        private static bool IsTrue(Matrix<T> A)
        {
            for (int i = 0; i < A.Rows; i++)
            {
                for (int j = 0; j < A.Cols; j++)
                {
                    if (A[i, j] == (dynamic)0)
                    {
                        return (false);
                    }
                }
            }
            return (true);
        }

        public static bool operator true(Matrix<T> A)
        {
            return (IsTrue(A));
        }
        public static bool operator false(Matrix<T> A)
        {
            return (!IsTrue(A));
        }

    }
}
