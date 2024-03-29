// part 1
double[] arr = [19.5, 11.1, Math.Tau, -7.9, 2.32, -1.261, 29.53, -44.11, 0, 20.74, -5.2, 39.85, Math.PI, 37.732, -1.74, Math.E, 27.84, -0.25, 8.74, 22.7];
Console.WriteLine($"Initial array: [ {string.Join(", ", arr)} ]");
// a)
Console.WriteLine($"Total positives: {arr.Where(x => x > 0).Count()}");
// b)
Console.WriteLine($"Sum of numbers after first zero: {arr.SkipWhile(x => x != 0).Sum()}");
// c)
Console.WriteLine($"Transaformed array: [{string.Join(", ", arr.OrderBy(x => !(x > 0 ? Math.Floor(x) <= 1 : Math.Ceiling(x) >= -1)))} ]");

Console.WriteLine();
// part 2
int[][] arr2d = [
    [0, 1, 2, 3, 4, 5, 6, 7, 8, 9],
    [1, 2, 3, 4, 5, 6, 7, 8, 9, 0],
    [2, 3, 4, 5, 6, 7, 8, 9, 0, 1],
    [3, 4, 5, 6, 7, 8, 9, 0, 1, 2],
    [4, 5, 6, 7, 8, 9, 0, 1, 2, 3],
    [5, 6, 7, 8, 9, 0, 1, 2, 3, 4],
    [6, 7, 8, 9, 0, 1, 2, 3, 4, 5],
    [7, 8, 9, 0, 1, 2, 3, 4, 5, 6],
    [8, 9, 0, 1, 2, 3, 4, 5, 6, 7],
    [9, 0, 1, 2, 3, 4, 5, 6, 7, 8]
];
// a)
Console.WriteLine($"2D Array: [\n\t{string.Join(",\n\t", arr2d.Select(arr => $"[ {string.Join(", ", arr)} ]"))}\n]");
// b)
Console.WriteLine($"Every 5th row: [\n\t{string.Join(",\n\t", arr2d.Where((arr, i) => (i + 1) % 5 == 0).Select(arr => $"[ {string.Join(", ", arr)} ]"))}\n]");
// c)
var s = 11;
s = s > arr2d.Length ? arr2d.Length - 1 : s;
Console.WriteLine($"Elements from {s}th column: [ {string.Join(", ", arr2d.Select(arr => arr.Skip(s).First()))} ]");
