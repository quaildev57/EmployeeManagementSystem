DROP PROCEDURE IF EXISTS ValidateUser;
GO

CREATE PROCEDURE ValidateUser
(
    @Username VARCHAR(50),
    @PasswordHash VARCHAR(100)
)
AS
BEGIN
    SELECT *
    FROM Users
    WHERE Username = @Username
    AND PasswordHash = @PasswordHash
    AND IsActive = 1
END
GO