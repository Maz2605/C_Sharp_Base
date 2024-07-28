# Buổi 2
## Biến, kiểu dữ liệu, các toán tử và nhập xuất cơ bản trong 1 chương trình C#
### 1. Biến
- Trong toán học ta đã quá quen thuộc với thuật ngữ `biến`. Nếu biến số trong toán học là một số có thể thay đổi thì trong lập trình biến cũng được định nghĩa tương tự:

    - Là một giá trị dữ liệu có thể thay đổi được.

    - Là tên gọi tham chiếu đến một vùng nhớ nào đó trong bộ nhớ.

    - Là thành phần cốt lõi của một ngôn ngữ lập trình.
- Vậy tại sao phải sử dụng `biến`?

    - Lưu trữ dữ liệu và tái sử dụng: Hãy tưởng tượng nếu bạn yêu cầu người nhập vào tuổi của họ, nhưng bạn không lưu trữ lại thì đến khi bạn muốn sử dụng thì chẳng biết lấy đâu ra để sử dụng cả.

    - Thao tác với bộ nhớ một cách dễ dàng:

        - Cấu trúc của bộ nhớ bao gồm nhiều ô nhớ liên tiếp nhau, mỗi ô nhớ có một địa chỉ riêng (địa chỉ ô nhớ thường là mã hex (thập lục phân)).

        - Khi muốn sử dụng ô nhớ nào (cấp phát, hủy, lấy giá trị, . . .) bạn phải thông qua địa chỉ của chúng. Điều này làm cho việc lập trình trở nên khó khăn hơn.

        - Thay vào đó bạn có thể khai báo một biến và cho nó tham chiếu đến ô nhớ bạn cần quản lý rồi khi sử dụng bạn sẽ dùng tên biến bạn đặt chứ không cần dùng địa chỉ của ô nhớ đó nữa.
- `Khai báo biến`: 

    - Cú pháp: <Kiểu dữ liệu>  <Tên biến>;

    Trong đó:

    - <Kiểu dữ liệu> có thể là:

        - Kiểu dữ liệu cơ bản.

        - Kiểu dữ liệu có cấu trúc
    - <Tên biến> :

        - Là tên do người dùng đặt.

        - Phải tuân thủ theo quy tắc đặt tên.

- `Quy tắc đặt tên biến`: tên biến có thể chứa chữ, số và ký tự _ nhưng ký tự đầu tiên của tên biến không được dùng số, tên biến trong C# có phân biệt chữ hoa chữ thường. Hãy đặt tên biến sao cho nó ngắn gọn nhưng gọi nhớ đến thông tin dữ liệu biến đó lưu trữ. Ví dụ như studentName, studentAge ... sẽ hay hơn abc, xyz ... Ngoài ra cũng không đặt tên biến trùng với những từ khóa dành riêng cho câu lệnh C#
- Một số quy tắc chung các lập trình viên đặt ra để dễ dàng quản lý và giúp người khác dễ dàng đọc hiểu:
    - `Quy tắc Lạc Đà (camelCase)`: 
         - Viết thường từ đầu tiên và viết hoa chữ cái đầu tiên của những từ tiếp theo.

        - Thường được dùng để đặt tên cho các biến có phạm vi truy cập là private hoặc protected và các tham số của hàm.
    - `Quy tắc Pascal`:
        - Viết hoa chữ cái đầu tiên của mỗi từ.

        - Thường được dùng để đặt tên cho những thành phần còn lại như hàm, Interface, Enum, Sự kiện, . . .
### 2. Biến toàn cục và biến cục bộ 
- `Biến toàn cục` là biến được khai báo ở phân cấp cao hơn vị trí đang xác định.

- `Biến cục bộ` là biến được khai báo ở cùng phân cấp tại vị trí đang xác định.

- Vòng đời của biến toàn cục và biến cục bộ bắt đầu khi khối lệnh chứa nó bắt đầu `(khối lệnh bắt đầu bằng dấu “{“)` và kết thúc khi khối lệnh chứa nó kết thúc `(khối lệnh kết thúc bằng dấu “}”)`.

- `Biến cục bộ` được ưu tiên sử dụng hơn `biến toàn cục` trong trường hợp 2 biến này trùng tên.

