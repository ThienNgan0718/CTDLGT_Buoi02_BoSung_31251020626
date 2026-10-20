using System;

public class DynamicArray<T>
{
    // Mảng nền lưu phần tử; dung lượng có thể lớn hơn Count.
    private T[] items;

    // Count chỉ đếm số phần tử đã được thêm hợp lệ.
    public int Count { get; private set; }

    // Capacity cho biết số ô hiện có trong mảng nền.
    public int Capacity => items.Length;

    // Khởi tạo mảng với dung lượng mặc định 4 hoặc theo yêu cầu.
    public DynamicArray(int capacity = 4)
    {
        // Dung lượng âm không hợp lệ vì không thể cấp phát mảng âm.
        if (capacity < 0)
            throw new ArgumentOutOfRangeException(nameof(capacity));

        // Mảng dung lượng 0 vẫn hợp lệ; lần Add đầu tiên sẽ mở rộng.
        items = new T[capacity];
        Count = 0;
    }

    // Thêm phần tử vào vị trí kế tiếp còn trống.
    public void Add(T item)
    {
        // Bảo đảm còn ít nhất một ô trước khi ghi dữ liệu.
        EnsureCapacity();

        // Ghi ở Count vì các vị trí 0..Count-1 đang hợp lệ.
        items[Count] = item;

        // Tăng số phần tử sau khi ghi thành công.
        Count++;
    }

    // Mở rộng mảng nền khi Count đã bằng Capacity.
    private void EnsureCapacity()
    {
        if (Count < Capacity) return;

        // Nếu dung lượng bằng 0 thì bắt đầu từ 4; nếu không thì nhân đôi.
        int newCapacity = Capacity == 0 ? 4 : Capacity * 2;
        T[] newItems = new T[newCapacity];

        // Sao chép đúng các phần tử hợp lệ, giữ nguyên thứ tự ban đầu.
        for (int i = 0; i < Count; i++)
            newItems[i] = items[i];

        // Chuyển vùng lưu trữ sang mảng mới sau khi sao chép xong.
        items = newItems;
    }

    // Indexer cho phép đọc/ghi như thể đối tượng là một mảng.
    public T this[int index]
    {
        get
        {
            // Chỉ các chỉ số từ 0 đến Count-1 mới chứa phần tử hợp lệ.
            if (index < 0 || index >= Count)
                throw new ArgumentOutOfRangeException(nameof(index));
            return items[index];
        }
        set
        {
            // Không cho ghi vào ô trống ngoài vùng dữ liệu hợp lệ.
            if (index < 0 || index >= Count)
                throw new ArgumentOutOfRangeException(nameof(index));
            items[index] = value;
        }
    }
}

class Bai_4
{
    static void Main()
    {
        // Dung lượng mặc định ban đầu là 4.
        DynamicArray<int> values = new DynamicArray<int>();

        // Thêm 1..10 để quan sát thời điểm Capacity tăng gấp đôi.
        for (int i = 1; i <= 10; i++)
        {
            values.Add(i);
            Console.WriteLine($"Them {i}: Count={values.Count}, Capacity={values.Capacity}");
        }

        // Đọc và cập nhật phần tử thông qua indexer.
        Console.WriteLine($"Gia tri index 3: {values[3]}");
        values[3] = 40;
        Console.WriteLine($"Sau cap nhat index 3: {values[3]}");

        // Thử chỉ số âm để xác nhận indexer phát sinh ngoại lệ.
        try { Console.WriteLine(values[-1]); }
        catch (ArgumentOutOfRangeException) { Console.WriteLine("Index am khong hop le."); }

        // Count là chỉ số không hợp lệ vì phần tử hợp lệ cuối ở Count-1.
        try { Console.WriteLine(values[values.Count]); }
        catch (ArgumentOutOfRangeException) { Console.WriteLine("Index bang Count khong hop le."); }

        // In toàn bộ dữ liệu để xác nhận thứ tự được giữ sau mở rộng.
        for (int i = 0; i < values.Count; i++)
            Console.Write(values[i] + (i < values.Count - 1 ? " " : ""));
        Console.WriteLine();
    }
}
