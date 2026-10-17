//Jobs
//1.Viết đoạn lệnh để tính ra tổng các giá trị ở đường viền của
//mảng 2 chiều [N, M]

//2. Cho 2 mảng1 chiềuA có kích thước là N. Viết lệnh để cho 
//ra mảng 2 chiều [N,N], ký hiệu là C. Mà c[i,j] = A[i] –A[j].

//3.Viết chương trình tạo ra mảng tự do thể hiện tam giác Pascal.

//4. Viết chương trình để thêm 1 phần tử vào sau vị trí thứ k trên 
//mảng 1 chiềuA. Tương tự xóa vị trí k.

/*1
 * int[,] a = new int[,]
{
    {1,2,3},
    {4,-99,5},
    {6,7,8}
};

int maxRow = a.GetLength(0);
int maxCol = a.GetLength(1);
int total = 0;
for (int i = 0; i < maxRow; i++)
{
    for (int j = 0; j < maxCol; j++)
    {
        if (i==0 || i ==maxRow-1 || j == 0 || j == maxCol - 1)
        {
            total += a[i, j];
        }
    }
}
Console.WriteLine(total);
*/

/* 2
    int[] a = new int[] { 1, 2, 3, 4, 5 };
    int[] b = new int[] { 2, 123, 4, 5, 6 };

    for (int i = 0; i < a.Length; i++)
    {
        for (int j = 0; j < b.Length; j++)
        {
            Console.Write($"{a[i] - a[j]}\t");
        }
        Console.WriteLine();
    }
*/

/* 3
int a = 6;

int[,] m = new int[a,a];

for (int r = 0; r < a; r++)
{
    for (int c = 0; c <= r; c++)
    {
        if (c==0||c==r)
        {
            m[r,c] = 1;
        }
        else 
        {
            m[r, c] = m[r - 1, c - 1] + m[r - 1, c];
        }
        if (m[r,c]!=0)
        {
            Console.Write(m[r,c]+" ");
        }
    }
    Console.WriteLine();
}
*/










