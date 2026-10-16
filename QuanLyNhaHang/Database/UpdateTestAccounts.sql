USE QuanLyNhaHang;
GO

-- Quan ly
UPDATE dbo.Employees
SET PasswordHash = N'PBKDF2-SHA256$600000$lqP/SbPuq55mbyJ6C7F8Dw==$B348s1zBaxEwLWqssU2M6eitC2jZbiChez3k7C80ZvI='
WHERE Username = 'admin';

-- Thu ngan
UPDATE dbo.Employees
SET PasswordHash = N'PBKDF2-SHA256$600000$2iUGAfj9/CiAQnytZuZhgA==$Wj0j/1IlqvB8kzcpQ1iyUYlVoN9z4Ajl7aI8SmPEujo='
WHERE Username = 'cashier01';

-- Phuc vu
UPDATE dbo.Employees
SET PasswordHash = N'PBKDF2-SHA256$600000$2iUGAfj9/CiAQnytZuZhgA==$Wj0j/1IlqvB8kzcpQ1iyUYlVoN9z4Ajl7aI8SmPEujo='
WHERE Username = 'service01';

-- Dau bep
UPDATE dbo.Employees
SET PasswordHash = N'PBKDF2-SHA256$600000$2iUGAfj9/CiAQnytZuZhgA==$Wj0j/1IlqvB8kzcpQ1iyUYlVoN9z4Ajl7aI8SmPEujo='
WHERE Username = 'chef01';

-- Kiem tra
SELECT
    Username,
    RoleID,
    IsActive
FROM dbo.Employees
WHERE Username IN (
    'admin',
    'cashier01',
    'service01',
    'chef01'
);