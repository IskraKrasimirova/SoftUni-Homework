ALTER TABLE Users
DROP CONSTRAINT PK__Users__3214EC07509A32C1

ALTER TABLE Users
ADD CONSTRAINT PK_UsersCompositeIdUsername PRIMARY KEY (Id,Username)