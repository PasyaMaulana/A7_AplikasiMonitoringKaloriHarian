-- ============================================================
-- 1. CREATE DATABASE
-- ============================================================
CREATE DATABASE AMKH_DB;
GO
USE AMKH_DB;
GO

-- ============================================================
-- 2. CREATE TABLES
-- ============================================================

-- Tabel Target: menyimpan target kalori per tanggal
CREATE TABLE Target (
    id_target     INT           PRIMARY KEY IDENTITY(1,1),
    target_kalori DECIMAL(10,2) NOT NULL,
    tanggal       DATE          NOT NULL,
    CONSTRAINT UQ_Target_Tanggal UNIQUE (tanggal)
);
GO

-- Tabel Konsumsi: menyimpan data makanan/minuman yang dikonsumsi
CREATE TABLE Konsumsi (
    id_konsumsi  INT           PRIMARY KEY IDENTITY(1,1),
    id_target    INT           NOT NULL,
    nama_item    VARCHAR(100)  NOT NULL,
    kalori       DECIMAL(10,2) NOT NULL,
    tipe         VARCHAR(10)   NOT NULL,
    tanggal      DATE          NOT NULL,
    CONSTRAINT FK_Konsumsi_Target
        FOREIGN KEY (id_target) REFERENCES Target(id_target)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
    CONSTRAINT CHK_Tipe
        CHECK (tipe IN ('Makanan', 'Minuman'))
);
GO

-- Tabel Aktivitas: menyimpan data aktivitas fisik harian
CREATE TABLE Aktivitas (
    id_aktivitas    INT           PRIMARY KEY IDENTITY(1,1),
    id_target       INT           NOT NULL,
    nama_aktivitas  VARCHAR(100)  NOT NULL,
    kalori_terbakar DECIMAL(10,2) NOT NULL,
    tanggal         DATE          NOT NULL,
    CONSTRAINT FK_Aktivitas_Target
        FOREIGN KEY (id_target) REFERENCES Target(id_target)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);
GO

-- ============================================================
-- 3. SAMPLE DATA
-- ============================================================

INSERT INTO Target (target_kalori, tanggal) VALUES
    (2000, CAST(GETDATE()-2 AS DATE)),
    (2000, CAST(GETDATE()-1 AS DATE)),
    (2000, CAST(GETDATE()   AS DATE)),
    (2200, CAST(GETDATE()+1 AS DATE));
GO

-- Konsumsi 2 hari lalu
INSERT INTO Konsumsi (id_target, nama_item, kalori, tipe, tanggal) VALUES
    (1, 'Nasi putih',  250, 'Makanan', CAST(GETDATE()-2 AS DATE)),
    (1, 'Ayam goreng', 350, 'Makanan', CAST(GETDATE()-2 AS DATE)),
    (1, 'Teh manis',   120, 'Minuman', CAST(GETDATE()-2 AS DATE)),
    (1, 'Air putih',     0, 'Minuman', CAST(GETDATE()-2 AS DATE));
GO

-- Konsumsi kemarin
INSERT INTO Konsumsi (id_target, nama_item, kalori, tipe, tanggal) VALUES
    (2, 'Nasi goreng', 400, 'Makanan', CAST(GETDATE()-1 AS DATE)),
    (2, 'Bakso',       320, 'Makanan', CAST(GETDATE()-1 AS DATE)),
    (2, 'Es teh',       80, 'Minuman', CAST(GETDATE()-1 AS DATE)),
    (2, 'Jus jeruk',   150, 'Minuman', CAST(GETDATE()-1 AS DATE));
GO

-- Konsumsi hari ini
INSERT INTO Konsumsi (id_target, nama_item, kalori, tipe, tanggal) VALUES
    (3, 'Roti bakar',  200, 'Makanan', CAST(GETDATE() AS DATE)),
    (3, 'Mie ayam',    380, 'Makanan', CAST(GETDATE() AS DATE)),
    (3, 'Kopi susu',   130, 'Minuman', CAST(GETDATE() AS DATE));
GO

-- Konsumsi besok
INSERT INTO Konsumsi (id_target, nama_item, kalori, tipe, tanggal) VALUES
    (4, 'Salad buah',  150, 'Makanan', CAST(GETDATE()+1 AS DATE)),
    (4, 'Air mineral',   0, 'Minuman', CAST(GETDATE()+1 AS DATE));
GO

