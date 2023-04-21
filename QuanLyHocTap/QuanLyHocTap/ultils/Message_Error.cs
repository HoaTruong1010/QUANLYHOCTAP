using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocTap.ultils
{
    public class Message_Error
    {
        IDictionary<int, string> data;
        
        public Message_Error()
        {
            data = new Dictionary<int, string>();
            data.Add(-7, "Thông tin điểm không hợp lệ!");
            data.Add(-6, "Thông tin sinh viên không hợp lệ!");
            data.Add(-5, "Thông tin lớp học không hợp lệ!");
            data.Add(-4, "Thông tin môn học không hợp lệ!");
            data.Add(-3, "Thông tin giảng viên không hợp lệ!");
            data.Add(-2, "Cập nhật thất bại!");
            data.Add(-1, "Thêm thất bại!");
            data.Add(1, "Mã giảng viên chưa đủ 8 ký tự!");
            data.Add(2, "Mã giảng viên không quá 8 ký tự!");
            data.Add(3, "Họ và tên giảng viên không được trống!");
            data.Add(4, "Họ và tên giảng viên không quá 27 ký tự!");
            data.Add(5, "Giảng viên không được dưới 18 tuổi!");
            data.Add(6, "Số căn cước công dân không đủ 9 hoặc 12 chữ số!");
            data.Add(7, "Email không hợp lệ!");
            data.Add(8, "Địa chỉ không được trống!");
            data.Add(9, "Địa chỉ không quá 100 ký tự!");
            data.Add(10, "Không tìm thấy nội dung phù hợp!");
            data.Add(11, "Số điện thoại không đủ 10 chữ số!");
            data.Add(12, "Mã giảng viên đã tồn tại!");

            data.Add(13, "Mã môn học chưa đủ 6 ký tự!");
            data.Add(14, "Mã môn học không quá 6 ký tự!");
            data.Add(15, "Mã môn học đã tồn tại!");
            data.Add(16, "Tên môn học không được trống!");
            data.Add(17, "Tên môn học không quá 25 ký tự!");
            data.Add(18, "Tên môn học đã tồn tại!");

            data.Add(19, "Mã lớp chưa đủ 8 ký tự!");
            data.Add(20, "Mã lớp không quá 8 ký tự!");
            data.Add(21, "Mã lớp đã tồn tại!");
            data.Add(22, "Tên lớp không được trống!");
            data.Add(23, "Tên lớp không quá 20 ký tự!");
            data.Add(24, "Tên lớp đã tồn tại!");

            data.Add(25, "Mã sinh viên chưa đủ 10 ký tự!");
            data.Add(26, "Mã sinh viên không quá 10 ký tự!");
            data.Add(27, "Mã sinh viên đã tồn tại!");
            data.Add(28, "Sinh viên chưa đủ 17 tuổi!");
            data.Add(29, "Lớp đã đủ số lượng!");
            data.Add(30, "Họ và tên sinh viên không được trống!");
            data.Add(31, "Họ và tên sinh viên không quá 27 ký tự!");

            data.Add(32, "Môn học đã được đăng ký!\nVui lòng đăng ký lại sau 12 tuần kể từ lần đăng ký trước!");

            data.Add(33, "Điểm không được lớn hơn 10.0!");
            data.Add(34, "Điểm không được bé hơn 0.0!");

            data.Add(35, "Không có phổ điểm cho thời gian này!\nVui lòng chọn lại thời gian!");

            data.Add(36, "Lưu ý: Khi xóa giảng viên này thì các thông tin liên quan đến giảng viên này cũng sẽ bị xóa theo!\n\n" +
                "Bạn có chắc chắn xóa?");
            data.Add(37, "Lưu ý: Khi xóa môn học này thì các thông tin liên quan đến môn học này cũng sẽ bị xóa theo!\n\n" +
                "Bạn có chắc chắn xóa?");
            data.Add(38, "Bạn có chắc chắn xóa?");
            data.Add(39, "Lưu ý: Khi xóa lớp học này thì các thông tin liên quan đến lớp học này cũng sẽ bị xóa theo!\n\n" +
                "Bạn có chắc chắn xóa?");
            data.Add(40, "Lưu ý: Khi xóa sinh viên này thì các thông tin liên quan đến sinh viên này cũng sẽ bị xóa theo!\n\n" +
                "Bạn có chắc chắn xóa?");
        }

        public string GetMessage(int key)
        {
            return data[key];
        }
    }
}