```C#
class Program
{
    // biến toạn cục của các hàm nằm trong class Program
    // biến cục bộ của class Program
    static int value = 5;
    static void Main(string[] args)
    {
        //biến cục bộ
        int value_1 = 10;
        Console.WriteLine(value_1);
        // in ra màn hình biến toàn cục
        Console.WriteLine(value);
        PrintSomeThing();
        Console.ReadKey();
    }

    static void PrintSomeThing()
    {           
        // in ra màn hình biến toàn cục
        Console.WriteLine(value);
    }
}
```
Lưu ý: 
- Parameter chính là một biến cục bộ.
- Biến cục bộ có phạm vi sử dụng bên trong cặp dấu ngoặc nhọn { }.

### 3. Kiểu dữ liệu
+ Kiểu dữ liệu:

    - Là tập hợp các nhóm dữ liệu có cùng đặc tính, cách lưu trữ và thao tác xử lý trên trường dữ liệu đó.

    - Là một tín hiệu để trình biên dịch nhận biết kích thước của một biến (ví dụ như int là 4 bytes) và khả năng lưu trữ của nó (ví dụ biến kiểu int chỉ có thể chứa được các số nguyên).

    - Là thành phần cốt lõi của một ngôn ngữ lập trình.

+ Tại sao phải có kiểu dữ liệu?

    - Như trong định nghĩa đã trình bày, phải có kiểu dữ liệu để nhận biết kích thước và khả năng lưu trữ của một biến.

    - Nhằm mục đích phân loại dữ liệu. Nếu như không có kiểu dữ liệu ta rất khó xử lý vì không biết biến này kiểu chuỗi hay kiểu số nguyên hay kiểu số thực, . . .


 Phân loại kiểu dữ liệu:

+ Trong C#, kiểu dữ liệu được chia thành 2 tập hợp kiểu dữ liệu chính:

    - Kiểu dữ liệu dựng sẵn (built - in) mà ngôn ngữ cung cấp.
    - Kiểu dữ liệu do người dùng định nghĩa (user - defined).

+ Mỗi tập hợp kiểu dữ liệu trên lại phân thành 2 loại:

    - Kiểu dữ liệu giá trị (value): Một biến khi khai báo kiểu dữ liệu giá trị thì vùng nhớ của biến đó sẽ chứa giá trị của dữ liệu và được lưu trữ trong vùng nhớ Stack (vùng nhớ do máy tính quản lý, tự động giải phóng khi không cần nữa).

    - Kiểu dữ liệu tham chiếu (reference): Một biến khi khai báo kiểu dữ liệu tham chiếu thì vùng nhớ của biến đó chỉ chứa địa chỉ của đối tượng dữ liệu và lưu trong vùng nhớ Stack.

Các kiểu dữ liệu cơ bản trong C#

+ Kiểu số nguyên : 

    - `byte` : 1 byte : số nguyên dương không dấu có giá trị từ 0 đến 255

    - `sbyte` : 1 byte : số nguyên có dấu có giá trị từ -128 đến 127

    - `short` : 2 bytes : Số nguyên có dấu có giá trị từ -32,768 đến 32,767

    - `ushort` : 2 bytes : Số nguyên không dấu có giá trị từ 0 đến 65,535

    - `int` : 4 bytes : Số nguyên có dấu có giá trị từ -2,147,483,647 đến 2,147,483,647

    - `uint` : 4 bytes : Số nguyên không dấu có giá trị từ 0 đến 4,294,967,295

    - `long` : 8 bytes : Số nguyên có dấu có giá trị từ -9,223,370,036,854,775,808 đến 9,223,370,036,854,775,807

    - `ulong` : 8 bytes : Số nguyên không dấu có giá trị từ 0 đến 18,446,744,073,709,551,615

+ Kiểu số thực : 

    - `float` : 4 bytes : Kiểu số thực dấu chấm động có giá trị dao động từ 3.4E – 38 đến 3.4E + 38, với 7 chữ số có nghĩa

    - `double` : 8 bytes : Kiểu số thực dấu chấm động có giá trị dao động từ 3.4E – 38 đến 3.4E + 38, với 7 chữ số có nghĩa

    - `decimal` : 16 bytes : Có độ chính xác đến 28 con số và giá trị thập phân, được dùng trong tính toán tài chính

+ Kiểu ký tự : 

    - `char` : 2 bytes : Chứa 1 ký tự thuộc bảng mã Unicode

