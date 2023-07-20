namespace AK.Test.ResDiary;

public class GroupArrayDivider : IGroupArrayDivider
{
    /// <summary>
    /// Group Array Elements Method divide the input array into N equally sized arrays 
    /// </summary>
    /// <param name="array"></param>
    /// <param name="N"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public List<List<int>> GroupArrayElements(int[] array, int N)
    {
        if (N <= 0)
            throw new ArgumentException("N should be a positive integer greater than zero.");


        int arraySize = array.Length;
        int chunkSize = (arraySize + N - 1) / N; // Rounded up division

        List<List<int>> result = new List<List<int>>();

        for (int i = 0; i < arraySize; i += chunkSize)
        {
            int endIndex = Math.Min(i + chunkSize, arraySize);
            List<int> chunk = new List<int>(chunkSize);

            for (int j = i; j < endIndex; j++)
            {
                chunk.Add(array[j]);
            }

            result.Add(chunk);
        }

        return result;
    }

}
