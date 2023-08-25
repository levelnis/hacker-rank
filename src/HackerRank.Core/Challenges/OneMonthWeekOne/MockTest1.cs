namespace HackerRank.Core.Challenges.OneMonthWeekOne;

public static class MockTest1
{
    public static int Execute(List<List<int>> matrix)
    {
        Console.WriteLine($" Running execution for {matrix.Count} items at {DateTime.Now.ToLongTimeString()}...");
        var miniMatrixLength = matrix.Count / 2;
        
        return SumMatrix(matrix, miniMatrixLength);

        int SumMatrix(List<List<int>> matrix, int size)
        {
            var total = 0;
            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    var quad1Number = GetQuadrantNumber(i, j, 1);
                    var quad2Number = GetQuadrantNumber(i, j, 2);
                    var quad3Number = GetQuadrantNumber(i, j, 3);
                    var quad4Number = GetQuadrantNumber(i, j, 4);
                    Console.WriteLine();
                    var highestQuadNumber = GetHighestQuadNumber(quad1Number, quad2Number, quad3Number, quad4Number);
                    Console.WriteLine($"Highest number for Col {i} and Row {j} is {highestQuadNumber}");
                    total += highestQuadNumber;
                }
            }

            return total;

            int GetQuadrantNumber(int i, int j, int quadrant)
            {
                var startIndex = 0;
                var iIndex = 0;
                var jIndex = 0;
                var endIndex = matrix.Count - 1;
                switch(quadrant)
                {
                    case 1:
                        iIndex = startIndex + i;
                        jIndex = startIndex + j;
                        break;
                    case 2:
                        iIndex = endIndex - i;
                        jIndex = startIndex + j;
                        break;
                    case 3:
                        iIndex = startIndex + i;
                        jIndex = endIndex - j;
                        break;
                    case 4:
                        iIndex = endIndex - i;
                        jIndex = endIndex - j;
                        break;
                }

                Console.WriteLine($"Quadrant {quadrant}: Col {iIndex} and Row {jIndex} contains value {matrix[iIndex][jIndex]}");

                return matrix[iIndex][jIndex];
            }

            int GetHighestQuadNumber(int quad1Number, int quad2Number, int quad3Number, int quad4Number)
            {
                var higher = GetHigher(quad1Number, quad2Number);
                higher = GetHigher(higher, quad3Number);
                return GetHigher(higher, quad4Number);

                int GetHigher(int number1, int number2)
                {
                    return number1 > number2 ? number1 : number2;
                }
            }
        }
    }
}