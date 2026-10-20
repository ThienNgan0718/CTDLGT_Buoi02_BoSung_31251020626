
using System;
using System.Collections.Generic;

public class Student
{
    // Mã sinh viên dùng để phân biệt từng sinh viên.
    public string Id { get; set; } = "";

    // Họ tên dùng để hiển thị và tìm kiếm.
    public string FullName { get; set; } = "";

    // Điểm hợp lệ nằm trong khoảng từ 0 đến 10.
    public double Score { get; set; }
}

class Bai_3
{
    // Danh sách lưu các sinh viên hiện có.
    static List<Student> students = new List<Student>();

    // Tìm sinh viên theo mã; trả về null nếu không tìm thấy.
    static Student? FindById(string id)
    {
        foreach (Student s in students)
        {
            if (string.Equals(s.Id, id, StringComparison.OrdinalIgnoreCase))
                return s;
        }

        return null;
    }

    // Thêm sinh viên sau khi kiểm tra dữ liệu nhập.
    static void AddStudent()
    {
        Console.Write("Ma SV: ");
        string id = (Console.ReadLine() ?? "").Trim();

        if (id.Length == 0 || FindById(id) != null)
        {
            Console.WriteLine("Ma rong hoac bi trung.");
            return;
        }

        Console.Write("Ho ten: ");
        string name = (Console.ReadLine() ?? "").Trim();

        if (name.Length == 0)
        {
            Console.WriteLine("Ho ten khong duoc rong.");
            return;
        }

        Console.Write("Diem (0-10): ");
        if (!double.TryParse(Console.ReadLine(), out double score)
            || score < 0 || score > 10)
        {
            Console.WriteLine("Diem khong hop le.");
            return;
        }

        students.Add(new Student
        {
            Id = id,
            FullName = name,
            Score = score
        });

        Console.WriteLine("Them thanh cong.");
    }

    // Cập nhật tên hoặc điểm của sinh viên theo mã.
    static void UpdateStudent()
    {
        Console.Write("Ma SV can cap nhat: ");
        string id = (Console.ReadLine() ?? "").Trim();

        Student? s = FindById(id);

        if (s == null)
        {
            Console.WriteLine("Khong tim thay sinh vien.");
            return;
        }

        Console.Write("Ho ten moi (Enter de giu nguyen): ");
        string name = (Console.ReadLine() ?? "").Trim();

        Console.Write("Diem moi (Enter de giu nguyen): ");
        string input = (Console.ReadLine() ?? "").Trim();

        // Kiểm tra điểm trước khi thay đổi bất kỳ thông tin nào.
        double newScore = s.Score;

        if (input.Length > 0)
        {
            if (!double.TryParse(input, out newScore)
                || newScore < 0 || newScore > 10)
            {
                Console.WriteLine("Diem khong hop le; thong tin giu nguyen.");
                return;
            }
        }

        // Chỉ cập nhật sau khi dữ liệu mới đã hợp lệ.
        if (name.Length > 0)
            s.FullName = name;

        s.Score = newScore;

        Console.WriteLine("Cap nhat xong.");
    }

    // Xóa sinh viên theo mã.
    static void DeleteStudent()
    {
        Console.Write("Ma SV can xoa: ");
        string id = (Console.ReadLine() ?? "").Trim();

        Student? s = FindById(id);

        if (s == null)
        {
            Console.WriteLine("Khong tim thay sinh vien.");
            return;
        }

        students.Remove(s);
        Console.WriteLine("Da xoa.");
    }

    // Tìm sinh viên theo một phần họ tên, không phân biệt hoa thường.
    static void SearchStudent()
    {
        Console.Write("Nhap mot phan ho ten: ");
        string keyword = (Console.ReadLine() ?? "").Trim();

        if (keyword.Length == 0)
        {
            Console.WriteLine("Tu khoa tim kiem khong duoc rong.");
            return;
        }

        int found = 0;

        foreach (Student s in students)
        {
            if (s.FullName.Contains(
                keyword, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(
                    $"{s.Id} | {s.FullName} | {s.Score:F2}");

                found++;
            }
        }

        if (found == 0)
            Console.WriteLine("Khong co ket qua.");
    }

    // Hiển thị toàn bộ sinh viên.
    static void ShowStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("Danh sach rong.");
            return;
        }

        foreach (Student s in students)
        {
            Console.WriteLine(
                $"{s.Id} | {s.FullName} | {s.Score:F2}");
        }
    }

    // Tính điểm trung bình và đếm số sinh viên đạt từ 5 điểm.
    static void ShowStatistics()
    {
        if (students.Count == 0)
        {
            Console.WriteLine(
                "Danh sach rong; chua tinh duoc diem trung binh.");
            return;
        }

        double sum = 0;
        int passed = 0;

        foreach (Student s in students)
        {
            sum += s.Score;

            if (s.Score >= 5)
                passed++;
        }

        Console.WriteLine(
            $"Diem trung binh: {sum / students.Count:F2}");

        Console.WriteLine(
            $"So sinh vien dat (>=5): {passed}");
    }

    // Menu lặp cho đến khi người dùng chọn 0 để thoát.
    static void Main()
    {
        while (true)
        {
            Console.WriteLine(
                "\n1 Them | 2 Cap nhat | 3 Xoa | " +
                "4 Tim | 5 Hien thi | 6 Thong ke | 0 Thoat");

            Console.Write("Chon: ");
            string choice = (Console.ReadLine() ?? "").Trim();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;

                case "2":
                    UpdateStudent();
                    break;

                case "3":
                    DeleteStudent();
                    break;

                case "4":
                    SearchStudent();
                    break;

                case "5":
                    ShowStudents();
                    break;

                case "6":
                    ShowStatistics();
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    break;
            }
        }
    }
}