+ Kiểu logic (kiểu luận lý)

    - `bool` : 1 byte : Chứa 1 trong 2 giá trị logic là true hoặc false (1 và 0)
+ Kiểu đối tượng `object`, biểu diễn các đối tượng C#, nó là kiểu cơ sở - mọi đối tượng C# đều kế thừa từ kiểu này.

 Lưu ý khi sử dụng kiểu dữ liệu 

- Khác với những kiểu dữ liệu trên, `string` là kiểu dữ liệu tham chiếu và dùng để lưu chuỗi ký tự.


- Kiểu dữ liệu  có miền giá trị `lớn hơn` sẽ chứa được kiểu dữ liệu có miền giá trị `nhỏ hơn`. Như vậy biến kiểu dữ liệu `nhỏ hơn` có thể gán giá trị qua biến kiểu dữ liệu `lớn hơn` (sẽ được trình bày trong phần tiếp theo).

- Giá trị của kiểu `char` sẽ nằm trong dấu ‘ ’ (nháy đơn).

- Giá trị của kiểu `string` sẽ nằm trong dấu “ ” (nháy kép).

- Giá trị của biến kiểu `float` phải có chữ F hoặc f làm hậu tố.

- Giá trị của biến kiểu `decimal` phải có chữ m hoặc M làm hậu tố.

- Trừ kiểu `string`, tất cả kiểu dữ liệu trên đều không được có giá trị `null`. `Null` là giá trị rỗng, không tham chiếu đến vùng nhớ nào. Để có thể gán giá trị `null` cho biến thì ta thêm ký tự ? vào sau tên kiểu dữ liệu là được. Ví dụ: int? hay bool? . . .

Ví dụ chương trình sử dụng kiểu dữ liệu :
```C#

static void Main(string[] args)
{
    // Kiểu số nguyên
    byte BienByte = 10;
    short BienShort = 10;
    int BienInt = 10;
    long BienLong = 10;

    // Kiểu số thực
    float BienFloat = 10.9f; // Giá trị của biến kiểu float phải có hậu tố f hoặc F. 
    double BienDouble = 10.9; // Giá trị của biến kiểu double không cần hậu tố.
    decimal BienDecimal = 10.9m; // Giá trị của biến kiểu decimal phải có hậu tố m.

    // Kiểu ký tự và kiểu chuỗi
    char BienChar = 'K'; // Giá trị của biến kiểu ký tự nằm trong cặp dấu '' (nháy đơn).
    string BienString = "Kteam"; // Giá trị của biến kiểu chuỗi nằm trong cặp dấu "" (nháy kép).

    Console.ReadKey();
}
```
Ví dụ một số lỗi thường gặp
```C#
static void Main(string[] args)
{
    int a;
    Console.WriteLine(" a = " + a); // Lỗi vì biến a không thể sử dụng khi chưa có giá trị.

    int b = 10.9; // Lỗi vì b là biến kiểu số nguyên nên không thể nhận giá trị ngoài số nguyên.

    byte c = 1093; // Lỗi vì c là biến kiểu byte mà kiểu byte có miền giá trị từ -128 đến 127 nên không thể nhận giá ngoài vùng này được.

    string d = 'K'; // Lỗi vì không thể gán giá trị ký tự vào biến kiểu chuỗi được mặc dù chuỗi có thể hiểu là tập hợp nhiều ký tự. Có thể sửa bẳng cặp dấu "" thay vì ''. 

    long e = null; // Lỗi vì không thể gán null cho biến kiểu long, int, byte, . . .
    long? f = null; // Cách khắc phục là thêm dấu ? vào sau kiểu dữ liệu. Lúc này kiểu dữ liệu của f là long?

    int g = 10;
    byte h = g; // Lỗi vì giá trị của biến có kiểu dữ liệu lớn hơn không thể gán cho biến có kiểu dữ liệu nhỏ hơn mặc dù trong trường hợp này ta thấy số 10 đều có thể gán cho 2 biến.

    string k = "Pi";
    Console.WriteLine(" k = " + K); // Lỗi vì phía trên khai báo biến k còn khi sử dụng là biến K 

    Console.ReadKey();
}
```
### 4. Các toán tử
a, Toán tử là gì?

- `Toán tử` là một công cụ để thao tác với dữ liệu.

