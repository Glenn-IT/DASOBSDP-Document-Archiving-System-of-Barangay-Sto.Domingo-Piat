-- ============================================================
--  Migration: Rehash plain-text passwords to BCrypt (work factor 11)
--  Run this ONCE against dasbsdp after deploying BCrypt support.
--  Original plain-text passwords (for reference only — remove after migration):
--    admin=admin123, jdela=jdela123, mreyes=mreyes123,
--    rsantos=rsantos123, bcruz=bcruz123, lgarcia=lgarcia123, ptorres=ptorres123
-- ============================================================

USE dasbsdp;
GO

UPDATE tbl_Users SET PasswordHash = '$2a$11$zrfWgscm52K3Cg5iYuvTMuUMs3ISKhG2bT6Fz7tWLW7i8IPhuQ88C' WHERE Username = 'admin';
UPDATE tbl_Users SET PasswordHash = '$2a$11$eu9P4dEGU8E0Afb2K3H0leXtbCWUtavG1VjfKQOPv1tq6mOINf1fa' WHERE Username = 'jdela';
UPDATE tbl_Users SET PasswordHash = '$2a$11$uLoVubSKvSo0S5M1HZuvhuo1hmT4.WMP1uDhxlzZ91/otyoj9NdrG' WHERE Username = 'mreyes';
UPDATE tbl_Users SET PasswordHash = '$2a$11$EtgScj4iLSvWM/7PQgKp3.Bh1JZqkTehKWsA0iIGhxw43dN3o5Ame' WHERE Username = 'rsantos';
UPDATE tbl_Users SET PasswordHash = '$2a$11$TuU3tY4ilPcJP35NHykizOLu3ouAAcsd8LwKcaGuUNy5fh5iUo9iW' WHERE Username = 'bcruz';
UPDATE tbl_Users SET PasswordHash = '$2a$11$jg0.wM67Q8J1Awi/Skee5ukJtlpbB.XfoSwyf9c6MkBXVNK9pXxoS' WHERE Username = 'lgarcia';
UPDATE tbl_Users SET PasswordHash = '$2a$11$UYvM0OAj2oyfMew1YBH8vejt/vHNdJF2lgba79WmhEj/QtVB055vq' WHERE Username = 'ptorres';

PRINT 'Password migration complete. All 7 users now have BCrypt hashes.';
GO
