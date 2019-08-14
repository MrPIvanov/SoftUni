USE Minions

CREATE TABLE Users(
Id BIGINT PRIMARY KEY IDENTITY,
Username VARCHAR(30) NOT NULL UNIQUE,
[Password] VARCHAR(26) NOT NULL,
ProfilePicture VARBINARY(MAX),
LastLoginTime DATETIME,
IsDeleted BIT
)

INSERT INTO Users(Username, [Password], ProfilePicture, LastLoginTime, IsDeleted) VALUES
('Ivan', 123, NULL, GETDATE(), 0),
('Stoqn', 1233, NULL, GETDATE(), 0),
('Niki', 1423, NULL, GETDATE(), 0),
('Mitko', 1253, NULL, GETDATE(), 0),
('Pesho', 1263, NULL, GETDATE(), 0)