-- Aktivitas 2 hari lalu
INSERT INTO Aktivitas (id_target, nama_aktivitas, kalori_terbakar, tanggal) VALUES
    (1, 'Jogging 30 menit', 300, CAST(GETDATE()-2 AS DATE)),
    (1, 'Push up',          100, CAST(GETDATE()-2 AS DATE));
GO

-- Aktivitas kemarin
INSERT INTO Aktivitas (id_target, nama_aktivitas, kalori_terbakar, tanggal) VALUES
    (2, 'Bersepeda 1 jam', 450, CAST(GETDATE()-1 AS DATE));
GO

-- Aktivitas hari ini
INSERT INTO Aktivitas (id_target, nama_aktivitas, kalori_terbakar, tanggal) VALUES
    (3, 'Jalan kaki 20 menit', 150, CAST(GETDATE() AS DATE));
GO

-- ============================================================
-- 4. VIEWS
-- ============================================================

-- VIEW 1: Data konsumsi aktif (tanggal >= hari ini)
-- Digunakan di Form Konsumsi untuk CRUD
CREATE OR ALTER VIEW vw_KonsumsiAktif AS
SELECT
    k.id_konsumsi,
    k.id_target,
    t.target_kalori,
    k.nama_item,
    k.kalori,
    k.tipe,
    k.tanggal
FROM Konsumsi k
INNER JOIN Target t ON k.id_target = t.id_target
WHERE k.tanggal >= CAST(GETDATE() AS DATE);
GO

-- VIEW 2: Data aktivitas aktif (tanggal >= hari ini)
-- Digunakan di Form Aktivitas untuk CRUD
CREATE OR ALTER VIEW vw_AktivitasAktif AS
SELECT
    a.id_aktivitas,
    a.id_target,
    t.target_kalori,
    a.nama_aktivitas,
    a.kalori_terbakar,
    a.tanggal
FROM Aktivitas a
INNER JOIN Target t ON a.id_target = t.id_target
WHERE a.tanggal >= CAST(GETDATE() AS DATE);
GO

-- VIEW 3: Riwayat konsumsi masa lalu (tanggal < hari ini)
-- Digunakan di Form Riwayat, bersifat read-only
CREATE OR ALTER VIEW vw_RiwayatKonsumsi AS
SELECT
    k.id_konsumsi,
    k.id_target,
    t.target_kalori,
    k.nama_item,
    k.kalori,
    k.tipe,
    k.tanggal
FROM Konsumsi k
INNER JOIN Target t ON k.id_target = t.id_target
WHERE k.tanggal < CAST(GETDATE() AS DATE);
GO

-- VIEW 4: Riwayat aktivitas masa lalu (tanggal < hari ini)
-- Digunakan di Form Riwayat, bersifat read-only
CREATE OR ALTER VIEW vw_RiwayatAktivitas AS
SELECT
    a.id_aktivitas,
    a.id_target,
    t.target_kalori,
    a.nama_aktivitas,
    a.kalori_terbakar,
    a.tanggal
FROM Aktivitas a
INNER JOIN Target t ON a.id_target = t.id_target
WHERE a.tanggal < CAST(GETDATE() AS DATE);
GO

-- VIEW 5: Ringkasan riwayat per tanggal
-- Menampilkan total kalori masuk, terbakar, bersih, dan status
CREATE OR ALTER VIEW vw_RingkasanRiwayat AS
SELECT
    t.tanggal,
    t.target_kalori,
    ISNULL(SUM(k.kalori), 0)                              AS total_kalori_masuk,
    ISNULL(MAX(akt.total_bakar), 0)                       AS total_kalori_bakar,
    ISNULL(SUM(k.kalori), 0)
        - ISNULL(MAX(akt.total_bakar), 0)                 AS kalori_bersih,
    CASE
        WHEN (ISNULL(SUM(k.kalori), 0)
            - ISNULL(MAX(akt.total_bakar), 0)) <= t.target_kalori
        THEN 'TERCAPAI'
        ELSE 'MELEBIHI'
    END AS status
FROM Target t
LEFT JOIN Konsumsi k
    ON k.id_target = t.id_target
LEFT JOIN (
    SELECT id_target, SUM(kalori_terbakar) AS total_bakar
    FROM Aktivitas
    GROUP BY id_target
) akt ON akt.id_target = t.id_target
WHERE t.tanggal < CAST(GETDATE() AS DATE)
GROUP BY t.id_target, t.tanggal, t.target_kalori;
GO

-- ============================================================
-- 5. STORED PROCEDURES
-- ============================================================

