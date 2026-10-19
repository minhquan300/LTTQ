/*
    SEED DATA - QUAN LY NHA HANG
    Dữ liệu mẫu phục vụ kiểm thử, các nội dung hiển thị đã có dấu tiếng Việt.
    Luu y:
    - Chi chay sau khi da tao database bang QLBH.sql.
    - Chỉ chạy trên database có các bảng rỗng để tránh trùng ID.
    - PasswordHash vẫn là CHUA_CO_HASH; cần tạo hash hợp lệ để đăng nhập.
*/
USE [QuanLyNhaHang];
GO
SET NOCOUNT ON;
SET XACT_ABORT ON;

BEGIN TRY
    BEGIN TRANSACTION;

    IF EXISTS (SELECT 1 FROM dbo.Roles)
       OR EXISTS (SELECT 1 FROM dbo.Employees)
       OR EXISTS (SELECT 1 FROM dbo.Categories)
       OR EXISTS (SELECT 1 FROM dbo.MenuItems)
       OR EXISTS (SELECT 1 FROM dbo.DiningTables)
       OR EXISTS (SELECT 1 FROM dbo.Orders)
       OR EXISTS (SELECT 1 FROM dbo.OrderDetails)
       OR EXISTS (SELECT 1 FROM dbo.Payments)
       OR EXISTS (SELECT 1 FROM dbo.OrderStatusHistory)
       OR EXISTS (SELECT 1 FROM dbo.OrderDetailStatusHistory)
    BEGIN
    RAISERROR(N'Các bảng không rỗng. Hãy dùng database mới hoặc kiểm tra dữ liệu trước khi chạy SeedData.sql.', 16, 1);
    RETURN;
