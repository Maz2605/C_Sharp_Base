# Buổi 6
## Mảng và chuỗi trong C#
### 1. Mảng  
#### 1.1. Mảng 1 chiều       
Khái niệm: 
- Tập hợp các đối tượng có cùng kiểu dữ liệu.
- Mỗi đối tượng trong mảng được gọi là một phần tử.
- Các phần tử phân biệt với nhau bằng chỉ số phần tử. Trong C# chỉ số phần tử là các số nguyên không âm và bắt đầu từ 0,1,2,3…

Đặc điểm: 
- Các phần tử trong mảng dùng chung một tên và được truy xuất thông qua chỉ số phần tử.
- Một mảng cần có giới hạn số phần tử mà mảng có thể chứa.
- Phải cấp phát vùng nhớ mới có thể sử dụng mảng.
- Vị trí ô nhớ của các phần tử trong mảng được cấp phát liền kề nhau.

Lợi ích của mảng: 
- Gom nhóm các đối tượng có chung tính chất lại với nhau giúp code gọn gàng hơn.
- Để thao tác, dễ quản lý, nâng cấp sửa chữa. Vì lúc này việc thay đổi số lượng sinh viên ta chỉ cần thay đổi số phần tử của mảng là được.
- Dễ dàng áp dụng các cấu trúc lặp vào để xử lý dữ liệu.

Cú pháp: 
```C#
    //Khai báo
    dataType[] arrayName;
    //Khởi tạo 
    arrayName = new DataType[size];
    //Khai báo và khởi tạo
    dataType[] arrayName = new dataType[size];
    //Khai báo và khởi tạo 1 mảng và thêm giá trị sẵn
    dataType[] arrayName = new dataType[] { value1, value2, ..., valueN };
    //Gán giá trị cho 1 phần tử trong mảng
    arrayName[index] = value;

```
Trong đó: 
- `DataType`: là kiểu dữ liệu của tất cả các phần tử trong mảng
- `[]`: ký hiệu khai báo mảng 1 chiều
- `arrayName`: tên của mảng  
- `size`: số lượng phần tử có trong mảng
- `index`: chỉ số của phần tử có trong mảng
- value1, value2, ..., valueN: Các giá trị ban đầu của các phần tử trong mảng.

Ví dụ: 
```C#
    //Khai báo 1 mảng
    int[] numbers;
    //Khởi tạo 1 mảng
    numbers = new int[5];
    // Khai báo và khởi tạo mảng một chiều với 5 phần tử
    bool[] checkList = new bool[5];
    //Khai báo và khởi tạo mảng thêm các giá trị sẵn
    string[] fruits = new string[] {"Táo", "Cam", "Xoài", "Nho", "Dâu"};
    //hoặc có thể rút gọn lại như thế này 
    string[] fruits = {"Táo", "Cam", "Xoài", "Nho", "Dâu"};
    //Gán giá trị cho 1 phần tử trong mảng
    numbers[0] = 155;
```

#### 1.2. Mảng nhiều chiều 
Khái niệm:  
