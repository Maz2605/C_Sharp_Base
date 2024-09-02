# Buổi 3
## Ép kiểu, hằng và cấu trúc rẽ nhánh trong C#
### 1. Ép kiểu
#### a, Ép kiểu là gì? Tại sao phải ép kiểu
Ép kiểu là gì ?
- Ép kiểu là quá trình biến đổi dữ liệu thuộc kiểu dữ liệu này thành kiểu dữ liệu khác. 

Tại sao phải ép kiểu?

- Để chuyển dữ liệu sang một kiểu dữ liệu mong muốn phục vụ cho việc thao tác xử lý.

- Đưa dữ liệu về định dạng mà mình mong muốn 

Ví dụ: 
- Chuyển kiểu ngày tháng bên Mỹ (tháng đặt trước ngày) sang dạng ngày tháng bên Việt Nam (ngày đặt trước tháng).
- Chuyển 1 chuỗi số thành 1 số để tính toán

#### b, Các dạng ép kiểu và ví dụ 
Trong C# có `4 loại ép kiểu`:
- Chuyển đổi `kiểu ngầm định` (implicit) :Việc chuyển đổi này được thực hiện bởi trình biên dịch và chúng ta không cần tác động gì..

    Được thực hiện khi chuyển kiểu từ: 
    - Kiểu dữ liệu nhỏ sang kiểu dữ liệu lớn hơn (xem lại bài KIỂU DỮ LIỆU TRONG C#)
    - Chuyển từ lớp con đến lớp cha (khái niệm lớp con lớp cha sẽ được trình bày trong bài TÍNH KẾ THỪA TRONG C#).

    Ví dụ: 
    ```C#
    int intValue = 10;
    long longValue = intValue; /* Chuyển kiểu ngầm định vì kiểu long có miền giá trị lớn hơn kiểu int nên có thể chuyển từ int sang long.*/
    float floatValue = 10.9f;
    double doubleValue = floatValue; /* Tương tự vì kiểu double có miền giá trị lớn hơn kiểu float nên~ có thể chuyển từ float sang double.*/ 
    ```
- Chuyển đổi `kiểu tường minh` (explicit): Chuyển đổi kiểu tường minh là việc chuyển kiểu một cách rõ ràng và dùng từ khóa chỉ định chứ không dùng phương thức

    Đặc điểm: 
    - Thường được dùng để chuyển đổi giữa `các kiểu dữ liệu có tính chất tương tự nhau` (thường thì là số).
    - Hỗ trợ trong việc boxing và unboxing đối tượng 
    - Cú pháp ngắn gọn do không sử dụng phương thức.
    - Chỉ khi chúng ta biết rõ biến đó thuộc kiểu dữ liệu nào mới thực hiện chuyển đổi. Ngược lại có thể gây `lỗi` khi chạy chương trình.

    Cú pháp: 
    ```
        (<kiểu dữ liệu>) <biến cần ép kiểu> 
    ```
    Trong đó: 
    - `<kiểu dữ liệu>` là kiểu dữ liệu mà mình muốn chuyển sang.
    - `<biến cần ép kiểu>` là biến chưa dữ liệu cần ép kiểu.
    - Phải có cặp dấu ngoặc tròn `( )`.
    Ví dụ minh họa: 
    ```C#
    double doubleNumber = 123.45;
    int intNumber = (int)doubleNumber; // Ép kiểu tường minh từ double sang int
    Console.WriteLine(intNumber); // Output: 123 (phần thập phân bị cắt bỏ)
    ```
    ```C#
    decimal decimalNumber = 123.45M;
    int intNumber = (int)decimalNumber; // Ép kiểu tường minh từ decimal sang int
    Console.WriteLine(intNumber); // Output: 123 (phần thập phân bị cắt bỏ)
    ```
    Ý nghĩa: 
    - Ép kiểu của `<biến cần ép kiểu>` về `<kiểu dữ liệu>` nếu thành công sẽ trả ra giá trị kết quả ngược lại sẽ báo `lỗi` chương trình. Đặc biệt đối với số:

        - Ta có thực hiện ép `kiểu dữ liệu lớn hơn` về `kiểu dữ liệu nhỏ hơn` mà không báo lỗi.
        - Nếu dữ liệu cần ép kiểu `vượt quá miền giá trị` của `kiểu dữ liệu muốn ép kiểu` về thì chương trình sẽ `tự cắt bit` cho phù hợp với khả năng chứa kiểu dữ liệu đó (cắt từ bên trái qua).

- Sử dụng `phương thức, lớp hỗ trợ sẵn`:
    -  Dùng phương thức Parse(), TryParse().
        - Parse():

            Cú pháp: 
            ```
            <kiểu dữ liệu>.Parse(<dữ liệu cần chuyển đổi>);
            ```
            Trong đó: 
            - `<kiểu dữ liệu>` là kiểu dữ liệu cơ bản mình muốn chuyển đổi sang.
            - `<dữ liệu cần chuyển đổi>` là dữ liệu thuộc kiểu chuỗi, có thể là biến kiểu chuỗi hoặc giá trị hằng kiểu chuỗi

            Ví dụ minh họa: 
            ```C#
            string stringValue = "10";
            int intValue = int.Parse(stringValue); // Chuyển chuỗi stringValue sang kiểu int và lưu giá trị vào biến intValue - Kết quả intValue = 10
            double H = double.Parse("10.9"); // Chuyển chuỗi giá trị hằng "10.9" sang kiểu int và lưu giá trị vào biến H - Kết quả H  = 10.9

            ```
            Ý nghĩa: 
            - Chuyển đổi một chuỗi sang một kiểu dữ liệu cơ bản tương ứng.
            - Phương thức trả về giá trị kết quả chuyển kiểu nếu chuyển kiểu thành công. Ngược lại sẽ báo lỗi chương trình.

        - TryParse():

            Cú pháp: 
            ```
            <kiểu dữ liệu>.TryParse(<dữ liệu cần chuyển đổi>, out <biến chứa kết quả>);
            ```
            Trong đó: 
            - `<kiểu dữ liệu>` là kiểu dữ liệu cơ bản mình muốn chuyển đổi sang.
            - `<dữ liệu cần chuyển đổi>` là dữ liệu thuộc kiểu chuỗi, có thể là biến kiểu chuỗi hoặc giá trị hằng kiểu chuỗi.
            - `<biến chứa kết quả>` là biến mà bạn muốn lưu giá trị kết quả sau khi chuyển kiểu thành công. 
            - Từ khóa `out` là từ khóa bắt buộc phải có

            Ý nghĩa:

            - Chuyển một chuỗi sang một kiểu dữ liệu cơ bản tương ứng.
            - Phương thức sẽ trả về true nếu chuyển kiểu thành công và giá trị kết quả chuyển kiểu sẽ lưu vào <biến chứa kết quả>. Ngược lại sẽ trả về false và <biến chứa kết quả> sẽ mang giá trị 0.

            Ví dụ minh họa: 
            ```C#
                int Result; // Biến chứa giá trị kết quả khi ép kiểu thành công
                bool isSuccess; // Biến kiểm tra việc ép kiểu có thành công hay không
                string Data1 = "10", Data2 = "Nam"; // Dữ liệu cần ép kiểu

                isSuccess = int.TryParse(Data1, out Result); // Thử ép kiểu Data1 về int nếu thành công thì Result sẽ chứa giá trị kết quả ép kiểu và isSuccess sẽ mang giá trị true. Ngược lại Result sẽ mang giá trị 0 và isSuccess mang giá trị false
                Console.Write(isSuccess == true ? " Success !" : " Failed !"); // Sử dụng toán tử 3 ngôi để in ra màn hình việc ép kiểu đã thành công hay thất bại.
                Console.WriteLine(" Result = " + Result); // In giá trị Result ra màn hình

                isSuccess = int.TryParse(Data2, out Result); // Tương tự như trên nhưng thao tác với Data2
                Console.Write(isSuccess == true ? " Success !" : " Failed !"); // Tương tự như trên
                Console.WriteLine(" Result = " + Result); // Tương tự như trên

            ```

        Lưu ý khi dùng Parse() và TryParse():

            - Tham số truyền vào phải là một chuỗi.
            - Cả 2 phương thức được gọi thông qua tên kiểu dữ liệu.
            - Parse() trả về giá trị kết quả ép kiểu nếu ép kiểu không thành công thì sẽ báo lỗi. Còn TryParse() trả về xem ép kiểu có thành công hay không, giá trị kết quả ép kiểu sẽ nằm trong <biến chứa kết quả>.
            - Ngoài TryParse() ra thì vẫn có một cách ép kiểu không báo lỗi chương trình. Đó là sử dụng toán tử as:
                + Trong bài TOÁN TỬ TRONG C# chúng ta có giới thiệu toán tử as dùng để “Ép kiểu mà không gây ra lỗi. Nếu ép kiểu không thành công sẽ trả về null”.
                + Chỉ áp dụng cho việc chuyển kiểu giữa các kiểu tham chiếu tương thích (thường là các kiểu có quan hệ kế thừa (sẽ được trình bày ở bài TÍNH KẾ THỪA TRONG C#)) hoặc các kiểu nullable (là các kiểu có thể chứa giá trị null).
-  Dùng `lớp hỗ trợ sẵn` (Convert):
    - Convert là `lớp tiện ích` được C# hỗ trợ sẵn cung cấp cho chúng ta nhiều phương thức chuyển đổi kiểu dữ liệu.
    - Đặc điểm của các phương thức trong lớp Convert:
        - Tham số truyền vào của các phương thức không nhất thiết là `chuỗi` (có thể là int, bool, . . .).
        - Nếu tham số truyền vào là `null` thì các phương thức sẽ trả về `giá trị mặc định` của kiểu dữ liệu.
        - Các trường hợp tham số truyền vào `sai định dạng` hoặc vượt quá giới hạn thì chương trình sẽ báo lỗi như phương thức Parse().

    Ví dụ minh họa
    ```C#
    double doubleValue = 123.45;
    int intNumber = Convert.ToInt32(doubleValue); // Sử dụng Convert để chuyển từ double sang int
    Console.WriteLine(intNumber); // Output: 123 (phần thập phân bị cắt bỏ)
    ```
    ```C#
     // Chuyển đổi từ double sang long
    double doubleValue = 123456789012345.67;
    long longNumber = Convert.ToInt64(doubleValue);
    Console.WriteLine($"Double to Long: {longNumber}"); // Output: 123456789012345
    ```
    ToInt32() tương đương với kiểu int còn ToInt64 tương đương với kiểu long
- Người dùng `tự định nghĩa` kiểu chuyển đổi: Khi chúng ta tạo ra một `kiểu dữ liệu` mới chúng ta cũng cần định nghĩa các chuyển đổi kiểu dữ liệu từ kiểu cơ bản sang kiểu tự định nghĩa và ngược lại.(tìm hiểu rõ hơn về phần này ở bài class)
### 2. Hằng
Hằng số là gì?

- `Hằng số` lưu trữ các giá trị mà `không thay đổi` được nữa, dùng từ khóa `const` để khai báo hằng số (như khai báo, khởi tạo biến nhưng phía trước có từ khóa const)

Tại sao lại phải có hằng?

- Để ngăn chặn việc gán giá trị khác vào biến.

- Hằng làm cho chương trình dễ đọc hơn bằng cách biến những con số vô cảm thành những tên có nghĩa.

- Hằng giúp cho chương trình dễ nâng cấp, dễ sửa chữa hơn.

- Hằng giúp cho việc tránh lỗi dễ dàng hơn. Nếu bạn vô ý gán giá trị cho một biến hằng ở đâu thì trình biên dịch sẽ báo lỗi ngay lập tức.

Ví dụ minh họa:
```C#
    // Khai báo hằng số số nguyên
    const int MaxValue = 100;
     // Khai báo hằng số số thực
    const double Pi = 3.141592653589793;
```
### 3. Cấu trúc rẽ nhánh 
#### a, Cấu trúc if - else
Cấu trúc if
```C#
    if (condition){
         //Câu lệnh hoặc khối lệnh thi hành nếu điều_kiện là đúng
    }
```
+ Trong đó :

- `if` là từ khóa bắt buộc.
- `condition` là biểu trức dạng `bool` (trả về true hoặc false).

Ví dụ minh họa: 
```C#
    int number = 10;

    if (number > 0)
    {
        Console.WriteLine($"{number} là số dương");
    }
```
Cấu trúc if - else
```C#
    if (condition)
    {
        //Câu lệnh thi hành nếu điều_kiện là đúng
    }
    else
    {
        //Câu lệnh thi hành nếu điều_kiện là sai
    }
```
Trong đó: 
- `if`, `else` là từ khóa bắt buộc.
- `condition` là biểu trức dạng `bool` (trả về true hoặc false).

Ví dụ minh họa:
```C#
    int number = -5;

        if (number > 0)
        {
            Console.WriteLine($"{number} là số dương");
        }
        else
        {
            Console.WriteLine($"{number} là số không hoặc số âm");
        }
```

Sau else bạn có thể bắt đầu ngay một lệnh if khác để tạo ra cấu trúc if else, kiểm tra nhiều trường hợp

Ví dụ minh họa: 
```C#
    int number = 0;

    if (number > 0)
    {
        Console.WriteLine($"{number} là số dương");
    }
    else if (number < 0)
    {
        Console.WriteLine($"{number} là số âm");
    }
        else
    {   
        Console.WriteLine($"{number} là số không");
    }
```
Các cấu trúc if - else có thể lồng vào nhau để xét những trường hợp phức tạp

Ví dụ minh họa: 
```C#
    int a = 5;
    int b = 10;

    if (a > 0)
    {
        if (b > 0)
        {
            Console.WriteLine("Cả a và b đều là số dương");
        }
        else
        {
            Console.WriteLine("a là số dương, nhưng b không phải là số dương");
        }
    }
    else
    {
        Console.WriteLine("a không phải là số dương");
    }
```
#### b, Toán tử ba ngôi
```C#
    Datatype variable = (condition) ? value1 : value2; 
```
Trong đó:
- `Datatype` : Kiểu dữ liệu của biến trả về kết quả
- `variable`: Biến trả về kết quả
- `condition`: biểu trức dạng bool (trả về true hoặc false)
- `value1`: Giá trị trả về biến nếu như điều kiện đúng
- `value2`: Giá trị trả về biến nếu như điều kiện sai

Ví dụ minh họa:
```C#
    int a = 5, b = 10;
    int max = (a > b) ? a : b;
    Console.WriteLine("Max value: " + max); // Output: Max value: 10
```
#### c, Cấu trúc Switch - Case
```C#
switch (experssion)
{
    case value1:
        //Cách lệnh thi  hành nếu biểu thức == value1
        break;
    case value2:
        //Cách lệnh thi  hành nếu biểu thức == value2
        break;  
    case valuei:
        // Cách lệnh thi  hành nếu biểu thức == valuei
        break;
    default:
        //Các lệnh thực thi nếu biểu thức không giống bất kỳ giá trị nào
        break;
}
```

Trong đó: 
- `switch`, `case` là từ khóa bắt buộc.
- `break` là một lệnh nhảy: Ý nghĩa của nó là thoát ra khỏi cấu trúc, vòng lặp chứa nó
- `experssion` phải là biểu thức trả về kết quả kiểu:
    - `Số nguyên` (int, long, byte, . . .)
    - `Ký tự` hoặc `chuỗi` (char, string)
    - Kiểu `liệt kê` (enum )
- `valuei` với i = 1..n là giá trị muốn so sánh với giá trị của `experssion`.

Ví dụ minh họa: 
```C#
    int day = 3;

    switch (day)
    {
        case 1:
            Console.WriteLine("Chủ Nhật");
            break;
        case 2:
            Console.WriteLine("Thứ Hai");
            break;
        case 3:
            Console.WriteLine("Thứ Ba");
            break;
        case 4:
            Console.WriteLine("Thứ Tư");
            break;
        case 5:
            Console.WriteLine("Thứ Năm");
            break;
        case 6:
            Console.WriteLine("Thứ Sáu");
            break;
        case 7:
            Console.WriteLine("Thứ Bảy");
            break;
        default:
            Console.WriteLine("Ngày không hợp lệ");
            break;
    }
```