Lê Ý Thiên Ngân - 31251020626

Bài 1:

Mô tả thuật toán

1. Nhập mảng
   
Nhập số phần tử n.
Kiểm tra n nằm trong khoảng cho phép.
Khởi tạo mảng có n phần tử và nhập lần lượt từng giá trị.

2. Thống kê mảng
   
Khởi tạo sum = 0, negative = 0, positive = 0, zero = 0.
Gán giá trị phần tử đầu tiên cho min và max.
Duyệt mảng từ đầu đến cuối.
Cộng từng phần tử vào tổng.
So sánh từng phần tử để cập nhật giá trị nhỏ nhất và lớn nhất.
Nếu phần tử nhỏ hơn 0, tăng biến đếm số âm; nếu lớn hơn 0, tăng biến đếm số dương; nếu bằng 0, tăng biến đếm số 0.
Tính trung bình cộng bằng tổng chia cho n.
Việc khởi tạo min và max từ phần tử đầu tiên giúp thuật toán xử lý đúng cả mảng toàn số âm hoặc toàn số dương.

3. Đảo mảng tại chỗ
   
Khởi tạo hai chỉ số left = 0 và right = n - 1.
Khi left < right, hoán đổi hai phần tử tại hai vị trí.
Tăng left và giảm right.
Dừng khi hai chỉ số gặp nhau hoặc vượt qua nhau.
Thuật toán không tạo mảng phụ, chỉ sử dụng biến tạm để hoán đổi phần tử.

Bài 2:
Mô tả thuật toán
1. Chèn phần tử – Insert()

Kiểm tra index có nằm trong khoảng từ 0 đến count hay không.
Kiểm tra mảng còn ô trống hay không.
Duyệt từ vị trí count ngược về index + 1.
Dịch mỗi phần tử sang phải một vị trí bằng cách gán data[i] = data[i - 1].
Gán giá trị mới vào data[index].
Tăng count lên 1.
Duyệt từ phải sang trái giúp tránh ghi đè dữ liệu chưa được dịch chuyển.

2. Xóa phần tử – RemoveAt()

Kiểm tra index nằm trong khoảng từ 0 đến count - 1.
Duyệt từ index đến count - 2.
Dịch mỗi phần tử phía sau sang trái một vị trí bằng cách gán data[i] = data[i + 1].
Giảm count xuống 1.
Sau khi xóa, chỉ count phần tử đầu tiên được xem là dữ liệu hợp lệ. Giá trị còn lại ở ô cuối không thuộc vùng dữ liệu hợp lệ nên không được in ra.

3. Hiển thị mảng – Print()

Duyệt từ chỉ số 0 đến count - 1 và in từng phần tử. Không in các ô trống nằm sau vùng dữ liệu hợp lệ.

Bài 3:
Mô tả thuật toán

1. Tìm sinh viên theo mã – FindById()
   
Duyệt lần lượt từng sinh viên trong danh sách.
So sánh mã cần tìm với mã của từng sinh viên, không phân biệt chữ hoa và chữ thường.
Nếu tìm thấy, trả về đối tượng sinh viên tương ứng.
Nếu duyệt hết danh sách mà không tìm thấy, trả về null.

2. Thêm sinh viên – AddStudent()
   
Nhập mã sinh viên.
Kiểm tra mã không được rỗng và chưa tồn tại trong danh sách.
Nhập họ tên và kiểm tra không được rỗng.
Nhập điểm và kiểm tra điểm nằm trong khoảng từ 0 đến 10.
Nếu tất cả dữ liệu hợp lệ, tạo đối tượng Student mới và thêm vào danh sách bằng students.Add().
Thông báo kết quả.

3. Cập nhật sinh viên – UpdateStudent()
   
Nhập mã sinh viên cần cập nhật.
Tìm sinh viên bằng FindById().
Nếu không tìm thấy, thông báo lỗi và kết thúc.
Nhập họ tên mới và điểm mới; nhấn Enter để giữ nguyên thông tin tương ứng.
Kiểm tra điểm mới trước khi thay đổi dữ liệu.
Nếu dữ liệu hợp lệ, cập nhật các thuộc tính của sinh viên và thông báo thành công.

4. Xóa sinh viên – DeleteStudent()
Nhập mã sinh viên cần xóa.
Tìm sinh viên bằng FindById().
Nếu không tìm thấy, thông báo lỗi.
Nếu tìm thấy, gọi students.Remove() để xóa sinh viên khỏi danh sách.