-- SP 1: INSERT Konsumsi
-- Logika: auto-create Target jika belum ada,
--         blokir jika tanggal masa lalu,
--         validasi tipe (Makanan/Minuman)
CREATE OR ALTER PROCEDURE sp_TambahKonsumsi
    @nama_item VARCHAR(100),
    @kalori    DECIMAL(10,2),
    @tipe      VARCHAR(10),
    @tanggal   DATE
AS
BEGIN
    SET NOCOUNT ON;

    IF @tanggal < CAST(GETDATE() AS DATE)
    BEGIN
        RAISERROR('Tidak dapat menambah data untuk tanggal yang sudah lewat.', 16, 1);
        RETURN;
    END

    IF @tipe NOT IN ('Makanan', 'Minuman')
    BEGIN
        RAISERROR('Tipe harus Makanan atau Minuman.', 16, 1);
        RETURN;
    END

    DECLARE @id_target INT;
    SELECT @id_target = id_target FROM Target WHERE tanggal = @tanggal;

    IF @id_target IS NULL
    BEGIN
        INSERT INTO Target (target_kalori, tanggal) VALUES (2000, @tanggal);
        SET @id_target = SCOPE_IDENTITY();
    END

    INSERT INTO Konsumsi (id_target, nama_item, kalori, tipe, tanggal)
    VALUES (@id_target, @nama_item, @kalori, @tipe, @tanggal);

    SELECT
        SUM(kalori) AS total_kalori_hari_ini,
        COUNT(*)    AS jumlah_item
    FROM Konsumsi
    WHERE tanggal = @tanggal;
END
GO

-- SP 2: UPDATE Konsumsi
-- Logika: blokir jika tanggal masa lalu,
--         beri peringatan jika kalori melebihi 2x target
CREATE OR ALTER PROCEDURE sp_UpdateKonsumsi
    @id_konsumsi INT,
    @nama_item   VARCHAR(100),
    @kalori      DECIMAL(10,2),
    @tipe        VARCHAR(10),
    @tanggal     DATE,
    @pesan       VARCHAR(200) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    IF @tanggal < CAST(GETDATE() AS DATE)
    BEGIN
        SET @pesan = 'BLOCKED';
        RAISERROR('Tidak dapat mengubah data untuk tanggal yang sudah lewat.', 16, 1);
        RETURN;
    END

    IF @tipe NOT IN ('Makanan', 'Minuman')
    BEGIN
        SET @pesan = 'BLOCKED';
        RAISERROR('Tipe harus Makanan atau Minuman.', 16, 1);
        RETURN;
    END

    DECLARE @target_kalori DECIMAL(10,2);
    DECLARE @total_lain    DECIMAL(10,2);

    SELECT @target_kalori = target_kalori
    FROM Target WHERE tanggal = @tanggal;

    SELECT @total_lain = ISNULL(SUM(kalori), 0)
    FROM Konsumsi
    WHERE tanggal = @tanggal AND id_konsumsi <> @id_konsumsi;

    IF @target_kalori IS NOT NULL
       AND (@total_lain + @kalori) > (@target_kalori * 2)
        SET @pesan = 'PERINGATAN: Total kalori melebihi 2x target harian! Data tetap disimpan.';
    ELSE
        SET @pesan = 'OK';

    UPDATE Konsumsi
    SET nama_item = @nama_item,
        kalori    = @kalori,
        tipe      = @tipe,
        tanggal   = @tanggal
    WHERE id_konsumsi = @id_konsumsi;
END
GO

-- SP 3: DELETE Konsumsi
-- Logika: blokir jika tanggal masa lalu,
--         hapus Target jika sudah tidak ada data di tanggal itu
CREATE OR ALTER PROCEDURE sp_HapusKonsumsi
    @id_konsumsi         INT,
    @target_juga_dihapus BIT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @tanggal   DATE;
    DECLARE @id_target INT;

    SELECT @tanggal   = tanggal,
           @id_target = id_target
    FROM Konsumsi WHERE id_konsumsi = @id_konsumsi;

    IF @tanggal < CAST(GETDATE() AS DATE)
    BEGIN
        SET @target_juga_dihapus = 0;
        RAISERROR('Tidak dapat menghapus data untuk tanggal yang sudah lewat.', 16, 1);
        RETURN;
    END

    DELETE FROM Konsumsi WHERE id_konsumsi = @id_konsumsi;

    DECLARE @sisa_konsumsi  INT;
    DECLARE @sisa_aktivitas INT;
    SELECT @sisa_konsumsi  = COUNT(*) FROM Konsumsi  WHERE id_target = @id_target;
    SELECT @sisa_aktivitas = COUNT(*) FROM Aktivitas WHERE id_target = @id_target;

    IF (@sisa_konsumsi + @sisa_aktivitas) = 0
    BEGIN
        DELETE FROM Target WHERE id_target = @id_target;
        SET @target_juga_dihapus = 1;
    END
    ELSE
        SET @target_juga_dihapus = 0;
