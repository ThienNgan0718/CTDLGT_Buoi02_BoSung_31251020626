using System;
internal class Bai_2
{
    // Chèn value vào vị trí index trong count phần tử hợp lệ.
    static void Insert(int[] data, ref int count, int index, int value)
    {
        // Khi chèn, index có thể bằng count để thêm phần tử vào cuối.
        if (index < 0 || index > count)
            throw new ArgumentOutOfRangeException(nameof(index));

        // Không chèn được nếu không còn ô trống trong mảng.
        if (count == data.Length)
            throw new InvalidOperationException("Mang da day.");

        // Dịch từ phải sang trái để tạo chỗ trống tại index.
        for (int i = count; i > index; i--)
            data[i] = data[i - 1];

        data[index] = value;
        count++;
    }

    // Xóa phần tử tại index.
    static void RemoveAt(int[] data, ref int count, int index)
    {
        // Khi xóa, index phải nằm trong khoảng từ 0 đến count - 1.
        if (index < 0 || index >= count)
            throw new ArgumentOutOfRangeException(nameof(index));

        // Dịch các phần tử phía sau sang trái để lấp vị trí bị xóa.
        for (int i = index; i < count - 1; i++)
            data[i] = data[i + 1];
        count--;
    }
    // Chỉ in count phần tử hợp lệ của mảng.
    static void Print(int[] data, int count)
    {
        Console.Write("[");
        for (int i = 0; i < count; i++)
        {
            Console.Write(data[i]);
            if (i < count - 1)
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }

    static void Main()
    {
        // CA 1: Bắt đầu với [4, 7, 2, 9, 5], chèn 99 tại index 2,
        // sau đó xóa phần tử tại index 1.
        Console.WriteLine(" CA 1: CHEN VA XOA LIEN TIEP ");
        int[] a1 = { 4, 7, 2, 9, 5, 0 };
        int count1 = 5;

        Console.Write("Mang ban dau: ");
        Print(a1, count1);

        Insert(a1, ref count1, 2, 99);
        Console.Write("Sau khi chen 99 tai index 2: ");
        Print(a1, count1);

        RemoveAt(a1, ref count1, 1);
        Console.Write("Sau khi xoa index 1: ");
        Print(a1, count1);


        // CA 2: Chèn tại đầu mảng.
        Console.WriteLine("\n CA 2: CHEN DAU ");
        int[] a2 = { 4, 7, 2, 9, 5, 0 };
        int count2 = 5;

        Insert(a2, ref count2, 0, 99);
        Print(a2, count2);


        // CA 3: Chèn tại cuối mảng.
        Console.WriteLine("\n CA 3: CHEN CUOI ");
        int[] a3 = { 4, 7, 2, 9, 5, 0 };
        int count3 = 5;

        Insert(a3, ref count3, count3, 99);
        Print(a3, count3);


        // CA 4: Xóa phần tử đầu tiên.
        Console.WriteLine("\n CA 4: XOA DAU ");
        int[] a4 = { 4, 7, 2, 9, 5 };
        int count4 = 5;

        RemoveAt(a4, ref count4, 0);
        Print(a4, count4);


        // CA 5: Xóa phần tử cuối cùng.
        Console.WriteLine("\n CA 5: XOA CUOI ");
        int[] a5 = { 4, 7, 2, 9, 5 };
        int count5 = 5;

        RemoveAt(a5, ref count5, count5 - 1);
        Print(a5, count5);


        // CA 6: Thử chèn tại index âm.
        Console.WriteLine("\n CA 6: INDEX AM ");
        int[] a6 = { 4, 7, 2, 9, 5, 0 };
        int count6 = 5;

        try
        {
            Insert(a6, ref count6, -1, 99);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Loi: ArgumentOutOfRangeException");
        }
        Print(a6, count6);
        // CA 7: Thử xóa tại index bằng count.
        Console.WriteLine("\n CA 7: XOA INDEX BANG COUNT ");
        int[] a7 = { 4, 7, 2, 9, 5 };
        int count7 = 5;
        try
        {
            RemoveAt(a7, ref count7, count7);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Loi: ArgumentOutOfRangeException");
        }

        Print(a7, count7);

        // CA 8: Thử chèn khi mảng đã đầy.
        // Mảng có đúng 5 ô và cả 5 ô đều đang chứa dữ liệu hợp lệ.
        Console.WriteLine("\n CA 8: MANG DA DAY ");
        int[] a8 = { 4, 7, 2, 9, 5 };
        int count8 = 5;
        try
        {
            Insert(a8, ref count8, 2, 99);
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("Loi: InvalidOperationException");
        }

        Print(a8, count8);
    }
}