5. Tìm kiếm sinh viên – SearchStudent()
Nhập từ khóa là một phần họ tên.
Nếu từ khóa rỗng, thông báo và kết thúc.
Duyệt toàn bộ danh sách, sử dụng Contains() để kiểm tra họ tên có chứa từ khóa hay không.
In các sinh viên phù hợp và tăng biến đếm kết quả.
Nếu không có kết quả phù hợp, thông báo không tìm thấy.

6. Hiển thị danh sách – ShowStudents()
Kiểm tra số lượng sinh viên trong danh sách.
Nếu danh sách rỗng, thông báo và kết thúc.
Nếu danh sách có dữ liệu, duyệt và in mã sinh viên, họ tên và điểm của từng người.

7. Thống kê – ShowStatistics()
   
Kiểm tra danh sách có rỗng hay không.
Nếu rỗng, thông báo và không thực hiện phép chia.
Khởi tạo biến tổng điểm sum = 0 và số sinh viên đạt passed = 0.
Duyệt danh sách, cộng điểm vào tổng và tăng passed nếu điểm lớn hơn hoặc bằng 5.
Tính điểm trung bình bằng tổng điểm chia cho số sinh viên.
In điểm trung bình và số sinh viên đạt.

8. Menu chính – Main()
   
Hiển thị menu chức năng.
Nhận lựa chọn từ người dùng.
Sử dụng switch để gọi phương thức tương ứng.
Lặp lại menu sau khi thực hiện chức năng.
Kết thúc chương trình khi người dùng chọn 0.

Bài 4:
Mô tả thuật toán
1. Khởi tạo mảng động

Nhận dung lượng ban đầu thông qua tham số capacity, mặc định là 4.
Nếu capacity < 0, phát sinh ArgumentOutOfRangeException.
Tạo mảng nội bộ items với số ô bằng capacity.
Khởi tạo Count = 0 vì chưa có phần tử nào được thêm.
Dung lượng bằng 0 vẫn được chấp nhận. Khi thêm phần tử đầu tiên, chương trình sẽ tự mở rộng mảng.

2. Thêm phần tử – Add(T item)

Gọi EnsureCapacity() để bảo đảm mảng còn ít nhất một ô trống.
Gán phần tử mới vào items[Count].
Tăng Count lên 1.
Phần tử được thêm vào cuối vùng dữ liệu hợp lệ. Vì vậy, các phần tử cũ vẫn giữ nguyên thứ tự.

3. Kiểm tra và mở rộng dung lượng – EnsureCapacity()

Nếu Count < Capacity, mảng vẫn còn chỗ trống nên kết thúc phương thức ngay.
Nếu mảng đã đầy, tính dung lượng mới:
Nếu Capacity == 0, dung lượng mới bằng 4.
Nếu Capacity > 0, dung lượng mới bằng hai lần dung lượng hiện tại.
Tạo mảng mới newItems có dung lượng vừa tính.
Duyệt từ chỉ số 0 đến Count - 1 để sao chép các phần tử hợp lệ từ items sang newItems.
Gán newItems cho items, thay thế vùng lưu trữ cũ.
Dung lượng được mở rộng trước khi thêm phần tử mới. Sau khi mở rộng, Add() tiếp tục ghi phần tử vào vị trí Count rồi mới tăng Count.

4. Truy cập phần tử bằng indexer

Indexer cho phép đọc hoặc cập nhật phần tử bằng cú pháp giống mảng, chẳng hạn values[3].
Khi đọc (get):
Kiểm tra index < 0 hoặc index >= Count.
Nếu chỉ số không hợp lệ, phát sinh ArgumentOutOfRangeException.
Nếu hợp lệ, trả về items[index].
Khi ghi (set):
Thực hiện kiểm tra chỉ số tương tự như khi đọc.
Nếu chỉ số không hợp lệ, phát sinh ArgumentOutOfRangeException.
Nếu hợp lệ, gán giá trị mới vào items[index].
Indexer sử dụng Count để kiểm tra vì các ô từ Count đến Capacity - 1 chưa thuộc vùng dữ liệu hợp lệ.

5. Kiểm thử trong Main()

Khởi tạo DynamicArray<int> với dung lượng mặc định là 4.
Thêm các số từ 1 đến 10 và in Count, Capacity sau mỗi lần thêm để quan sát quá trình mở rộng.
Đọc phần tử tại index 3.
Cập nhật phần tử tại index 3 thành 40 và đọc lại để kiểm tra.
Thử đọc tại index -1 và index bằng Count; bắt ngoại lệ để xác nhận kiểm tra chỉ số hoạt động.
In toàn bộ phần tử hợp lệ để kiểm tra dữ liệu và thứ tự sau khi mở rộng.