END
GO

-- SP 4: SEARCH Konsumsi
-- Logika: filter by keyword, tipe, range tanggal
--         hanya data aktif (>= hari ini)
CREATE OR ALTER PROCEDURE sp_CariKonsumsi
    @keyword     VARCHAR(100) = NULL,
    @tipe        VARCHAR(10)  = NULL,
    @tgl_mulai   DATE         = NULL,
    @tgl_selesai DATE         = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        k.id_konsumsi,
        k.id_target,
        t.target_kalori,
        k.nama_item,
        k.kalori,
        k.tipe,
        k.tanggal
    FROM Konsumsi k
    INNER JOIN Target t ON k.id_target = t.id_target
    WHERE k.tanggal >= CAST(GETDATE() AS DATE)
      AND (@keyword     IS NULL OR k.nama_item LIKE '%' + @keyword + '%')
      AND (@tipe        IS NULL OR k.tipe      = @tipe)
      AND (@tgl_mulai   IS NULL OR k.tanggal  >= @tgl_mulai)
      AND (@tgl_selesai IS NULL OR k.tanggal  <= @tgl_selesai)
    ORDER BY k.tanggal DESC, k.id_konsumsi DESC;
END
GO

-- SP 5: INSERT Aktivitas
-- Logika: auto-create Target jika belum ada,
--         blokir jika tanggal masa lalu
CREATE OR ALTER PROCEDURE sp_TambahAktivitas
    @nama_aktivitas  VARCHAR(100),
    @kalori_terbakar DECIMAL(10,2),
    @tanggal         DATE
AS
BEGIN
    SET NOCOUNT ON;

    IF @tanggal < CAST(GETDATE() AS DATE)
    BEGIN
        RAISERROR('Tidak dapat menambah aktivitas untuk tanggal yang sudah lewat.', 16, 1);
        RETURN;
    END

    DECLARE @id_target INT;
    SELECT @id_target = id_target FROM Target WHERE tanggal = @tanggal;

    IF @id_target IS NULL
    BEGIN
        INSERT INTO Target (target_kalori, tanggal) VALUES (2000, @tanggal);
        SET @id_target = SCOPE_IDENTITY();
    END

    INSERT INTO Aktivitas (id_target, nama_aktivitas, kalori_terbakar, tanggal)
    VALUES (@id_target, @nama_aktivitas, @kalori_terbakar, @tanggal);

    SELECT
        SUM(kalori_terbakar) AS total_terbakar_hari_ini,
        COUNT(*)             AS jumlah_aktivitas
    FROM Aktivitas
    WHERE tanggal = @tanggal;
END
GO

-- SP 6: UPDATE Aktivitas
-- Logika: blokir jika tanggal masa lalu
CREATE OR ALTER PROCEDURE sp_UpdateAktivitas
    @id_aktivitas    INT,
    @nama_aktivitas  VARCHAR(100),
    @kalori_terbakar DECIMAL(10,2),
    @tanggal         DATE
AS
BEGIN
    SET NOCOUNT ON;

    IF @tanggal < CAST(GETDATE() AS DATE)
    BEGIN
        RAISERROR('Tidak dapat mengubah aktivitas untuk tanggal yang sudah lewat.', 16, 1);
        RETURN;
    END

    UPDATE Aktivitas
    SET nama_aktivitas  = @nama_aktivitas,
        kalori_terbakar = @kalori_terbakar,
        tanggal         = @tanggal
    WHERE id_aktivitas = @id_aktivitas;
END
GO

-- SP 7: DELETE Aktivitas
-- Logika: blokir jika tanggal masa lalu
CREATE OR ALTER PROCEDURE sp_HapusAktivitas
    @id_aktivitas INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @tanggal DATE;
    SELECT @tanggal = tanggal FROM Aktivitas WHERE id_aktivitas = @id_aktivitas;

    IF @tanggal < CAST(GETDATE() AS DATE)
    BEGIN
        RAISERROR('Tidak dapat menghapus aktivitas untuk tanggal yang sudah lewat.', 16, 1);
        RETURN;
    END

    DELETE FROM Aktivitas WHERE id_aktivitas = @id_aktivitas;
