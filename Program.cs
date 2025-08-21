public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap so phan tu cua mang");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] arr = new int[n, n];
        Console.WriteLine("Nhap cac phan tu cua mang:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"arr[{i},{j}]= ");
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Mang da nhap la:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }
        int max = arr[0, 0];
        for (var i = 0; i < arr.GetLength(0); i++)
        {
            for (var j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] > max) max = arr[i, j];
            }
        }
        Console.WriteLine("\nGia tri lon nhat cua mang la: " + max);
    }
}