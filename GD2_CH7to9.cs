using System;
public class GD2_CH7to9 {
    public static List<Tuple<int, int>> BuildingPlacement(int width, int height, bool[,] grid)
    {
        List<Tuple<int, int>> positions = new List<Tuple<int, int>>();
        int rows = grid.GetLength(0), cols = grid.GetLength(1);

        for (int r = 0; r <= rows - height; r++)
        {
            for (int c = 0; c <= cols - width; c++)
            {
                bool vld = true;
                for (int h = 0; h < height && vld; h++)
                {
                    for (int w = 0; w < width; w++)
                    {
                        if (grid[r + h, c + w] == true)
                        {
                            vld = false;
                            break;
                        }
                    }
                }
                if (vld)
                {
                    positions.Add(new Tuple<int, int>(c, r));
                }
            }
        }
        return positions;
    }
    
    public static int[] RingTotals(int[,] grid) {
        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);
        int rings = Math.Min(rows, cols) / 2 + Math.Min(rows, cols) % 2;
        int[] totals = new int[rings];

        for (int ring = 0; ring < rings; ring++)
        {
            int sum = 0, top = ring, bottom = rows - ring - 1, left = ring, right = cols - ring - 1;
            for (int i = left; i <= right; i++) { sum += grid[top, i]; }
            for (int i = top + 1; i <= bottom; i++) { sum += grid[i, right]; }
            if (bottom > top) { for (int i = right - 1; i >= left; i--) { sum += grid[bottom, i]; } }
            if (right > left) { for (int i = bottom - 1; i > top; i--) { sum += grid[i, left]; } }
            totals[ring] = sum;
        }

        return totals;
    }
    public static Tuple<string, int, int> FindWord(string word, char[,] grid) {
        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);
        int[] rDirs = { 0, 1, 1, -1};
        int[] cDirs = { 1, 1, 0, 1 };

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++) { 
                for (int d = 0; d < 4; d++)
                {
                    if (ValidWord(grid, word, r, c, rDirs[d], cDirs[d]) == true)
                    {
                        return new Tuple<string, int, int>(word, c, r);
                    }

                }
            }
        }
        return null;
    }

    public static bool ValidWord(char[,] grid, string word, int sRow, int sCol, int rDir, int cDir)
    {
        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);
        for (int i = 0; i < word.Length; i++)
        {
            int nRow = sRow + i * rDir;
            int nCol = sCol + i * cDir;
            if (nRow < 0 || nRow >= rows || nCol < 0 || nCol >= cols || grid[nRow, nCol] != word[i]) { return false; };
        }
        return true;
    }
}