END
GO

-- SP 8: SET Target
-- Logika: blokir jika tanggal masa lalu,
--         UPDATE jika sudah ada, INSERT jika belum ada
CREATE OR ALTER PROCEDURE sp_SetTarget
    @tanggal       DATE,
    @target_kalori DECIMAL(10,2),
    @is_update     BIT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    IF @tanggal < CAST(GETDATE() AS DATE)
    BEGIN
        SET @is_update = 0;
        RAISERROR('Tidak dapat mengubah target untuk tanggal yang sudah lewat.', 16, 1);
        RETURN;
    END

    DECLARE @existing INT;
    SELECT @existing = id_target FROM Target WHERE tanggal = @tanggal;

    IF @existing IS NOT NULL
    BEGIN
        UPDATE Target SET target_kalori = @target_kalori WHERE tanggal = @tanggal;
        SET @is_update = 1;
    END
    ELSE
    BEGIN
        INSERT INTO Target (target_kalori, tanggal) VALUES (@target_kalori, @tanggal);
        SET @is_update = 0;
    END
END
GO

-- SP 9: COUNT Konsumsi (OUTPUT PARAMETER)
-- Mengembalikan jumlah record konsumsi aktif
CREATE OR ALTER PROCEDURE sp_CountKonsumsi
    @total INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT @total = COUNT(*) FROM Konsumsi
    WHERE tanggal >= CAST(GETDATE() AS DATE);
END
GO

-- SP 10: COUNT Aktivitas (OUTPUT PARAMETER)
-- Mengembalikan jumlah record aktivitas aktif
CREATE OR ALTER PROCEDURE sp_CountAktivitas
    @total INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT @total = COUNT(*) FROM Aktivitas
    WHERE tanggal >= CAST(GETDATE() AS DATE);
END
GO

-- SP 11: IMPORT Konsumsi dari Excel
-- Logika: validasi tipe, auto-create Target,
--         skip duplikat via OUTPUT PARAMETER @status
CREATE OR ALTER PROCEDURE sp_ImportKonsumsi
    @nama_item VARCHAR(100),
    @kalori    DECIMAL(10,2),
    @tipe      VARCHAR(10),
    @tanggal   DATE,
    @status    VARCHAR(20) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    IF @tipe NOT IN ('Makanan', 'Minuman')
    BEGIN
        RAISERROR('Tipe harus Makanan atau Minuman.', 16, 1);
        RETURN;
    END

    DECLARE @id_target INT;
    SELECT @id_target = id_target FROM Target WHERE tanggal = @tanggal;

    IF @id_target IS NULL
    BEGIN
        INSERT INTO Target (target_kalori, tanggal) VALUES (2000, @tanggal);
        SET @id_target = SCOPE_IDENTITY();
    END

    -- Cek duplikat: nama_item + tipe + tanggal yang sama
    IF EXISTS (
        SELECT 1 FROM Konsumsi
        WHERE id_target = @id_target
          AND nama_item = @nama_item
          AND tipe      = @tipe
    )
    BEGIN
        SET @status = 'SKIPPED';
        RETURN;
    END

    INSERT INTO Konsumsi (id_target, nama_item, kalori, tipe, tanggal)
    VALUES (@id_target, @nama_item, @kalori, @tipe, @tanggal);

    SET @status = 'INSERTED';
END
GO

-- SP 12: IMPORT Aktivitas dari Excel
-- Logika: auto-create Target,
--         skip duplikat via OUTPUT PARAMETER @status
CREATE OR ALTER PROCEDURE sp_ImportAktivitas
    @nama_aktivitas  VARCHAR(100),
    @kalori_terbakar DECIMAL(10,2),
    @tanggal         DATE,
    @status          VARCHAR(20) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @id_target INT;
    SELECT @id_target = id_target FROM Target WHERE tanggal = @tanggal;

    IF @id_target IS NULL
    BEGIN
        INSERT INTO Target (target_kalori, tanggal) VALUES (2000, @tanggal);
        SET @id_target = SCOPE_IDENTITY();
    END

    -- Cek duplikat: nama_aktivitas + tanggal yang sama
    IF EXISTS (
        SELECT 1 FROM Aktivitas
        WHERE id_target     = @id_target
          AND nama_aktivitas = @nama_aktivitas
    )
    BEGIN
        SET @status = 'SKIPPED';
        RETURN;
    END

    INSERT INTO Aktivitas (id_target, nama_aktivitas, kalori_terbakar, tanggal)
    VALUES (@id_target, @nama_aktivitas, @kalori_terbakar, @tanggal);

    SET @status = 'INSERTED';
