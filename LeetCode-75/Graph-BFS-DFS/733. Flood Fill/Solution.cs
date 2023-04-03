namespace DefaultNamespace;

public class Solution
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
        if (image[sr][sc] == newColor) return image;
        FloodFillHelper(image, sr, sc, image[sr][sc], newColor);
        return image;
    }

    private void FloodFillHelper(int[][] image, int i, int j, int oldColor, int newColor) {
        if (i < 0 || i >= image.Length || j < 0 || j >= image[0].Length || image[i][j] != oldColor) {
            return;
        }
        image[i][j] = newColor;
        FloodFillHelper(image, i + 1, j, oldColor, newColor);
        FloodFillHelper(image, i - 1, j, oldColor, newColor);
        FloodFillHelper(image, i, j + 1, oldColor, newColor);
        FloodFillHelper(image, i, j - 1, oldColor, newColor);
    }

}