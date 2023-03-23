﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocTapData.DAO
{
    public class Message_Error
    {
        IDictionary<int, string> data;
        
        public Message_Error()
        {
            data = new Dictionary<int, string>();
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
            data.Add(11, "Số điện thoại không đủ 9 hoặc 10 chữ số!");
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
        }

        public string GetMessage(int key)
        {
            return data[key];
        }
    }
}