- Một toán tử là một ký hiệu dùng để đại diện cho một thao tác cụ thể được thực hiện trên dữ liệu.

- Có 6 loại toán tử cơ bản:

    - Toán tử toán học.
    - Toán tử quan hệ.
    - Toán tử logic.
    - Toán tử khởi tạo và gán.
    - Toán tử so sánh trên bit.
    - Toán tử khác.

b, Cú pháp và ý nghĩa các toán tử
- Toán tử toán học:
    - Toán tử `'+'` : Thực hiện cộng 2 toán hạng.

    - Toán tử `'-'` : Thực hiện trừ 2 toán hạng.

    - Toán tử `'*'` : Thực hiện nhân 2 toán hạng.

    - Toán tử `'/'` : Thực hiện chia lấy phần nguyên 2 toán hạng nếu chúng là số nguyên, ngược lại thì chia như bình thường.

    - Toán tử `'%'` : Thực hiện chia lấy dư 2 toán hạng.

    - Toán tử `"++"` : Tăng giá trị của toán hạng lên 1 đơn vị

    - Toán tử `"--"` : Giảm giá trị của toán hạng đi 1 đơn vị

    + Lưu ý: đối với toán tử `++` và `--` cần phần biệt `a++` và `++a` (hoặc a-- và --a):

    - `a++`: là sử dụng giá trị của biến a để thực hiện biểu thức trước rồi mới thực hiện tăng lên 1 đơn vị. Tương tự cho a--.

    - `++a`: là tăng giá trị biến a lên 1 đơn vị rồi mới sử dụng biến a để thực hiện biểu thức. Tương tự cho --a.
- Toán tử quan hệ:
    - Toán tử `"=="` : So sánh 2 toán hạng có bằng nhau hay không. Nếu bằng thì trả về true nếu không bằng thì trả về false, VD : a == b sẽ trả về false

    - Toán tử `"!="` : So sánh 2 toán hạng có bằng nhau hay không. Nếu không bằng thì trả về true nếu bằng thì trả về false, VD : a != b sẽ trả về true

    - Toán tử `'>'` : So sánh 2 toán hạng bên trái có lớn hơn toán hạng bên phải hay không. Nếu lớn hơn thì trả về true nếu không lớn hơn thì trả về false, VD : a > b sẽ trả về true

    - Toán tử `'<'` : So sánh 2 toán hạng bên trái có nhỏ hơn toán hạng bên phải hay không. Nếu nhỏ hơn thì trả về true nếu không nhỏ hơn thì trả về false, VD : a < b sẽ trả về false

    - Toán tử `">="` : So sánh 2 toán hạng bên trái có lớn hơn hoặc bằng toán hạng bên phải hay không. Nếu lớn hơn hoặc bằng thì trả về true nếu nhỏ hơn thì trả về false, VD : a >= b sẽ trả về true

    - Toán tử `"<="` : So sánh 2 toán hạng có nhỏ hơn hoặc bằng hay không. Nếu nhỏ hơn hoặc bằng thì trả về true nếu lớn hơn thì trả về false, VD : a <= b sẽ trả về false


Lưu ý:

    - Các toán tử quan hệ này chỉ áp dụng cho số hoặc ký tự.

    - Hai toán hạng hai bên phải cùng loại (cùng là số hoặc cùng là ký tự).

    - Bản chất của việc so sánh 2 ký tự với nhau là so sánh mã ASCII của các ký tự đó. Ví dụ: so sánh ‘A’ và ‘B’ bản chất là so sánh số 65 với 66.

    - Không nên sử dụng các toán tử trên để so sánh các chuỗi với nhau vì bản chất việc so sánh chuỗi là so sánh từng ký tự tương ứng với nhau mà so sánh ký tự là so sánh mã ASCII của ký tự đó như vậy ký tự ‘K’ sẽ khác ký tự ‘k’. Để so sánh hai chuỗi người ta thường dùng hàm so sánh chuỗi đã được hỗ trợ sẵn (sẽ tìm hiểu ở những bài tiếp theo).

