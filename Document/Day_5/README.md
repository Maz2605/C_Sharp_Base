# Buổi 5
## Phương thức, tham chiếu, tham trị trong C#
### 1. Phương thức trong C#
Hàm là gì?

Khái niệm: `Hàm` là một khối mã độc lập, có thể thực hiện một nhiệm vụ cụ thể và có thể được gọi lại từ nhiều nơi trong chương trình. `Hàm` thường nhận đầu vào (tham số) và có thể trả về một giá trị. `Hàm` được sử dụng để tổ chức và tái sử dụng mã nguồn trong chương trình.

Đặc điểm:
- `Hàm` có thể tồn tại độc lập ngoài bất kỳ lớp nào (điều này áp dụng cho các ngôn ngữ như C, Python, hoặc JavaScript).
- Trong C#, `hàm` thực chất là một `phương thức tĩnh` (static method) và không tồn tại một hàm độc lập ngoài lớp.

Phương thức là gì?

Khái niệm: `Phương thức` là một `hàm` được định nghĩa bên trong một lớp hoặc đối tượng. Nó thực hiện một hành động hoặc nhiệm vụ liên quan đến đối tượng hoặc lớp mà nó thuộc về. `Phương thức` có thể là `phương thức tĩnh` hoặc `phương thức thể hiện`.

Đặc điểm:

- `Phương thức` luôn nằm trong một lớp hoặc đối tượng.
- `Phương thức` có thể truy cập và thao tác trên dữ liệu nội bộ (thuộc tính) của `đối tượng` mà nó thuộc về.
- `Phương thức` có thể là `instance method` (liên kết với một đối tượng cụ thể) hoặc `static method` (liên kết với lớp, không cần đối tượng).

Cú pháp: 
```C#
    accessModifier returnType MethodName(parameterList)
    {
        // Khối mã của hàm
    }
```
Trong đó: 
- `accessModifier`: là từ khóa chỉ định `mức độ truy cập` của phương thức (vd: `private`, `public`, `protected`,...)
- `returnType`: Kiểu dữ liệu trả về của phương thức (vd: `void`, `int`, `float`, `bool`,...)
- `MethodName`: tên của phương thức (tên phải tuân thủ quy tắc đặt tên và nêu được chức năng của phương thức)
- `parameterList`: Danh sách các tham số đầu vào (nếu có), mỗi tham số bao gồm kiểu dữ liệu và tên. Các tham số được phân cách bằng {`,`}. Nếu hàm không có tham số, danh sách này để trống. 

Ví dụ: 
```C#
    public static void PrintString(string str){
        Console.WriteLine($"Đây là chuỗi: {str}");
    }
```
```C#
    public static int SumInt(int a, int b){
        int sum = a + b;
        return sum;
    }
```
### 2. Tham chiếu và tham trị
#### 2.1. Tham trị (Pass by Value)
Khái niệm: Khi một `biến` được truyền vào `phương thức` theo kiểu `tham trị`, `một bản sao` của giá trị của `biến` đó sẽ được `tạo ra và truyền` vào phương thức. Điều này có nghĩa là `phương thức` làm việc với `bản sao` này, không phải với `biến gốc`.

Hệ quả: Mọi thay đổi đối với `biến trong hàm` chỉ ảnh hưởng đến `bản sao`, không ảnh hưởng đến `giá trị của biến gốc` bên ngoài hàm.

Ví dụ: 
```C#
    using System;

    class Program
    {
        static void ChangeValue(int x)
        {
            x = 10; // Thay đổi bản sao, không thay đổi biến gốc
        }

        static void Main()
        {
            int a = 5;
            ChangeValue(a);
            Console.WriteLine(a); // a vẫn bằng 5 sau khi gọi hàm
        }
    }
```
#### 2.2. Tham chiếu (Pass By Reference)
Khái niệm: Khi một `biến` được truyền vào `phương thức` theo kiểu tham chiếu, `phương thức` sẽ nhận được `địa chỉ` của biến đó và làm việc trực tiếp với nó. Điều này có nghĩa là `bất kỳ thay đổi` nào đối với biến trong phương thức đều sẽ ảnh hưởng đến `biến gốc`.

Hệ quả: Mọi thay đổi thực hiện trong `phương thức` sẽ được phản ánh trực tiếp trên `biến gốc`.

##### Tham chiếu với ref
Khái niệm: Tham chiếu `ref` cho phép truyền `biến` vào phương thức với điều kiện `biến` đã `được khởi tạo trước` đó. Phương thức có thể thay đổi giá trị của biến đó, và giá trị mới sẽ được phản ánh ra ngoài phương thức.

Yêu cầu: 
- Biến `phải được khởi tạo trước` khi truyền vào phương thức.
- `Giá trị của biến` có thể được `sử dụng` hoặc `thay đổi` trong phương thức

Ví dụ: 
```C#
    static void UpdateValue(ref int number)
    {
        number = 20;
    }

    static void Main()
    {
        int x = 10; // Biến x phải được khởi tạo
        UpdateValue(ref x);
        Console.WriteLine(x); // Kết quả: 20
    }
```
##### Tham chiếu với out    
Khái niệm: Truyền tham chiếu bằng `out` trong C# là một cơ chế đặc biệt cho phép một `phương thức` trả về `nhiều giá trị` hoặc gán giá trị cho một biến được truyền vào mà không cần khởi tạo trước. Khi sử dụng từ khóa `out`, biến được truyền vào phương thức theo dạng `tham chiếu`, và phương thức `bắt buộc` phải gán giá trị cho biến đó trước khi `kết thúc`.

```C#
    using System;

    class Program
    {
        static void Divide(int dividend, int divisor, out int quotient, out int remainder)
        {
            // Tính toán giá trị thương và số dư
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }

        static void Main()
        {
            int a = 20;
            int b = 3;

            // Khai báo các biến để chứa kết quả từ hàm Divide
            Divide(a, b, out int q, out int r);

            // Hiển thị kết quả
            Console.WriteLine($"Quotient: {q}, Remainder: {r}");
        }
}

```