END
GO

-- SP 13: Report Konsumsi per Tanggal
-- Digunakan oleh Crystal Reports
CREATE OR ALTER PROCEDURE sp_ReportKonsumsi
    @tanggal DATE
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        k.nama_item     AS NamaItem,
        k.kalori        AS Kalori,
        k.tipe          AS Tipe,
        k.tanggal       AS TanggalKonsumsi,
        t.target_kalori AS TargetKalori
    FROM Konsumsi k
    INNER JOIN Target t ON k.id_target = t.id_target
    WHERE k.tanggal = @tanggal
    ORDER BY k.tipe, k.nama_item;
END
GO

-- SP 14: Report Aktivitas per Tanggal
-- Digunakan oleh Crystal Reports
CREATE OR ALTER PROCEDURE sp_ReportAktivitas
    @tanggal DATE
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        a.nama_aktivitas  AS NamaAktivitas,
        a.kalori_terbakar AS KaloriTerbakar,
        a.tanggal         AS TanggalAktivitas
    FROM Aktivitas a
    INNER JOIN Target t ON a.id_target = t.id_target
    WHERE a.tanggal = @tanggal
    ORDER BY a.nama_aktivitas;
END
GO

-- SP 15: Report Ringkasan per Tanggal
-- Digunakan oleh Crystal Reports untuk summary
CREATE OR ALTER PROCEDURE sp_ReportRingkasan
    @tanggal DATE
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        t.tanggal                                         AS Tanggal,
        t.target_kalori                                   AS TargetKalori,
        ISNULL(SUM(k.kalori), 0)                          AS TotalMasuk,
        ISNULL(MAX(akt.total_bakar), 0)                   AS TotalTerbakar,
        ISNULL(SUM(k.kalori), 0)
            - ISNULL(MAX(akt.total_bakar), 0)             AS KaloriBersih,
        CASE
            WHEN ISNULL(SUM(k.kalori), 0)
                - ISNULL(MAX(akt.total_bakar), 0) <= t.target_kalori
            THEN 'TERCAPAI'
            ELSE 'MELEBIHI'
        END AS Status
    FROM Target t
    LEFT JOIN Konsumsi k ON k.id_target = t.id_target
    LEFT JOIN (
        SELECT id_target, SUM(kalori_terbakar) AS total_bakar
        FROM Aktivitas
        GROUP BY id_target
    ) akt ON akt.id_target = t.id_target
    WHERE t.tanggal = @tanggal
    GROUP BY t.id_target, t.tanggal, t.target_kalori;
END
GO

-- SP 16: Data Chart Kalori Mingguan
-- Digunakan oleh Dashboard untuk grafik 7 hari terakhir
CREATE OR ALTER PROCEDURE sp_ChartKaloriMingguan
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        t.tanggal,
        ISNULL(SUM(k.kalori), 0)        AS total_masuk,
        ISNULL(MAX(akt.total_bakar), 0) AS total_terbakar,
        t.target_kalori
    FROM Target t
    LEFT JOIN Konsumsi k ON k.id_target = t.id_target
    LEFT JOIN (
        SELECT id_target, SUM(kalori_terbakar) AS total_bakar
        FROM Aktivitas
        GROUP BY id_target
    ) akt ON akt.id_target = t.id_target
    WHERE t.tanggal >= CAST(GETDATE()-6 AS DATE)
    GROUP BY t.id_target, t.tanggal, t.target_kalori
    ORDER BY t.tanggal;
END
GO

-- ============================================================
-- 6. TABEL LOGGING
-- ============================================================

-- Tabel LogAktivitasDB: mencatat setiap INSERT/UPDATE/DELETE
IF OBJECT_ID('dbo.LogAktivitasDB', 'U') IS NULL
BEGIN
    CREATE TABLE LogAktivitasDB (
        id_log     INT          PRIMARY KEY IDENTITY(1,1),
        tabel      VARCHAR(20)  NOT NULL,
        aksi       VARCHAR(10)  NOT NULL,
        id_record  INT          NULL,
        keterangan VARCHAR(500) NULL,
        waktu      DATETIME     NOT NULL DEFAULT GETDATE()
    );
    PRINT 'Tabel LogAktivitasDB berhasil dibuat.';
END
ELSE
    PRINT 'Tabel LogAktivitasDB sudah ada, dilewati.';
