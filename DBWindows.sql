create database DBWindows
go

use DBWindows
go

create table TAIKHOAN
(
	tenDangNhap nvarchar(20) primary key not null,
	matKhau nvarchar(40),
	Quyen int
)
create table THISINH
(
	maThiSinh nvarchar(20) primary key not null,
	tenThiSinh nvarchar(40),
	gioiTinh bit,
	soCMT nvarchar(13),
	tenDangNhap nvarchar(20),
	constraint FKTS1 foreign key(tenDangNhap)
		references TAIKHOAN(tenDangNhap)
)
create table CAUHOI
(
	maCauHoi nvarchar(3) primary key not null,
	cauHoi nvarchar(1000)
)

create table DAPAN
(
	maDA nvarchar(3) not null,
	noiDungDA nvarchar(300),
	dung int,
	maCauHoi nvarchar(3) not null,
	constraint PKDA primary key(maDA,noiDungDA),
	constraint FKDA foreign key(maCauHoi)
		references CAUHOI(maCauHoi)
)

create table KETQUA
(
	maThiSinh nvarchar(20),
	ketQua int,
	constraint PKKQ primary key(maThiSinh,ketQua),
	constraint FKKQ foreign key(maThiSinh)
		references THISINH(maThiSinh)
)
create procedure pr_taotaikhoan
	@mathisinh varchar(20),
	@hotenthisinh nvarchar(40),
	@gioitinh bit,
	@socmt nvarchar(13),
	@username varchar(20)
as
begin
	insert into TAIKHOAN values(@mathisinh,'123456',0)
	insert into THISINH values(@mathisinh,@hotenthisinh,@gioitinh,@socmt,@mathisinh)
end
go

--cau lenh insert tai khoan va thi sinh
insert into TAIKHOAN values('Admin','123',1)
-- tai khoan cua thi sinh 
insert into TAIKHOAN values('tsdemo','123456',0)
insert into THISINH values('tsdemo','Le Dang Quang',1,'038200010414','tsdemo')

-- cau lenh insert cau hoi
insert into CAUHOI values('01',N'Khái niệm đường bộ được hiểu như thế nào ?')
insert into CAUHOI values('02',N'Vạch kẻ đường được hiểu như thế nào là đúng ?')
insert into CAUHOI values('03',N'Khái niệm "Làn đường" được hiểu thế nào là đúng ?')
insert into CAUHOI values('04',N'Khái niệm "Đường phố" được hiểu như thế nào là đúng ?')
insert into CAUHOI values('05',N'Khái niệm "Dải phân cách" được hiểu như thế nào là đúng ?')
insert into CAUHOI values('06',N'Phương tiện giao thông đường bộ gồm những loại nào ?')
insert into CAUHOI values('07',N'Phương tiện tham gia giao thông đường bộ gồm những loại nào ?')
insert into CAUHOI values('08',N'Người tham gia giao thông đường bộ gồm những đối tượng nào?')
insert into CAUHOI values('09',N'Những hành vi nào ở dưới đây bị nghiêm cấm ?')
insert into CAUHOI values('10',N'Người điều khiển xe mô tô, xe gắn máy trên đường mà máu có nồng độ cồn vượt quá bao nhiêu thì bị cấm ?')
insert into CAUHOI values('11',N'Người điều khiển xe mô tô, xe gắn máy trên đường mà trong khí thở có nồng độ cồn vượt quá bao nhiêu thì bị cấm ?')
insert into CAUHOI values('12',N'Hành vi giao xe cơ giới, xe máy chuyên dùng cho người không đủ điều kiện để điều khiển xe tham gia giao thông có bị nghiêm cấm hay không ?')
insert into CAUHOI values('13',N'Hành vi điều khiển xe cơ giới chạy quá tốc độ quy định, giành đường, vượt ẩu có bị nghiêm cấm hay không ?')
insert into CAUHOI values('14',N'Hành vi nào sau đây bị nghiêm cấm ?')
insert into CAUHOI values('15',N'Hành vi bỏ trốn sau khi gây tai nạn để trốn tránh trách nhiệm hoặc khi có điều kiện mà không giúp người bị tai nạn có bị nghiêm cấm hay không ?')
insert into CAUHOI values('16',N'Việc sản xuất, mua bạn, sử dụng biển số xe cơ giới, xe máy chuyên dùng được quy định như thế nào trong Luật giao thông đường bộ ?')
insert into CAUHOI values('17',N'Người điều khiển xe mô tô 2 bánh, 3 bánh, xe gắn máy, có được sử dụng xe để kéo, đẩy các xe khác khi tham gia giao thông hay không ?')
insert into CAUHOI values('18',N'Người ngồi trên xe mô tô 2 bánh, 3 bánh,xe gắn máy không được thực hiện hành vi nào dưới đây?')
insert into CAUHOI values('19',N'Người ngồi trên xe mô tô 2 bánh, 3 bánh, xe gắn máy khi tham gia giao thông có được mang vác vật cồng kềnh hay không ?')
insert into CAUHOI values('20',N'Bảo đảm trật tự, an toàn giao thông đường bộ là trách nhiệm của ai ?')
insert into CAUHOI values('21',N'Xe sau có thể vượt lên bên phải xe khác khi chạy phía trước trong trường hợp nào ?')
insert into CAUHOI values('22',N'Người lái xe phải làm gì khi quay đầu xe trên cầu, gầm cầu vượt, đường ngầm  ?')
insert into CAUHOI values('23',N'Tại nơi đường giao nhau có báo hiệu đi theo vòng xuyến, người điều khiển phương tiện phải nhường đường như thế nào ?')
insert into CAUHOI values('24',N'Tại nơi đường giao nhau, người lái xe đang đi trên đường không ưu tiên phải nhường đường như thế nào ?')
insert into CAUHOI values('25',N'Tại đoạn đường bộ giao nhau cùng mức với đường sắt, cầu đường bộ đi chung với đường sắt thì loại phương tiện nào được ưu tiên trước ?')

