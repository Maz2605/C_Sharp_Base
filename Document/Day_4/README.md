# Buổi 4
## Cấu trúc vòng lặp và những từ khóa điều khiển luồng trong C#
### 1. Cấu trúc vòng lặp
Vòng lặp là gì?
- Vòng lặp trong lập trình là một cấu trúc điều khiển cho phép thực hiện một khối mã lệnh nhiều lần liên tiếp dựa trên một điều kiện nhất định. Vòng lặp giúp giảm thiểu việc viết mã lặp lại nhiều lần, giúp mã nguồn trở nên ngắn gọn và dễ bảo trì hơn. 
#### a, Vòng lặp for
Cú pháp: 
```C#
for (initialzation; condition; interation)
{
  //Các câu lệnh trong khối
}
```
Trong đó: 
- Các phần `initialization`; `condition`; `interation` là một câu lệnh riêng và hoàn toàn có thể để trống
- `initialiazation` là phần biến được khởi tạo trong vòng lặp và chỉ tồn tại ở trong vòng lặp đó 
- `condition` là biểu trức dạng `bool` (trả về true hoặc false) để xét vòng lặp tiếp tục hay không.
- `ỉnteration` là cập nhật giá trị biến sau mỗi một vòng lặp
Tiến trình:
- Ban đầu trình biên dịch sẽ di vào phần `initialization` chạy đoạn lệnh khởi tạo.
- Tiếp theo kiểm tra `condition` nếu == true thì sẽ thực hiện khối lệnh bên trong vòng lặp for. 
- Sau đó lại kiểm tra `condition` nếu == true tiếp tục thực hiện đoạn code trong khối lệnh. Đến khi `condition` == false, hoặc gặp từ khóa `break` thì sẽ kết thúc vòng lặp for.

Ví dụ: 
```C#
    for(int i = 1; i < 6; i++){
        Console.WriteLine($"Số hiện tại: {i}");
    }
```
```C#
    for(;;){
        Console.WriteLine("Đây là vòng lặp vô hạn");
    }
```
#### b, Vòng lặp foreach
Thường dùng để duyệt qua tất cả các phần tử trong 1 tập hợp như mảng (array), danh sách(list), hoặc bất kỳ loại dữ liệu nào triển khai IEnumerable.
Cú pháp 
```C#
    foreach (DataType item in collection)
    {
        // Khối mã được thực thi cho từng phần tử trong tập hợp
    }
```
Trong đó: 
- `Datatype`: Kiểu dữ liệu của các phần tử trong `collection`. Thường thì kiểu này sẽ tự động được suy luận bởi trình biên dịch nếu bạn sử dụng từ khóa `var`.
- `item`: Tên biến đại diện cho từng phần tử trong `collection` khi vòng lặp lặp qua.
- `collection`: Tập hợp hoặc đối tượng triển khai `IEnumerable` mà bạn muốn lặp qua.

Tiến trình: 
- Ở vòng lặp đầu tiên sẽ gán giá trị của `phần tử đầu tiên` trong `collection` vào biến `tạm`.
- Thực hiện khối lệnh bên trong `vòng lặp foreach`.
- Qua mỗi vòng lặp tiếp theo sẽ thực hiện kiểm tra xem đã duyệt hết `collection` chưa. Nếu chưa thì tiếp gán `giá trị của phần tử hiện tại` vào `biến tạm` và tiếp tục thực hiện khối lệnh bên trong.
- Nếu đã duyệt qua hết các phần tử thì vòng lặp sẽ kết thúc.

Ví dụ: 
```C#
    // Khai báo một mảng số nguyên
    int[] numbers = { 10, 20, 30, 40, 50 };

    // Sử dụng vòng lặp foreach để duyệt qua các phần tử trong mảng
    foreach (int number in numbers)
    {
        // In ra giá trị của mỗi phần tử
        Console.WriteLine("Giá trị: " + number);
    }
```

#### c, Vòng lặp while 
Cú pháp
```C#
    while(condition){
        //Khối lệnh lặp 
    }
```
Trong đó: 
- `condition` là một `biểu thức logic` bắt buộc phải có với kết quả trả về bắt buộc là `true` hoặc `false`.
- Từ khóa `while` biểu thị đây là một vòng lặp `while`. Các câu lệnh trong khối lệnh sẽ được lặp lại đến khi không còn thỏa mãn điều kiện lặp sẽ kết thúc vòng lặp `while`.

