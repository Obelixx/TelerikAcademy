namespace Matrix
{
    using System;
    using System.Text;

    class Matrix<T> where T : IConvertible
    {
        private int rows;
        private int cols;
        private T[,] matrix;
        private int rowI;
        private int colI;

        #region Prop
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
                return (rowI);
            }
            set
            {
                if (value < 0 || value > Rows - 1)
                {
                    throw new ArgumentOutOfRangeException("Row index must exist in the matrix!");
                }
                this.rowI = value;
            }
        }
        private int colIndex
        {
            get
            {
                return (colI);
            }
            set
            {
                if (value < 0 || value > Cols - 1)
                {
                    throw new ArgumentOutOfRangeException("Column index must exist in the matrix!");
                }
                this.colI = value;
            }
        }

        public bool IsTrue
        {
            get
            {
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Cols; j++)
                    {
                        if (this.matrix[i, j] == (dynamic)0)
                        {
                            return (false);
                        }
                    }
                }
                return (true);
            }
        }

        public bool IsFalse 
        {
            get
            {
                return (!IsTrue);
            }
        }
        #endregion

        public Matrix(int rowsCount, int colsCount)
        {
            Rows = rowsCount;
            Cols = colsCount;
            this.matrix = new T[Rows, Cols];
        }

        public T this[int row, int col]
        {
            get
            {
                this.rowIndex = row;
                this.colIndex = col;
                return (matrix[rowIndex, colIndex]);
            }
            set
            {
                this.rowIndex = row;
                this.colIndex = col;
                matrix[rowIndex, colIndex] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> A, Matrix<T> B)
        {
            if (A.Rows != B.Rows || A.Cols != B.Cols)
            {
                throw new ArgumentException("Matrix A and Matrix B must be with the same size!");
            }
            Matrix<T> result = new Matrix<T>(A.Rows, A.Cols);

            for (int i = 0; i < A.Rows; i++)
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

            for (int i = 0; i < A.Rows; i++)
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
            if (B.Rows != A.Cols)
            {
                throw new ArgumentException("Matrix A columns must be equal to Matrix B rows!");
            }
            Matrix<T> result = new Matrix<T>(A.Rows, B.Cols);

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    for (int ind = 0; ind < A.Cols; ind++)
                    {
                        result[i, j] += (dynamic)A[i, ind] * B[ind, j];
                    }
                }
            }
            return (result);
        }

        public void FillMatrix(T with)
        {
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    this.matrix[i, j] = with;
                }
            }
        }

        public static bool operator true(Matrix<T> A)
        {
            return (A.IsTrue);
        }
        public static bool operator false(Matrix<T> A)
        {
            return (A.IsFalse);
        }

        public static bool operator &(Matrix<T> A, Matrix<T> B) { return (A.IsTrue & B.IsTrue); }

        public static bool operator |(Matrix<T> A, Matrix<T> B) { return (A.IsTrue | B.IsTrue); }


        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < this.Rows; i++)
            {
                sb.Append("{");
                for (int j = 0; j < this.Cols; j++)
                {
                    sb.Append("[");
                    sb.Append(this.matrix[i, j]);
                    sb.Append("]");
                }
                sb.Append("}\n");
            }
            return (sb.ToString());
        }
    }
}