GO

-- Tabel LogKeamanan: mencatat percobaan update massal yang diblokir
IF OBJECT_ID('dbo.LogKeamanan', 'U') IS NULL
BEGIN
    CREATE TABLE LogKeamanan (
        id_log      INT          PRIMARY KEY IDENTITY(1,1),
        aksi        VARCHAR(200) NOT NULL,
        jumlah_data INT          NOT NULL,
        waktu       DATETIME     NOT NULL DEFAULT GETDATE()
    );
    PRINT 'Tabel LogKeamanan berhasil dibuat.';
END
ELSE
    PRINT 'Tabel LogKeamanan sudah ada, dilewati.';
GO

-- Tabel LogError: mencatat error dari aplikasi
IF OBJECT_ID('dbo.LogError', 'U') IS NULL
BEGIN
    CREATE TABLE LogError (
        id_log      INT          PRIMARY KEY IDENTITY(1,1),
        waktu       DATETIME     NOT NULL DEFAULT GETDATE(),
        pesan_error VARCHAR(MAX) NOT NULL
    );
    PRINT 'Tabel LogError berhasil dibuat.';
END
ELSE
    PRINT 'Tabel LogError sudah ada, dilewati.';
GO

-- SP Logging: menyimpan pesan error dari aplikasi
CREATE OR ALTER PROCEDURE sp_LogMessage
    @pesan VARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO LogError (pesan_error) VALUES (@pesan);
END
GO

-- ============================================================
-- 7. TRIGGERS
-- ============================================================

-- TRIGGER 1: Logging INSERT Konsumsi
-- Alasan di trigger: agar logging berjalan otomatis
-- dari manapun data dimasukkan, tidak bergantung pada SP
CREATE OR ALTER TRIGGER trg_AfterInsertKonsumsi
ON Konsumsi
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO LogAktivitasDB (tabel, aksi, id_record, keterangan, waktu)
    SELECT
        'Konsumsi',
        'INSERT',
        i.id_konsumsi,
        'Tambah item: '  + i.nama_item +
        ' | Kalori: '    + CAST(i.kalori AS VARCHAR) + ' kkal' +
        ' | Tipe: '      + i.tipe +
        ' | Tgl: '       + CONVERT(VARCHAR, i.tanggal, 103),
        GETDATE()
    FROM inserted i;
END;
GO

-- TRIGGER 2: Logging UPDATE Konsumsi
-- Mencatat data sebelum dan sesudah perubahan
CREATE OR ALTER TRIGGER trg_AfterUpdateKonsumsi
ON Konsumsi
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO LogAktivitasDB (tabel, aksi, id_record, keterangan, waktu)
    SELECT
        'Konsumsi',
        'UPDATE',
        i.id_konsumsi,
        'Ubah item: [' + d.nama_item + ' ' + CAST(d.kalori AS VARCHAR) + ' kkal]' +
        ' -> ['        + i.nama_item + ' ' + CAST(i.kalori AS VARCHAR) + ' kkal]',
        GETDATE()
    FROM inserted i
    INNER JOIN deleted d ON i.id_konsumsi = d.id_konsumsi;
END;
GO

-- TRIGGER 3: Logging DELETE Konsumsi
CREATE OR ALTER TRIGGER trg_AfterDeleteKonsumsi
ON Konsumsi
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO LogAktivitasDB (tabel, aksi, id_record, keterangan, waktu)
    SELECT
        'Konsumsi',
        'DELETE',
        d.id_konsumsi,
        'Hapus item: ' + d.nama_item +
        ' | Kalori: '  + CAST(d.kalori AS VARCHAR) + ' kkal' +
        ' | Tgl: '     + CONVERT(VARCHAR, d.tanggal, 103),
        GETDATE()
    FROM deleted d;
END;
GO

-- TRIGGER 4: Logging INSERT Aktivitas
CREATE OR ALTER TRIGGER trg_AfterInsertAktivitas
ON Aktivitas
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO LogAktivitasDB (tabel, aksi, id_record, keterangan, waktu)
    SELECT
        'Aktivitas',
        'INSERT',
        i.id_aktivitas,
        'Tambah aktivitas: ' + i.nama_aktivitas +
        ' | Terbakar: '      + CAST(i.kalori_terbakar AS VARCHAR) + ' kkal' +
        ' | Tgl: '           + CONVERT(VARCHAR, i.tanggal, 103),
        GETDATE()
    FROM inserted i;
END;
GO