- Toán tử logic bao gồm : 

    - Toán tử `"&&"` : Hay còn gọi là toán tử logic AND (và). Trả về true nếu tất cả toán hạng đều mang giá trị true. Và trả về false nếu có ít nhất 1 toán hạng mang giá trị false

    - Toán tử `"||"` : Hay còn gọi là toán tử logic OR (hoặc). Trả về true nếu có ít nhất 1 toán hạng mang giá trị true. Và trả về false nếu tất cả toán hạng đều mang giá trị false.

    - Toán tử `'!'` : Hay còn gọi là toán tử logic NOT (phủ định). Có chức năng đảo ngược trạng thái logic của toán hạng. Nếu toán hạng đang mang giá trị true thì kết quả sẽ là false và ngược lại

Lưu ý:

    - Các toán tử && và || có thể áp dụng đồng thời nhiều toán hạng, ví dụ như: A && B && C || D || K (Thứ tự thực hiện sẽ được trình bày ở phần sau).

    - Các toán hạng trong biểu thức chứa toán tử logic phải trả về true hoặc false.
- Toán tử khởi tạo và gán thường được sử dụng nhằm mục đích lưu lại giá trị cho một biến nào đó. Một số toán tử khởi tạo và gán hay được sử dụng :

    - Toán tử `'='` : Gán giá trị của toán hạng bên phải cho toán hạng bên trái

    - Toán tử `"+="` : Lấy toán hạng bên trái cộng toán hạng bên phải sau đó gán kết quả lại cho toán hạng bên trái

    - Toán tử `"-="` : Lấy toán hạng bên trái trừ toán hạng bên phải sau đó gán kết quả lại cho toán hạng bên trái

    - Toán tử `"*="` : Lấy toán hạng bên trái nhân toán hạng bên phải sau đó gán kết quả lại cho toán hạng bên trái 

    - Toán tử `"/="` : Lấy toán hạng bên trái chia lấy phần nguyên với toán hạng bên phải sau đó gán kết quả lại cho toán hạng bên trái

    - Toán tử `"%="` :  Lấy toán hạng bên trái chia lấy dư với toán hạng bên phải sau đó gán kết quả lại cho toán hạng bên trái

Lưu ý: 
    
    - Toán tử bên trái thường là một biến, còn toán tử bên phải có thể là biến có thể là biểu thức đều được.

    - Một phép toán gán hoặc khởi tạo có thể được sử dụng như là toán hạng bên phải cho một phép gán hoặc khởi tạo khác. Ví dụ:

- Các toán tử khác:
    - Toán tử `"sizeof()"` : Trả về kích cỡ của một kiểu dữ liệu, VD : sizeof(int) sẽ trả về 4

    - Toán tử `"typeof()"` : Trả về kiểu dữ liệu của một lớp, VD : typeof(string) sẽ trả về kiểu dữ liệu System.String

    - Toán tử `"new"` : Cấp phát vùng nhớ mới, áp dụng cho kiểu dữ liệu tham chiếu, VD : DateTime dt = new DateTime() 

    - Toán tử `"is"` : Xác định đối tượng có phải là một kiểu cụ thể nào đó hay không. Nếu đúng sẽ trả về true ngược lại trả về false

    - Toán tử `"as"` : Ép kiểu mà không gây ra lỗi. Nếu ép kiểu không thành công sẽ trả về null

    - Toán tử `"?:"` : Được gọi là toán tử 3 ngôi. Tương đương với cấu trúc điều kiện 

    Cú pháp: (toán hạng 1) ? (toán hạng 2) : (toán hạng 3)

Ý nghĩa: trả về toán hạng 2 nếu toán hạng 1 là true và ngược lại trả về toán hạng 3

c, Mức độ ưu tiên của các toán tử
Độ ưu tiên của các toán tử biểu thị cho việc toán tử nào được ưu tiên thực hiện trước trong câu lệnh. Độ ưu tiên của các toán tử như sau :

- Mức 1 : `,`

- Mức 2 : `=`, `+=`, `-=`, `*=`, `/=`, `%=`, Thực hiện từ phải sang trái

- Mức 3 : `?:`

- Mức 4 : `&&`, `||`, Thực hiện từ trái sang phải

- Mức 5 : `&`, `^`, `|`, Thực hiện từ trái sang phải

- Mức 6 : `==`, `!=`, Thực hiện từ trái sang phải

- Mức 7 : `<`, `<=`, `>`, `>=`, Thực hiện từ trái sang phải

- Mức 8 : `<<`, `>>`, Thực hiện từ trái sang phải

