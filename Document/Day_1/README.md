# Buổi 1
## Git, GitHub, Các lệnh git cơ bản và Cấu trúc cơ bản của một chương trình C#
### 1. Git và GitHub
- `Git` còn được gọi là Distributed Version Control System (DVCS) hay VCS, là một hệ thống quản lý phiên bản phân tán ra đời vào năm 2005 và trở thành một hệ thống quản lý phiên bản phân tán được sử dụng nhiều nhất hiện nay. Có thể nói Git là một kho lưu trữ chưa toàn bộ lịch sử của người dùng khi sử dụng. 
- `GitHub` là một hệ thống quản lý dự án và phiên bản code, hoạt động giống như một mạng xã hội cho lập trình viên. Các lập trình viên có thể clone lại mã nguồn từ một repository và Github chính là một dịch vụ máy chủ repository công cộng, mỗi người có thể tạo tài khoản trên đó để tạo ra các kho chứa của riêng mình để có thể làm việc.
### 2. Các lệnh git cơ bản 
- `git config`
	Dùng để đặt user name và email của lập trình viên trong main configuration file và để cài đặt các cấu hình cho git tại máy. 
	```
	$git config --global user.name = "Username"
	```
	```
	$git config --global user.email = "Username@gmail.com"
	```
	Lưu ý: --global được sử dụng để áp dụng cho tất cả các projects. Nếu bạn ko sử dụng --global thì settings sẽ chỉ dùng cho riêng project đó.

- `git init`
	Khởi tạo git trong dự án của đã có sẵn.
	``` 
	$git init
	```
	Ngoài ra, bạn có thể tạo một kho lưu trữ trong một thư mục mới bằng cách chỉ định tên project
	```
	$git init [ProjectName]
	```
- `git clone`
	Dùng để sao chép 1 kho lưu trữ có sẵn 
	```
	$git clone [Link repository]
	```
- `git remote`
	Dùng để liên kết đến remote repository (local & trên github)
	``` 
	$git remote add origin [Link repository]
	```
- `git add`
	Dùng để thêm những thay đổi trên project để commit:
	- Add tất cả các thay đổi 
	```
	$git add .
	$git add --all
	```
	- Add thay đổi ở 1 file chỉ định
	```
	$git add namefile.cs
	```
- `git commit`
	Dùng để thêm sẽ tạo snapshot các thay đổi và lưu nó vào thư mục git
	```
	$git commit -m "Thông điệp của bạn"
- `git reset`
	Dùng để xóa các commit đã thay đổi
	- Nếu bạn đã thêm các thay đổi vào staging area bằng git add nhưng chưa commit và muốn hủy bỏ việc thêm này.
	```
	$git reset 
	```
- `git push`
	Dùng để gửi các commit lên các nhánh của kho lưu trữ 
	```
	$git push origin master
	```
	```
	$git push 
	```
- `git pull`
	Dùng để cập nhật các thay đổi từ kho lưu trữ 
	```
	$git pull 
	```
### 3. Cấu trúc cơ bản của một chương trình C#
Examlpe: Chương trình Hello World
``` C#
    namespace Project
    {
        internal class Program
        {
            static void Main(string []args){
                Console.WriteLine("Hello, World");
            }
        }   
    }
```
- `namespace`: khai báo một phạm vi, nó chứa tập hợp các đối tượng liên quan nhau, nhằm mục đích tổ chức code khoa học, dễ quản lý và đặc biệt là tránh xung đột về tên. 
- `class`: 
- `static void Main(string []args)`: hàm Main, chương trình sẽ chạy theo hàm main.(chỉ có 1 hàm main trong 1 Project)
- `Console.WriteLine`: Câu lệnh để xuất thông tin ra màn hình Console

Lưu ý: Trong 1 `Solution` có thể có nhiều Project, mỗi `Project` có thể có nhiều file khác nhau nhưng chỉ có thể có 1 file chứa hàm main mỗi `Project`
	