Tiến trình:
- Đầu tiên trình biên dịch sẽ đi vào dòng `while (condition)`. Kiểm tra điều kiện lặp có thỏa mãn hay không. Nếu kết quả là `true` thì sẽ đi vào bên trong thực hiện khối code. Khi gặp ký tự  `}` sẽ quay lên kiểm tra `condition` và tiếp tục thực hiện khối code. Quá trình chỉ kết thúc khi điều kiện lặp là `false`.
- Điều kiện lặp luôn bằng `true` thì vòng lặp `while` sẽ trở thành `vòng lặp vô tận`.
- Điều kiện lặp luôn bằng `false` thì vòng lặp sẽ không được thực thi.

Ví dụ:
```C#
    int i = 0;

    // Vòng lặp while: lặp khi i nhỏ hơn 5
    while (i < 5)
    {
        Console.WriteLine("Giá trị của i: " + i);
        i++; // Tăng giá trị của i sau mỗi lần lặp
    }
```
#### d, Vòng lặp do - while
Cú pháp: 
```C#
    do{
        //khối lệnh lặp
    }while(condition);
```
Trong đó: 
- `condition` là một biểu thức logic bắt buộc phải có với kết quả trả về bắt buộc là `true` hoặc `false`.
- Từ khóa `do` và `while` biểu thị đây là một `vòng lặp do while`. Các câu lệnh trong khối lệnh sẽ được lặp lại đến khi không còn thỏa mãn điều kiện lặp sẽ kết thúc `vòng lặp do while`.
Tiến trình:
- Đầu tiên trình biên dịch sẽ đi vào dòng `do` và thực hiện khối lệnh bên trong. Sau đó khi gặp ký tự `}` sẽ kiểm tra điều kiện lặp có thỏa mãn hay không. Nếu kết quả là `true` thì sẽ quay lại ký tự `{` thực hiện khối lệnh. Quá trình chỉ kết thúc khi điều kiện lặp là `false`.
- Điều kiện lặp luôn bằng `true` thì `vòng lặp do while` sẽ trở thành `vòng lặp vô tận`.
- Điều kiện lặp luôn bằng `false` thì vòng lặp sẽ `không được thực thi`.

Ví dụ: 
```C#
    int i = 0;

    // Vòng lặp do-while: lặp ít nhất một lần, sau đó kiểm tra điều kiện
    do
    {
        Console.WriteLine("Giá trị của i: " + i);
        i++; // Tăng giá trị của i sau mỗi lần lặp
    }
    while (i < 5); // Điều kiện kiểm tra sau khi khối lệnh đã thực thi
```
#### e, Vòng lặp go to 
Cú pháp: 
```C#
    goto label;
```
Trong đó: 
- Trong đó `label` là một nhãn đích đến trong code. Nơi mà code sẽ tiếp tục được thực thi từ đó. Cấu trúc của một label: 
`label_name:`
- `goto` là từ khóa thông báo cho trình biên dịch biết sẽ đi đến `label` ngay sau để tiếp tục thực thi code.

Ví dụ: 
```C#
    int count = 0;

    StartLoop:  // Đây là nhãn (label) để sử dụng với goto

    Console.WriteLine("Count: " + count);
    count++;

    if (count < 5)
    {
        goto StartLoop;  // Nhảy trở lại nhãn StartLoop
    }

    Console.WriteLine("Kết thúc vòng lặp.");
```
### 2. Những từ khóa điều khiển luồng trong C#
#### a, break
Chức năng: Dùng để thoát khỏi `vòng lặp` hoặc cấu trúc `switch case`
#### b, continue
Chức năng: Dùng để bỏ qua phần còn lại của `vòng lặp` và thực hiện `vòng lặp tiếp theo`
#### c, goto
Chức năng: Dùng để nhảy đến một `nhãn` xác định trong mã.
#### d, return
Chức năng: Dùng để kết thúc `phương thức` và trả về giá trị (nếu có) cho lời gọi `phương thức`.
#### e, throw
Chức năng: Dùng để ném ra `một ngoại lệ` (exception) trong quá trình xử lý lỗi.
#### f, try, catch, finally
Chức năng: Dùng để xử lý `các ngoại lệ` trong quá trình thực thi 
### 3. Format code theo chuẩn C#
Phím tắt nhanh trong Visual Studio:
- Format toàn bộ tệp tin: Nhấn `Ctrl + K`, sau đó nhấn `Ctrl + D`.
- Format đoạn code đã chọn: Nhấn `Ctrl + K`, sau đó nhấn `Ctrl + F`.