-- cau lenh insert dap dan
insert into  DAPAN values('01',N'Đường, cầu đường bộ',0,'01')
insert into  DAPAN values('02',N'Hầm đường bộ, Bến phà đường bộ',0,'01')
insert into  DAPAN values('03',N'Đường, cầu đường bộ, hầm đường bộ, bến phà đường bộ',1,'01')
insert into  DAPAN values('04',N'Là vạch chỉ sự phân chia làn đường,vị trí hoặc hướng đi,vị trí dừng',0,'02')
insert into  DAPAN values('05',N'Là vạch chỉ sự phân biệt vị trí dừng, đỗ xe trên đường',0,'02')
insert into  DAPAN values('06',N'Tất cả các ý trên',1,'02')
insert into  DAPAN values('07',N'là 1 phần của đường được chia theo chiều ngang của đường, có chiều rộng đủ cho xe đỗ an toàn',0,'03')
insert into  DAPAN values('08',N'là một phần của đường xe chạy đc chia theo chiều dọc của đường, có chiều rộng đủ cho xe chạy an toàn',1,'03')
insert into  DAPAN values('09',N'Cả 2 ý trên',0,'03')
insert into  DAPAN values('10',N'Đường phố là đường đô thị, gồm lòng đường và hè phố',1,'04')
insert into  DAPAN values('11',N'Đường phố là đường bộ ngoài đô thị có lòng đường đủ rộng cho các phương tiện giao thông qua lại',0,'04')
insert into  DAPAN values('12',N'Đường phố là đường bộ trong đô thị, không gồm lòng đường và hè phố',0,'04')
insert into  DAPAN values('13',N'là bộ phận của đường để phân chia mặt đường thành 2 chiều xe chạy riêng biệt hoặc để phân chia phần đường của xe cơ giới và xe thô sơ',1,'05')
insert into  DAPAN values('14',N'Là bộ phận của đường để xác định ranh giới của đất dành cho đường bộ theo chiều ngang của đường',0,'05')
insert into  DAPAN values('15',N'Là bộ phận của đường để ngăn cách không cho các loại xe vào những nơi không được phép',0,'05')
insert into  DAPAN values('16',N'cơ giới đường bộ, thô sơ đường bộ',1,'06')
insert into  DAPAN values('17',N'thô sơ đường bộ, cơ giới đường bộ và xe máy chuyên dùng',0,'06')
insert into  DAPAN values('18',N'Xe máy chuyên dùng',0,'06')
insert into  DAPAN values('19',N'Phương tiện giao thông cơ giới đường bộ',0,'07')
insert into  DAPAN values('20',N'Phương tiện giao thông thô sơ đường bộ và xe máy chuyên dụng',0,'07')
insert into  DAPAN values('21',N'Phương tiện giao thông cơ giới đường bộ, thô sơ đường bộ và xe máy chuyên dùng',1,'07')
insert into  DAPAN values('22',N'Người điều khiển, người sử dụng phương tiện tham gia giao thông đường bộ',0,'08')
insert into  DAPAN values('23',N'Người điều khiển, dẫn dắt súc vật, người đi bộ trên đường',0,'08')
insert into  DAPAN values('24',N'Người điều khiển, sử dụng phương tiện tham gia giao thông đường bộ,dẫn dắt súc vật và người đi bộ',1,'08')
insert into  DAPAN values('25',N'Phá hoại đường, cầu, hầm,bến phà đường bộ,đèn tín hiệu,cọc tiêu,biển báo hiệu, gương cầu,dải phân cách',0,'09')
insert into  DAPAN values('26',N'Phá hoại hệ thống thoát nước và các công trình, thiết bị khác thuộc kết cấu hạ tầng giao thông đường bộ',0,'09')
insert into  DAPAN values('27',N'Cả 2 phương án trên',1,'09')
insert into  DAPAN values('28',N'Nồng độ cồn vượt quá 50 miligam/100 mililit máu',1,'10')
insert into  DAPAN values('29',N'Nồng độ cồn vượt quá 40 miligam/100 mililit máu',0,'10')
insert into  DAPAN values('30',N'Nồng độ cồn vượt quá 30 miligam/100 mililit máu',0,'10')
insert into  DAPAN values('31',N'Nồng độ cồn vượt quá 0.25 miligam/1 lít khí thở',1,'11')
insert into  DAPAN values('32',N'Nồng độ cồn vượt quá 0.20 miligam/1 lít khí thở',0,'11')
insert into  DAPAN values('33',N'Nồng độ cồn vượt quá 0.15 miligam/1 lít khí thở',0,'11')
insert into  DAPAN values('34',N'Không bị nghiêm cấm',0,'12')
insert into  DAPAN values('35',N'Bị nghiêm cấm',1,'12')
insert into  DAPAN values('36',N'Bị nghiêm cấm tùy từng trường hợp',0,'12')
insert into  DAPAN values('37',N'Có',1,'13')
insert into  DAPAN values('38',N'Tùy từng trường hợp',0,'13')
insert into  DAPAN values('39',N'Không',0,'13')
insert into  DAPAN values('40',N'Bấm còi rú ra liên tục trong khoảng thời gian từ 22h đến 5h',0,'14')
insert into  DAPAN values('41',N'Bấm còi hơi,sử dụng đèn chiếu xa trong khu đô thị và khu dân cư, trừ các xe ưu tiên đang làm nhiệm vụ',0,'14')
insert into  DAPAN values('42',N'Tất cả các phương án trên',1,'14')
insert into  DAPAN values('43',N'Không bị cấm',0,'15')
insert into  DAPAN values('44',N'Bị cấm tùy từng trường hợp',0,'15')
insert into  DAPAN values('45',N'Bị cấm',1,'15')
insert into  DAPAN values('46',N'Nghiêm cấm sản xuất, được phép sử dụng',0,'16')
insert into  DAPAN values('47',N'Nghiêm cấm mua bán, cho phép sử dụng',0,'16')
insert into  DAPAN values('48',N'Nghiêm cấm sản xuất,mua bán, sử dụng trái phép',1,'16')
insert into  DAPAN values('49',N'Được phép',1,'17')
insert into  DAPAN values('50',N'Tùy trường hợp',0,'17')
insert into  DAPAN values('51',N'Không được phép',0,'17')
insert into  DAPAN values('51',N'Đội mũ bảo hiểm và cài quai đúng cách',0,'18')
insert into  DAPAN values('53',N'Sử dụng ô, bám, kéo hoặc đẩy các phương tiện khác',1,'18')
insert into  DAPAN values('54',N'Đứng trên yên, giá đèo hàng hoặc ngồi trên tay lái',1,'18')
insert into  DAPAN values('55',N'Được mang vác tùy trường hợp cụ thể',0,'19')
insert into  DAPAN values('56',N'Không được mang vác',1,'19')
insert into  DAPAN values('57',N'Được mang vác nhưng phải đảm bảo an toàn',0,'19')
insert into  DAPAN values('58',N'Của ngành giao thông vận tải và Ngành công an',0,'20')
insert into  DAPAN values('59',N'Là trách nhiệm của cơ quan, tổ chức, cá nhân',1,'20')
insert into  DAPAN values('60',N'Là trách nhiệm của cảnh sát giao thông',0,'20')
insert into  DAPAN values('61',N'Khi xe phía trước có tín hiệu rẽ trái hoặc đang rẽ trái, khi xe điện đang chạy giữa đường',1,'21')
insert into  DAPAN values('62',N'Khi xe chuyên dùng đang làm việc trên đường mà không thể vượt bên trái được',1,'21')
insert into  DAPAN values('63',N'Khi có đủ khoảng trống để xe vượt',0,'21')
insert into  DAPAN values('64',N'Không được quay đầu xe',1,'22')
insert into  DAPAN values('65',N'Lợi dụng chỗ rộng và phải có người làm tín hiệu sau xe để đảm bảo an toàn',0,'22')
insert into  DAPAN values('66',N'Lợi dụng chỗ rộng có thể quay đầu được để quay xe an toàn',0,'22')
insert into  DAPAN values('67',N'Phải nhường xe đi bên phải',0,'23')
insert into  DAPAN values('68',N'Xe báo hiệu xin đường trước xe đó được đi trước',0,'23')
insert into  DAPAN values('69',N'Phải nhường đường cho xe đi bên trái',1,'23')
insert into  DAPAN values('70',N'Nhường đường cho xe đi ở bên phải mình tới',0,'24')
insert into  DAPAN values('71',N'Nhường đường cho xe đi bên trái mình tới ',0,'24')
insert into  DAPAN values('72',N'Nhường đường cho xe đi trên đường ưu tiên hoặc đường chính từ bất kì hướng nào tới',1,'24')
insert into  DAPAN values('73',N'Phương tiện nào bên phải không vướng',0,'25')
insert into  DAPAN values('74',N'Phương tiện nào ra tín hiệu xin đường trước',0,'25')
insert into  DAPAN values('75',N'Phương tiện giao thông đường sắt',1,'25')
select * from DAPAN
select * from TAIKHOAN
select * from KETQUA
