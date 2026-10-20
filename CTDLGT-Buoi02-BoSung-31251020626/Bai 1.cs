internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 1 || n > 100000)
        {
            Console.WriteLine("n khong hop le!");
            return;
        }

        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu mang {i+1}: ");
            a[i] = int.Parse(Console.ReadLine());
        }

        // Dùng long để tổng không bị tràn khi cộng nhiều số int.
        long sum = 0;

        int min = a[0];
        int max = a[0];

        // Các biến đếm bắt đầu từ 0 vì chưa xét phần tử nào.
        int am = 0, duong = 0, zero = 0;

        // Duyệt mảng một lần để tính tất cả thống kê.
        for (int i = 0; i < n; i++)
        {
            // Cộng phần tử hiện tại vào tổng.
            sum += a[i];

            // Cập nhật min và max nếu tìm thấy giá trị phù hợp hơn.
            if (a[i] < min)
                min = a[i];
            if (a[i] > max)
                max = a[i];

            // Phân loại mỗi phần tử vào đúng một nhóm.
            if (a[i] < 0)
                am++;
            else if (a[i] > 0)
                duong++;
            else zero++;
        }

        // Ép sang double trước phép chia để không bị chia nguyên.
        double avg = (double)sum / n;

        Console.WriteLine($"Tong = {sum}");
        Console.WriteLine($"Min = {min}");
        Console.WriteLine($"Max = {max}");
        Console.WriteLine($"Trung binh = {avg:F2}");
        Console.WriteLine($"So am = {am}; so duong = {duong}; so 0 = {zero}");

        // Hai chỉ số đi từ hai đầu vào giữa, không cần mảng phụ.
        int left = 0, right = n - 1;
        while (left < right)
        {
            // Hoán đổi hai phần tử ở hai đầu đoạn chưa xử lý.
            int temp = a[left];
            a[left] = a[right];
            a[right] = temp;

            // Bỏ qua cặp vừa đổi để xử lý cặp tiếp theo.
            left++;
            right--;
        }

        // In mảng sau khi đảo tại chỗ.
        Console.WriteLine("Mang sau khi dao: " + string.Join(" ", a));
    }
}
