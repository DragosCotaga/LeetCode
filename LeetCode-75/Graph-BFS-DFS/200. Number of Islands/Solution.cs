namespace DefaultNamespace;

public class Solution {
    public int NumIslands(char[][] grid) {
        int islandCount = 0;
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[0].Length; j++) {
                if (grid[i][j] == '1') {
                    islandCount++;
                    MarkConnectedCells(grid, i, j);
                }
            }
        }
        return islandCount;
    }

    private void MarkConnectedCells(char[][] grid, int i, int j) {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] == '0') {
            return;
        }
        grid[i][j] = '0';
        MarkConnectedCells(grid, i + 1, j);
        MarkConnectedCells(grid, i - 1, j);
        MarkConnectedCells(grid, i, j + 1);
        MarkConnectedCells(grid, i, j - 1);
    }

}