- Mức 9 : `*`, `\`,`%`, Thực hiện từ trái sang phải

- Mức 10 : `+`, `-`, `++`, `--`, `!`, `~`, `new`, `sizeof()`, `typeof()`, Thực hiện từ phải sang trái

- Mức 11 : `()`, `[]`, `.`, Thực hiện từ trái sang phải

Lưu ý : 

    - Bảng thống kê trên chỉ thể hiện những toán tử chúng ta đã học, ngoài ra vẫn còn nhiều toán tử khác những ít khi sử dụng nên không đề cập đến.

    - Từ bảng trên ta có thể rút ra được 1 kinh nghiệm đó là nếu muốn biểu thức nào được thực hiện trước ta chỉ cần nhóm chúng vào cặp ngoặc tròn ( ) là được!
### 5. Nhập xuất cơ bản
Thư viện lớp C# cung cấp sẵn một lớp tên là Console (System.Console) trong đó có chữa một số phương thức tĩnh để nhập / xuất dữ liệu với màn hình dòng lệnh terminal. Một số phương thức bạn có thể sử dụng ngay trong việc in dữ liệu đó là:

- `Console.Write(value)` - in value ra màn hình, nhưng không xuống dòng mới - value có thể là một số, chữ, chuỗi ...
- `Console.WriteLine(value)` - in value ra màn hình, sau đó xuống dòng
- `Console.ForegroundColor` - thuộc tính để gán màu chữ xuất ra, nó có thể gán các màu như - ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.White ...
- `Console.ResetColor()` - đưa Console về màu mặc định

Ví dụ minh họa
```C#
int a = 123;
double b = 567.123;

Console.WriteLine("Biến a = "+ a +" Biến  b = "+ b );
```
Bạn cũng có thể dùng format string để tạo ra chuỗi in ra nhằm giảm thiểu dòng code
```C#
int a = 123;
double b = 567.123;

Console.WriteLine("Biến a = {0}, biến b = {1}", a, b);
```
hoặc có thể 
```C#
int a = 123;
double b = 567.123;

Console.WriteLine($"Biến a = {a}, biến b = {b}");

```
Bên cạnh đó còn các phương thức nhập:
- `Console.ReadLine()` cho phép nhập dữ liệu cho đến khi nhấn Enter, hàm này trả về chuỗi mà người dùng nhập vào. 
- `Console.ReadKey()` trả về ngay thông tin phím bấm khi người dùng bấm, ở trường hợp này để lấy chữ mã người dùng bấm thì viết `Console.ReadKey().KeyChar`

Chú ý:
Mặc định hàm `Console.ReadLine()` trả về string nếu muốn chuỗi đó nhập xong chuyển thành các kiểu dữ liệu khác như int, float ... thì cần các hàm chuyển kiểu, một số hàm đó là:

- `Convert.ToInt32(value)` hoặc `int.Parse(value)`chuyển value thành kiểu int
- `Convert.ToDouble(value)` hoặc `double.Parse(value)` chuyển value thành kiểu double
- `Convert.ToBoolean(value)` chuyển value thành kiểu bool

Ví dụ minh họa
```C#
static void Main(string[] args)
{
    Console.WriteLine("Nhấn một phím và xem kết quả:");
        
    // Sử dụng Console.ReadKey() mà không truyền tham số
    ConsoleKeyInfo keyInfo1 = Console.ReadKey();
        
    // Hiển thị ký tự của phím được nhấn
    Console.WriteLine("\nKý tự của phím được nhấn (không truyền tham số): " + keyInfo1.KeyChar);

    // Sử dụng Console.ReadKey(true) để ẩn hiển thị của phím được nhấn
    ConsoleKeyInfo keyInfo2 = Console.ReadKey(true);
        
    // Hiển thị ký tự của phím được nhấn (ẩn hiển thị)
    Console.WriteLine("\nKý tự của phím được nhấn (sử dụng true): " + keyInfo2.KeyChar);
}
```
```C#
static void Main(string[] args)
{
    int num1;
    Console.Write("Nhập vào 1 số:");
    num1 = int.Parse(Console.ReadLine());
    float num2;
    Console.Write("Nhập vào 1 số:");
    num1 = float.Parse(Console.ReadLine());
    string str1;
    Console.Write("Nhập vào 1 chuỗi: ");
    str1 = Console.ReadLine();
}
```

