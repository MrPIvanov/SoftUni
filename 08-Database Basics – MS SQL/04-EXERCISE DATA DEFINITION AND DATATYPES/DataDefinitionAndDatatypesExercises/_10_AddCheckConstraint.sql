USE Minions

ALTER TABLE Users
ADD CONSTRAINT Users_Password_CH CHECK (LEN([Password]) >=5)