-- TRIGGER 5: Logging DELETE Aktivitas
CREATE OR ALTER TRIGGER trg_AfterDeleteAktivitas
ON Aktivitas
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO LogAktivitasDB (tabel, aksi, id_record, keterangan, waktu)
    SELECT
        'Aktivitas',
        'DELETE',
        d.id_aktivitas,
        'Hapus aktivitas: ' + d.nama_aktivitas +
        ' | Terbakar: '     + CAST(d.kalori_terbakar AS VARCHAR) + ' kkal' +
        ' | Tgl: '          + CONVERT(VARCHAR, d.tanggal, 103),
        GETDATE()
    FROM deleted d;
END;
GO

-- TRIGGER 6: Keamanan — Blokir UPDATE Massal Konsumsi
-- Alasan di trigger: proteksi level database, tidak bisa
-- dibypass dari aplikasi manapun. Ini security layer.
-- Cara kerja: jika UPDATE lebih dari 5 baris sekaligus,
-- transaksi dibatalkan dan dicatat ke LogKeamanan
CREATE OR ALTER TRIGGER trg_PreventMassUpdateKonsumsi
ON Konsumsi
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @jumlah INT;
    SELECT @jumlah = COUNT(*) FROM inserted;

    IF @jumlah > 5
    BEGIN
        INSERT INTO LogKeamanan (aksi, jumlah_data, waktu)
        VALUES (
            'WARNING: Update massal terdeteksi pada tabel Konsumsi',
            @jumlah,
            GETDATE()
        );

        ROLLBACK TRANSACTION;

        RAISERROR(
            'Update dibatalkan! Terlalu banyak data diubah sekaligus (%d baris). Maksimal 5 baris per operasi.',
            16, 1, @jumlah
        );
    END
END;
GO

-- ============================================================
-- 8. BACKUP TABLE (untuk demo SQL Injection)
-- ============================================================
SELECT * INTO Konsumsi_Backup FROM Konsumsi;
GO

-- ============================================================
-- 9. RESET DATA (Transaction Management)
-- Mengembalikan data Konsumsi dari backup
-- ============================================================
BEGIN TRANSACTION;
BEGIN TRY
    IF OBJECT_ID('dbo.Konsumsi_Backup') IS NOT NULL
    BEGIN
        DELETE FROM dbo.Konsumsi;

        SET IDENTITY_INSERT dbo.Konsumsi ON;

        INSERT INTO dbo.Konsumsi (id_konsumsi, id_target, nama_item, kalori, tipe, tanggal)
        SELECT id_konsumsi, id_target, nama_item, kalori, tipe, tanggal
        FROM dbo.Konsumsi_Backup;

        SET IDENTITY_INSERT dbo.Konsumsi OFF;
    END
    COMMIT;
    PRINT 'Reset data berhasil.';
END TRY
BEGIN CATCH
    SET IDENTITY_INSERT dbo.Konsumsi OFF;
    ROLLBACK;
    PRINT 'Error reset: ' + ERROR_MESSAGE();
END CATCH;
GO

-- ============================================================
-- 10. VERIFIKASI AKHIR
-- ============================================================

-- Cek semua tabel
SELECT name FROM sys.tables ORDER BY name;

-- Cek semua view
SELECT name FROM sys.views ORDER BY name;

-- Cek semua stored procedure
SELECT name FROM sys.procedures ORDER BY name;

-- Cek semua trigger
SELECT
    t.name                    AS nama_trigger,
    OBJECT_NAME(t.parent_id)  AS nama_tabel,
    t.is_disabled,
    te.type_desc              AS event_type
FROM sys.triggers t
INNER JOIN sys.trigger_events te ON t.object_id = te.object_id
WHERE OBJECT_NAME(t.parent_id) IN ('Konsumsi', 'Aktivitas')
ORDER BY nama_tabel, nama_trigger;

-- Cek sample data
SELECT * FROM Target          ORDER BY tanggal;
SELECT * FROM Konsumsi        ORDER BY tanggal;
SELECT * FROM Aktivitas       ORDER BY tanggal;
SELECT * FROM vw_KonsumsiAktif      ORDER BY tanggal;
SELECT * FROM vw_AktivitasAktif     ORDER BY tanggal;
SELECT * FROM vw_RiwayatKonsumsi    ORDER BY tanggal DESC;
SELECT * FROM vw_RiwayatAktivitas   ORDER BY tanggal DESC;
SELECT * FROM vw_RingkasanRiwayat   ORDER BY tanggal DESC;
GO