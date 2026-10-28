CREATE DATABASE QL_BanHang;
GO
USE QL_BanHang;
GO

CREATE TABLE SanPham(
	MaSanPham NVARCHAR(10) PRIMARY KEY,
	TenSanPham NTEXT NOT NULL,
	GiaBan NVARCHAR(12) NOT NULL
);

INSERT INTO SanPham(MaSanPham,  TenSanPham, GiaBan)
VALUES
(N'SP001', N'Nước khoáng', 10000),
(N'SP002', N'Sữa tươi Vinamilk', 25000),
(N'SP003', N'Gạo tẻ thơm', 45000),
(N'SP004', N'Bánh quy AFC', 30000),
(N'SP005', N'Dầu ăn Trường An',65000)

SELECT * FROM SanPham;