END;

    /* 1. ROLES */
    SET IDENTITY_INSERT dbo.Roles ON;
    INSERT INTO dbo.Roles (RoleID, RoleName, Description) VALUES
    (1, N'Quản lý', N'Quản lý hoạt động nhà hàng'),
    (2, N'Thu ngân', N'Tiếp nhận và thanh toán đơn hàng'),
    (3, N'Phục vụ', N'Tiếp nhận yêu cầu và phục vụ khách'),
    (4, N'Đầu bếp', N'Chế biến món ăn');
    SET IDENTITY_INSERT dbo.Roles OFF;

    /* 2. EMPLOYEES
       PasswordHash tam thoi. Can thay bang hash dung sau khi nhom hoan thien AuthService. */
    SET IDENTITY_INSERT dbo.Employees ON;
    INSERT INTO dbo.Employees
        (EmployeeID, Username, PasswordHash, FullName, Phone, IsActive, RoleID, CreatedAt)
    VALUES
    (1, 'admin', N'CHUA_CO_HASH', N'Nguyễn Văn An', '0901000001', 1, 1, DATEADD(day,-180, SYSDATETIME())),
    (2, 'manager01', N'CHUA_CO_HASH', N'Trần Thị Bích', '0901000002', 1, 1, DATEADD(day,-160, SYSDATETIME())),
    (3, 'cashier01', N'CHUA_CO_HASH', N'Lê Văn Cường', '0901000003', 1, 2, DATEADD(day,-150, SYSDATETIME())),
    (4, 'cashier02', N'CHUA_CO_HASH', N'Phạm Thị Dung', '0901000004', 1, 2, DATEADD(day,-140, SYSDATETIME())),
    (5, 'cashier03', N'CHUA_CO_HASH', N'Hoàng Văn Giang', '0901000005', 1, 2, DATEADD(day,-130, SYSDATETIME())),
    (6, 'service01', N'CHUA_CO_HASH', N'Vũ Thị Hoa', '0901000006', 1, 3, DATEADD(day,-120, SYSDATETIME())),
    (7, 'service02', N'CHUA_CO_HASH', N'Đỗ Văn Hùng', '0901000007', 1, 3, DATEADD(day,-115, SYSDATETIME())),
    (8, 'service03', N'CHUA_CO_HASH', N'Bùi Thị Lan', '0901000008', 1, 3, DATEADD(day,-110, SYSDATETIME())),
    (9, 'service04', N'CHUA_CO_HASH', N'Ngô Văn Minh', '0901000009', 1, 3, DATEADD(day,-105, SYSDATETIME())),
    (10, 'service05', N'CHUA_CO_HASH', N'Đặng Thị Ngọc', '0901000010', 1, 3, DATEADD(day,-100, SYSDATETIME())),
    (11, 'chef01', N'CHUA_CO_HASH', N'Phan Văn Phúc', '0901000011', 1, 4, DATEADD(day,-95, SYSDATETIME())),
    (12, 'chef02', N'CHUA_CO_HASH', N'Hồ Thị Quyên', '0901000012', 1, 4, DATEADD(day,-90, SYSDATETIME())),
    (13, 'chef03', N'CHUA_CO_HASH', N'Nguyễn Đức Sơn', '0901000013', 1, 4, DATEADD(day,-85, SYSDATETIME())),
    (14, 'chef04', N'CHUA_CO_HASH', N'Trần Văn Tuấn', '0901000014', 1, 4, DATEADD(day,-80, SYSDATETIME())),
    (15, 'service06', N'CHUA_CO_HASH', N'Lê Thị Yến', '0901000015', 1, 3, DATEADD(day,-75, SYSDATETIME()));
    SET IDENTITY_INSERT dbo.Employees OFF;

    /* 3. CATEGORIES */
    SET IDENTITY_INSERT dbo.Categories ON;
    INSERT INTO dbo.Categories (CategoryID, CategoryName, Description, IsActive) VALUES
    (1, N'Khai vị', N'Các món khai vị', 1),
    (2, N'Gỏi và nộm', N'Gỏi, nộm và món trộn', 1),
    (3, N'Món gà', N'Các món chế biến từ gà', 1),
    (4, N'Món bò', N'Các món chế biến từ bò', 1),
    (5, N'Món heo', N'Các món chế biến từ heo', 1),
    (6, N'Hải sản', N'Tôm, mực, cá và hải sản', 1),
    (7, N'Rau và đậu', N'Rau xào và món đậu', 1),
    (8, N'Cơm', N'Các món cơm', 1),
    (9, N'Mì và bún', N'Mì, bún và phở', 1),
    (10, N'Lẩu', N'Các loại lẩu', 1),
    (11, N'Tráng miệng', N'Trái cây và món ngọt', 1),
    (12, N'Đồ uống', N'Trà, nước ép và nước giải khát', 1);
    SET IDENTITY_INSERT dbo.Categories OFF;

    /* 4. MENU ITEMS - 100 mon, moi danh muc co nhieu mon */
    SET IDENTITY_INSERT dbo.MenuItems ON;
    INSERT INTO dbo.MenuItems
        (MenuItemID, ItemName, CategoryID, Price, Description, ImagePath, IsAvailable)
    VALUES
    (1,N'Khoai tây chiên',1,45000,N'Khoai tây chiên giòn',NULL,1),
    (2,N'Nem rán',1,55000,N'Nem rán truyền thống',NULL,1),
    (3,N'Chả giò hải sản',1,65000,N'Chả giò nhân hải sản',NULL,1),
    (4,N'Cánh gà chiên nước mắm',1,79000,N'Cánh gà chiên nước mắm',NULL,1),
    (5,N'Bánh xếp chiên',1,50000,N'Bánh xếp chiên giòn',NULL,1),
    (6,N'Gỏi ngó sen tôm thịt',2,85000,N'Gỏi ngó sen tôm thịt',NULL,1),
    (7,N'Gỏi bò rau thơm',2,89000,N'Gỏi bò rau thơm',NULL,1),
    (8,N'Nộm đu đủ bò khô',2,75000,N'Nộm đu đủ bò khô',NULL,1),
    (9,N'Gỏi gà xé phay',2,79000,N'Gỏi gà xé phay',NULL,1),
    (10,N'Gỏi xoài tôm',2,82000,N'Gỏi xoài xanh tôm tươi',NULL,1),
    (11,N'Gà nướng mật ong',3,159000,N'Gà nướng mật ong',NULL,1),
    (12,N'Gà hấp lá chanh',3,149000,N'Gà hấp lá chanh',NULL,1),
    (13,N'Gà rang muối',3,169000,N'Gà rang muối',NULL,1),
    (14,N'Gà sốt me',3,155000,N'Gà chiên sốt me',NULL,1),
    (15,N'Cánh gà nướng sả',3,99000,N'Cánh gà nướng sả',NULL,1),
    (16,N'Bò lúc lắc',4,169000,N'Bò lúc lắc khoai tây',NULL,1),
    (17,N'Bò xào lúc lắc',4,159000,N'Bò xào rau củ',NULL,1),
    (18,N'Bò bít tết',4,189000,N'Bò bít tết sốt tiêu',NULL,1),
    (19,N'Bò sốt vang',4,149000,N'Bò sốt vang ăn kèm bánh mì',NULL,1),
    (20,N'Bò nướng lá lốt',4,139000,N'Bò nướng lá lốt',NULL,1),
    (21,N'Sườn heo nướng',5,149000,N'Sườn heo nướng mật ong',NULL,1),
    (22,N'Sườn xào chua ngọt',5,139000,N'Sườn xào chua ngọt',NULL,1),
    (23,N'Ba chỉ rang cháy cạnh',5,119000,N'Ba chỉ rang cháy cạnh',NULL,1),
    (24,N'Thịt kho trứng',5,99000,N'Thịt kho trứng',NULL,1),
    (25,N'Heo quay',5,159000,N'Heo quay da giòn',NULL,1),
    (26,N'Tôm rang muối',6,179000,N'Tôm rang muối',NULL,1),
    (27,N'Mực chiên giòn',6,139000,N'Mực chiên giòn',NULL,1),
    (28,N'Mực xào sả ớt',6,149000,N'Mực xào sả ớt',NULL,1),
    (29,N'Cá chiên xù',6,159000,N'Cá chiên xù',NULL,1),
    (30,N'Tôm hấp bia',6,189000,N'Tôm hấp bia',NULL,1),
    (31,N'Rau muống xào tỏi',7,55000,N'Rau muống xào tỏi',NULL,1),
    (32,N'Cải thìa xào nấm',7,65000,N'Cải thìa xào nấm',NULL,1),
    (33,N'Rau củ luộc kho quẹt',7,59000,N'Rau củ luộc kho quẹt',NULL,1),
    (34,N'Đậu hũ sốt cà',7,69000,N'Đậu hũ sốt cà',NULL,1),
    (35,N'Nấm xào bò',7,79000,N'Nấm xào bò',NULL,1),
    (36,N'Cơm trắng',8,15000,N'Cơm trắng phần',NULL,1),
    (37,N'Cơm chiên hải sản',8,89000,N'Cơm chiên hải sản',NULL,1),
    (38,N'Cơm chiên Dương Châu',8,79000,N'Cơm chiên Dương Châu',NULL,1),
    (39,N'Cơm gà nướng',8,85000,N'Cơm gà nướng',NULL,1),
    (40,N'Cơm sườn nướng',8,89000,N'Cơm sườn nướng',NULL,1),
    (41,N'Phở bò tái',9,75000,N'Phở bò tái',NULL,1),
    (42,N'Phở bò chín',9,75000,N'Phở bò chín',NULL,1),
    (43,N'Bún chả Hà Nội',9,79000,N'Bún chả Hà Nội',NULL,1),
    (44,N'Bún bò Huế',9,79000,N'Bún bò Huế',NULL,1),
    (45,N'Mì xào bò',9,85000,N'Mì xào bò rau cải',NULL,1),
    (46,N'Lẩu Thái hải sản',10,329000,N'Lẩu Thái hải sản 2–3 người',NULL,1),
    (47,N'Lẩu gà lá é',10,299000,N'Lẩu gà lá é',NULL,1),
    (48,N'Lẩu bò nhúng dấm',10,349000,N'Lẩu bò nhúng dấm',NULL,1),
    (49,N'Lẩu nấm',10,279000,N'Lẩu nấm rau củ',NULL,1),
    (50,N'Lẩu cá',10,299000,N'Lẩu cá chua cay',NULL,1),
    (51,N'Chè khúc bạch',11,45000,N'Chè khúc bạch',NULL,1),
    (52,N'Rau câu dừa',11,35000,N'Rau câu dừa tươi',NULL,1),
    (53,N'Bánh flan',11,30000,N'Bánh flan caramel',NULL,1),
    (54,N'Trái cây theo mùa',11,59000,N'Đĩa trái cây theo mùa',NULL,1),
    (55,N'Kem tươi',11,39000,N'Kem tươi nhiều vị',NULL,1),
    (56,N'Trà đá',12,10000,N'Trà đá',NULL,1),
    (57,N'Trà chanh',12,25000,N'Trà chanh tươi',NULL,1),
    (58,N'Trà đào',12,35000,N'Trà đào cam sả',NULL,1),
    (59,N'Nước ép cam',12,39000,N'Nước ép cam tươi',NULL,1),
    (60,N'Nước ép dưa hấu',12,35000,N'Nước ép dưa hấu',NULL,1),
    (61,N'Bắp rang bơ',1,35000,N'Bắp rang bơ',NULL,1),
    (62,N'Xúc xích chiên',1,45000,N'Xúc xích chiên',NULL,1),
    (63,N'Phô mai que',1,49000,N'Phô mai que',NULL,1),
    (64,N'Bánh mì bơ tỏi',1,39000,N'Bánh mì bơ tỏi',NULL,1),
    (65,N'Chạo tôm',1,69000,N'Chạo tôm nướng',NULL,1),
    (66,N'Gỏi rau tiến vua',2,69000,N'Gỏi rau tiến vua',NULL,1),
    (67,N'Gỏi củ hũ dừa',2,79000,N'Gỏi củ hũ dừa tôm thịt',NULL,1),
    (68,N'Gỏi cá mai',2,99000,N'Gỏi cá mai',NULL,1),
    (69,N'Nộm tai heo',2,75000,N'Nộm tai heo',NULL,1),
    (70,N'Gỏi bò bóp thấu',2,95000,N'Gỏi bò bóp thấu',NULL,1),
    (71,N'Gà chiên giòn',3,129000,N'Gà chiên giòn',NULL,1),
    (72,N'Gà sốt bơ tỏi',3,159000,N'Gà sốt bơ tỏi',NULL,1),
    (73,N'Gà nướng muối ớt',3,165000,N'Gà nướng muối ớt',NULL,1),
    (74,N'Ức gà áp chảo',3,139000,N'Ức gà áp chảo',NULL,1),
    (75,N'Gà nấu lagu',3,149000,N'Gà nấu lagu',NULL,1),
    (76,N'Bò xào hành tây',4,149000,N'Bò xào hành tây',NULL,1),
    (77,N'Bò hầm tiêu xanh',4,169000,N'Bò hầm tiêu xanh',NULL,1),
    (78,N'Bò cuộn nấm kim châm',4,179000,N'Bò cuộn nấm kim châm',NULL,1),
    (79,N'Bò nướng sốt BBQ',4,189000,N'Bò nướng sốt BBQ',NULL,1),
    (80,N'Bò xào cần tỏi',4,145000,N'Bò xào cần tỏi',NULL,1),
    (81,N'Chả lụa chiên',5,79000,N'Chả lụa chiên',NULL,1),
    (82,N'Sườn non ram mặn',5,149000,N'Sườn non ram mặn',NULL,1),
    (83,N'Ba rọi chiên mắm',5,139000,N'Ba rọi chiên mắm',NULL,1),
    (84,N'Nem nướng',5,99000,N'Nem nướng',NULL,1),
    (85,N'Đùi heo hầm',5,159000,N'Đùi heo hầm',NULL,1),
    (86,N'Cá lóc hấp bầu',6,189000,N'Cá lóc hấp bầu',NULL,1),
    (87,N'Cá basa kho tộ',6,119000,N'Cá basa kho tộ',NULL,1),
    (88,N'Nghêu hấp sả',6,99000,N'Nghêu hấp sả',NULL,1),
    (89,N'Vẹm nướng mỡ hành',6,129000,N'Vẹm nướng mỡ hành',NULL,1),
    (90,N'Bạch tuộc nướng',6,169000,N'Bạch tuộc nướng',NULL,1),
    (91,N'Bông cải xào tỏi',7,65000,N'Bông cải xào tỏi',NULL,1),
    (92,N'Cà tím nướng mỡ hành',7,69000,N'Cà tím nướng mỡ hành',NULL,1),
    (93,N'Đậu que xào tỏi',7,59000,N'Đậu que xào tỏi',NULL,1),
    (94,N'Khổ qua xào trứng',7,59000,N'Khổ qua xào trứng',NULL,1),
    (95,N'Rau thập cẩm xào',7,69000,N'Rau thập cẩm xào',NULL,1),
    (96,N'Cơm chiên trứng',8,59000,N'Cơm chiên trứng',NULL,1),
    (97,N'Cơm chiên bò',8,89000,N'Cơm chiên bò',NULL,1),
    (98,N'Cơm gà xối mỡ',8,89000,N'Cơm gà xối mỡ',NULL,1),
    (99,N'Cơm cá kho tộ',8,85000,N'Cơm cá kho tộ',NULL,1),
    (100,N'Cơm bò lúc lắc',8,99000,N'Cơm bò lúc lắc',NULL,1);
    SET IDENTITY_INSERT dbo.MenuItems OFF;

    /* 5. DINING TABLES */
    SET IDENTITY_INSERT dbo.DiningTables ON;
    INSERT INTO dbo.DiningTables (TableID, TableName, QRCode, Capacity, TableStatus)
    VALUES
    (1,N'Bàn 01','QR-TABLE-01',2,N'Trong'),(2,N'Bàn 02','QR-TABLE-02',2,N'Trong'),
    (3,N'Bàn 03','QR-TABLE-03',2,N'Trong'),(4,N'Bàn 04','QR-TABLE-04',2,N'Trong'),
    (5,N'Bàn 05','QR-TABLE-05',4,N'Trong'),(6,N'Bàn 06','QR-TABLE-06',4,N'Trong'),
    (7,N'Bàn 07','QR-TABLE-07',4,N'Trong'),(8,N'Bàn 08','QR-TABLE-08',4,N'Trong'),
    (9,N'Bàn 09','QR-TABLE-09',4,N'Trong'),(10,N'Bàn 10','QR-TABLE-10',4,N'Trong'),
    (11,N'Bàn 11','QR-TABLE-11',4,N'Trong'),(12,N'Bàn 12','QR-TABLE-12',4,N'Trong'),
    (13,N'Bàn 13','QR-TABLE-13',4,N'Trong'),(14,N'Bàn 14','QR-TABLE-14',4,N'Trong'),
    (15,N'Bàn 15','QR-TABLE-15',4,N'Trong'),(16,N'Bàn 16','QR-TABLE-16',6,N'Trong'),
    (17,N'Bàn 17','QR-TABLE-17',6,N'Trong'),(18,N'Bàn 18','QR-TABLE-18',6,N'Trong'),
    (19,N'Bàn 19','QR-TABLE-19',6,N'Trong'),(20,N'Bàn 20','QR-TABLE-20',6,N'Trong'),
    (21,N'Bàn 21','QR-TABLE-21',8,N'Trong'),(22,N'Bàn 22','QR-TABLE-22',8,N'Trong'),
    (23,N'Bàn 23','QR-TABLE-23',8,N'Trong'),(24,N'Bàn 24','QR-TABLE-24',8,N'Trong'),
    (25,N'Bàn 25','QR-TABLE-25',10,N'Trong'),(26,N'Bàn 26','QR-TABLE-26',10,N'Trong'),
    (27,N'Bàn 27','QR-TABLE-27',10,N'Trong'),(28,N'Bàn 28','QR-TABLE-28',4,N'Trong'),
    (29,N'Bàn 29','QR-TABLE-29',6,N'Trong'),(30,N'Bàn 30','QR-TABLE-30',8,N'Trong');
    SET IDENTITY_INSERT dbo.DiningTables OFF;

    /* 6. ORDERS - 300 don trong 90 ngay gan nhat */
    SET IDENTITY_INSERT dbo.Orders ON;
    DECLARE @i int = 1, @orderTime datetime2(7), @orderStatus nvarchar(20),
            @tableID int, @employeeID int, @orderCode varchar(30);
    WHILE @i <= 300
    BEGIN
        SET @orderTime = DATEADD(minute, -((@i * 37) % 720),
                         DATEADD(day, -((@i - 1) % 90), CONVERT(datetime2(0), GETDATE())));
        SET @orderStatus =
            CASE WHEN @i <= 250 THEN N'Da thanh toan'
                 WHEN @i <= 270 THEN N'Hoan thanh'
                 WHEN @i <= 290 THEN N'Dang xu ly'
                 WHEN @i <= 295 THEN N'Moi'
                 ELSE N'Da huy' END;
        SET @tableID = ((@i - 1) % 30) + 1;
        SET @employeeID = ((@i - 1) % 5) + 6;
        SET @orderCode = 'DH' + RIGHT('0000' + CAST(@i AS varchar(4)), 4);

        INSERT INTO dbo.Orders
            (OrderID, OrderCode, TableID, EmployeeID, OrderTime, OrderStatus, Note)
        VALUES
            (@i, @orderCode, @tableID, @employeeID, @orderTime, @orderStatus,
             CASE WHEN @i % 9 = 0 THEN N'Khách yêu cầu ít cay'
                  WHEN @i % 13 = 0 THEN N'Khách có trẻ em'
                  ELSE NULL END);
        SET @i += 1;
    END;
    SET IDENTITY_INSERT dbo.Orders OFF;

    /* 7. ORDER DETAILS - 3 mon moi don, tong 900 dong */
    SET IDENTITY_INSERT dbo.OrderDetails ON;
    DECLARE @detailID int = 1, @orderID int = 1, @j int,
            @itemStatus nvarchar(20), @orderedAt datetime2(7),
            @startedAt datetime2(7), @completedAt datetime2(7), @servedAt datetime2(7),
            @menuID int, @quantity int, @price decimal(18,2), @statusForOrder nvarchar(20);
    WHILE @orderID <= 300
    BEGIN
        SELECT @orderedAt = OrderTime, @statusForOrder = OrderStatus
        FROM dbo.Orders WHERE OrderID = @orderID;

        SET @j = 1;
        WHILE @j <= 3
        BEGIN
            SET @menuID = ((@orderID * 7 + @j * 13 - 1) % 100) + 1;
            SET @quantity = ((@orderID + @j) % 3) + 1;
            SELECT @price = Price FROM dbo.MenuItems WHERE MenuItemID = @menuID;

            SET @itemStatus =
                CASE WHEN @statusForOrder IN (N'Da thanh toan',N'Hoan thanh') THEN N'Da phuc vu'
                     WHEN @statusForOrder = N'Dang xu ly' THEN
                          CASE WHEN @j = 1 THEN N'San sang' ELSE N'Dang che bien' END
                     WHEN @statusForOrder = N'Moi' THEN N'Moi'
                     ELSE N'Da huy' END;

            SET @startedAt = NULL;
            SET @completedAt = NULL;
            SET @servedAt = NULL;
            IF @itemStatus IN (N'Dang che bien',N'San sang',N'Da phuc vu')
                SET @startedAt = DATEADD(minute, 5, @orderedAt);
            IF @itemStatus IN (N'San sang',N'Da phuc vu')
                SET @completedAt = DATEADD(minute, 20, @orderedAt);
            IF @itemStatus = N'Da phuc vu'
                SET @servedAt = DATEADD(minute, 25, @orderedAt);

            INSERT INTO dbo.OrderDetails
                (OrderDetailID, OrderID, MenuItemID, Quantity, UnitPrice, ItemStatus,
                 OrderedAt, CookingStartedAt, CookingCompletedAt, ServedAt, Note)
            VALUES
                (@detailID, @orderID, @menuID, @quantity, @price, @itemStatus,
                 @orderedAt, @startedAt, @completedAt, @servedAt,
                 CASE WHEN @j = 3 AND @orderID % 10 = 0 THEN N'Không hành' ELSE NULL END);

            SET @detailID += 1;
            SET @j += 1;
        END;
        SET @orderID += 1;
    END;
    SET IDENTITY_INSERT dbo.OrderDetails OFF;

    /* 8. PAYMENTS - 250 don da thanh toan */
    DECLARE @paymentID int = 1, @amount decimal(18,2), @method nvarchar(30);
    WHILE @paymentID <= 250
    BEGIN
        SELECT @amount = SUM(Quantity * UnitPrice)
        FROM dbo.OrderDetails WHERE OrderID = @paymentID;

        SET @method = CASE WHEN @paymentID % 3 = 0 THEN N'Chuyen khoan'
                           WHEN @paymentID % 3 = 1 THEN N'Tien mat'
                           ELSE N'Vi dien tu' END;

        INSERT INTO dbo.Payments
            (OrderID, Amount, PaymentMethod, PaymentStatus, PaymentTime, EmployeeID, TransactionCode)
        SELECT @paymentID, @amount, @method, N'Thanh cong',
               DATEADD(minute, 30, OrderTime),
               ((@paymentID - 1) % 3) + 3,
               CASE WHEN @method = N'Tien mat' THEN NULL
                    ELSE 'TX' + RIGHT('000000' + CAST(@paymentID AS varchar(6)), 6) END
        FROM dbo.Orders WHERE OrderID = @paymentID;

        SET @paymentID += 1;
    END;

    /* 9. ORDER STATUS HISTORY */
    DECLARE @historyOrderID int = 1, @historyTime datetime2(7), @historyStatus nvarchar(20);
    WHILE @historyOrderID <= 300
    BEGIN
        SELECT @historyTime = OrderTime, @historyStatus = OrderStatus
        FROM dbo.Orders WHERE OrderID = @historyOrderID;

        INSERT INTO dbo.OrderStatusHistory
            (OrderID, OldStatus, NewStatus, ChangedAt, EmployeeID, Note)
        VALUES
            (@historyOrderID, NULL, N'Moi', @historyTime, ((@historyOrderID - 1) % 5) + 6, N'Tạo đơn hàng');

        IF @historyStatus <> N'Moi'
        BEGIN
            INSERT INTO dbo.OrderStatusHistory
                (OrderID, OldStatus, NewStatus, ChangedAt, EmployeeID, Note)
            VALUES
                (@historyOrderID, N'Moi',
                 CASE WHEN @historyStatus = N'Da huy' THEN N'Da huy'
                      ELSE N'Dang xu ly' END,
                 DATEADD(minute, 5, @historyTime), ((@historyOrderID - 1) % 5) + 6,
                 N'Tiếp nhận đơn hàng');
        END;

        IF @historyStatus IN (N'Da thanh toan',N'Hoan thanh')
        BEGIN
            INSERT INTO dbo.OrderStatusHistory
                (OrderID, OldStatus, NewStatus, ChangedAt, EmployeeID, Note)
            VALUES
                (@historyOrderID, N'Dang xu ly', N'Hoan thanh',
                 DATEADD(minute, 25, @historyTime), ((@historyOrderID - 1) % 5) + 6,
                 N'Hoàn tất phục vụ');
        END;

        IF @historyStatus = N'Da thanh toan'
        BEGIN
            INSERT INTO dbo.OrderStatusHistory
                (OrderID, OldStatus, NewStatus, ChangedAt, EmployeeID, Note)
            VALUES
                (@historyOrderID, N'Hoan thanh', N'Da thanh toan',
                 DATEADD(minute, 30, @historyTime), ((@historyOrderID - 1) % 3) + 3,
                 N'Đã thanh toán');
        END;
        SET @historyOrderID += 1;
    END;

    /* 10. ORDER DETAIL STATUS HISTORY */
    DECLARE @historyDetailID int = 1, @detailStatus nvarchar(20), @detailOrderedAt datetime2(7),
            @detailEmployeeID int;
    WHILE @historyDetailID <= 900
    BEGIN
        SELECT @detailStatus = ItemStatus, @detailOrderedAt = OrderedAt
        FROM dbo.OrderDetails WHERE OrderDetailID = @historyDetailID;

        SELECT @detailEmployeeID = EmployeeID
        FROM dbo.Orders
        WHERE OrderID = (SELECT OrderID FROM dbo.OrderDetails WHERE OrderDetailID = @historyDetailID);

        INSERT INTO dbo.OrderDetailStatusHistory
            (OrderDetailID, OldStatus, NewStatus, ChangedAt, EmployeeID, Note)
        VALUES
            (@historyDetailID, NULL, N'Moi', @detailOrderedAt, @detailEmployeeID, N'Tiếp nhận món');

        IF @detailStatus <> N'Moi'
        BEGIN
            INSERT INTO dbo.OrderDetailStatusHistory
                (OrderDetailID, OldStatus, NewStatus, ChangedAt, EmployeeID, Note)
            VALUES
                (@historyDetailID, N'Moi',
                 CASE WHEN @detailStatus = N'Da huy' THEN N'Da huy'
                      ELSE N'Dang che bien' END,
                 DATEADD(minute, 5, @detailOrderedAt), 11, N'Bếp tiếp nhận món');
        END;

        IF @detailStatus IN (N'San sang',N'Da phuc vu')
        BEGIN
            INSERT INTO dbo.OrderDetailStatusHistory
                (OrderDetailID, OldStatus, NewStatus, ChangedAt, EmployeeID, Note)
            VALUES
                (@historyDetailID, N'Dang che bien', N'San sang',
                 DATEADD(minute, 20, @detailOrderedAt), 11, N'Món đã chế biến xong');
        END;

        IF @detailStatus = N'Da phuc vu'
        BEGIN
            INSERT INTO dbo.OrderDetailStatusHistory
                (OrderDetailID, OldStatus, NewStatus, ChangedAt, EmployeeID, Note)
            VALUES
                (@historyDetailID, N'San sang', N'Da phuc vu',
                 DATEADD(minute, 25, @detailOrderedAt), 6, N'Đã phục vụ khách');
        END;

        SET @historyDetailID += 1;
    END;

    COMMIT TRANSACTION;

    PRINT N'Da chen du lieu mau thanh cong.';
    SELECT N'Roles' AS TableName, COUNT(*) AS TotalRows FROM dbo.Roles
    UNION ALL SELECT N'Employees', COUNT(*) FROM dbo.Employees
    UNION ALL SELECT N'Categories', COUNT(*) FROM dbo.Categories
    UNION ALL SELECT N'MenuItems', COUNT(*) FROM dbo.MenuItems
    UNION ALL SELECT N'DiningTables', COUNT(*) FROM dbo.DiningTables
    UNION ALL SELECT N'Orders', COUNT(*) FROM dbo.Orders
    UNION ALL SELECT N'OrderDetails', COUNT(*) FROM dbo.OrderDetails
    UNION ALL SELECT N'Payments', COUNT(*) FROM dbo.Payments
    UNION ALL SELECT N'OrderStatusHistory', COUNT(*) FROM dbo.OrderStatusHistory
    UNION ALL SELECT N'OrderDetailStatusHistory', COUNT(*) FROM dbo.OrderDetailStatusHistory;
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
    THROW;
END CATCH;
GO
