<div align="center">
  <img width="360" height="360" alt="AMKH Logo" src="https://github.com/user-attachments/assets/862ee360-9960-48a4-b20a-2bcb3cbaa47e" />
  <h1>AMKH</h1>
  <p><strong>Aplikasi Monitoring Kalori Harian</strong></p>
  <p>Aplikasi desktop berbasis C# Windows Forms untuk memantau asupan kalori harian, aktivitas fisik, dan progress kesehatan secara visual.</p>
</div>

---

## Daftar Isi
- [Tampilan Aplikasi](#tampilan-aplikasi)
- [Stored Procedure](#stored-procedure)
- [View](#view)
- [Trigger](#trigger)
- [Error Handling & Logging](#error-handling--logging)
- [Transaction Management](#transaction-management)
- [Import Data dari Excel](#import-data-dari-excel)
- [Crystal Reports](#crystal-reports)
- [Dashboard & Grafik](#dashboard--grafik)
- [SQL Injection Demo](#sql-injection-demo)
- [DataGridView Binding & Binding Navigator](#datagridview-binding--binding-navigator)
- [Deploy Aplikasi](#deploy-aplikasi)

---

## Tampilan Aplikasi

### Form Utama (Navbar)
<img width="1040" height="145" alt="image" src="https://github.com/user-attachments/assets/3c90a91e-5e28-434a-89d3-7914e740cd0e" />

### Form Dashboard
<!-- Screenshot Form Dashboard dengan chart kalori 7 hari -->

### Form Konsumsi
<img width="1045" height="1031" alt="image" src="https://github.com/user-attachments/assets/27cb83f8-c82c-451b-b9e0-8314b3fed02e" />

### Form Aktivitas
<img width="1044" height="1033" alt="image" src="https://github.com/user-attachments/assets/2a07337e-8349-4c8a-8969-e2b8fcba1c21" />

### Form Riwayat
<img width="1050" height="1031" alt="image" src="https://github.com/user-attachments/assets/4b90bd94-fa41-4e7e-a68b-205af98182f7" />

### Form Rekap & Cetak Laporan
<!-- Screenshot Form Rekap dengan data konsumsi + aktivitas + ringkasan -->

### Form Report (Crystal Reports)
<!-- Screenshot tampilan cetak Crystal Report -->

---

## Stored Procedure

Seluruh operasi manipulasi data dilakukan melalui Stored Procedure di SQL Server.

### Daftar Stored Procedure

| Nama SP | Fungsi |
|---|---|
| `sp_TambahKonsumsi` | INSERT data konsumsi, auto-create Target jika belum ada |
| `sp_UpdateKonsumsi` | UPDATE data konsumsi, cek peringatan jika melebihi 2x target |
| `sp_HapusKonsumsi` | DELETE data konsumsi, hapus Target jika sudah kosong |
| `sp_CariKonsumsi` | SELECT konsumsi dengan filter keyword, tipe, dan range tanggal |
| `sp_TambahAktivitas` | INSERT data aktivitas |
| `sp_UpdateAktivitas` | UPDATE data aktivitas |
| `sp_HapusAktivitas` | DELETE data aktivitas |
| `sp_SetTarget` | INSERT atau UPDATE target kalori harian |
| `sp_CountKonsumsi` | Mengembalikan jumlah record konsumsi aktif via OUTPUT PARAMETER |
| `sp_CountAktivitas` | Mengembalikan jumlah record aktivitas aktif via OUTPUT PARAMETER |
| `sp_ImportKonsumsi` | Import data konsumsi dari Excel, validasi duplikat via OUTPUT PARAMETER |
| `sp_ImportAktivitas` | Import data aktivitas dari Excel, validasi duplikat via OUTPUT PARAMETER |
| `sp_ReportKonsumsi` | Ambil data konsumsi per tanggal untuk Crystal Report |
| `sp_ReportAktivitas` | Ambil data aktivitas per tanggal untuk Crystal Report |
| `sp_ReportRingkasan` | Ringkasan kalori harian untuk Crystal Report |
| `sp_ChartKaloriMingguan` | Data kalori 7 hari terakhir untuk grafik Dashboard |
| `sp_LogMessage` | Insert pesan log ke tabel LogError |

### Bukti Stored Procedure di SQL Server
<img width="438" height="345" alt="image" src="https://github.com/user-attachments/assets/1f1a9460-84d2-4621-9b87-846a87e31309" />

### Bukti Implementasi di Windows Form

#### Tambah Konsumsi (memanggil sp_TambahKonsumsi)
<img width="1048" height="1031" alt="image" src="https://github.com/user-attachments/assets/bc66eca0-6f62-4d5f-80e6-948f0602921f" />
<img width="1044" height="1033" alt="image" src="https://github.com/user-attachments/assets/c7658cfb-bf8a-422e-b97a-6725bd6b500c" />

#### Update Konsumsi (memanggil sp_UpdateKonsumsi)
<img width="1047" height="1032" alt="image" src="https://github.com/user-attachments/assets/f9ab2261-f1d4-4f3a-86e5-a3f39f78a114" />
<img width="1053" height="1031" alt="image" src="https://github.com/user-attachments/assets/cd1ac983-dfb5-4276-8212-b167cfde3a9f" />

#### Hapus Konsumsi (memanggil sp_HapusKonsumsi)
<img width="1047" height="1032" alt="image" src="https://github.com/user-attachments/assets/f9ab2261-f1d4-4f3a-86e5-a3f39f78a114" />
<img width="1047" height="1031" alt="image" src="https://github.com/user-attachments/assets/f71dd973-5642-45d9-943c-dad4b7a3136c" />

#### Tambah Aktivitas (memanggil sp_TambahAktivitas)
<img width="1050" height="1033" alt="image" src="https://github.com/user-attachments/assets/bc183b0f-c1fc-439a-a89f-c7bf1b581d6c" />

#### Update Aktivitas (memanggil sp_UpdateAktivitas)
<img width="1048" height="1029" alt="image" src="https://github.com/user-attachments/assets/c6f87565-76af-474c-a649-1dd71d2bd2a1" />

#### Hapus Aktivitas (memanggil sp_HapusAktivitas)
<img width="1049" height="1032" alt="image" src="https://github.com/user-attachments/assets/0c7241e8-d15c-4a57-a255-2bcd499ebc3c" />

#### Output Parameter — Count Record
<img width="1039" height="238" alt="image" src="https://github.com/user-attachments/assets/8fe87163-3da5-40ff-a975-6c4d3b7635f7" />
<img width="1040" height="239" alt="image" src="https://github.com/user-attachments/assets/b330481d-8d0c-4423-9613-391426ba8e99" />

---

## View

Seluruh tampilan data di DataGridView menggunakan View yang dibuat di SQL Server.

### Daftar View

| Nama View | Fungsi |
|---|---|
| `vw_KonsumsiAktif` | Konsumsi tanggal >= hari ini (dapat diedit) |
| `vw_AktivitasAktif` | Aktivitas tanggal >= hari ini (dapat diedit) |
| `vw_RiwayatKonsumsi` | Konsumsi tanggal < hari ini (read-only) |
| `vw_RiwayatAktivitas` | Aktivitas tanggal < hari ini (read-only) |
| `vw_RingkasanRiwayat` | Ringkasan per tanggal: total kalori masuk, terbakar, bersih, status |

### Bukti View di SQL Server
<img width="434" height="198" alt="image" src="https://github.com/user-attachments/assets/a9968195-b706-4a03-8f22-1cf0b40d0a62" />

### Bukti Implementasi di Windows Form

#### vw_KonsumsiAktif — Form Konsumsi
<img width="1041" height="177" alt="image" src="https://github.com/user-attachments/assets/66a6af19-02e7-45dc-8481-9bb478dfc00f" />

#### vw_AktivitasAktif — Form Aktivitas
<img width="1041" height="75" alt="image" src="https://github.com/user-attachments/assets/85a34819-156a-4451-849b-c74813a2cf19" />

#### vw_RiwayatKonsumsi & vw_RiwayatAktivitas — Form Riwayat
<img width="1044" height="430" alt="image" src="https://github.com/user-attachments/assets/835565b8-fd29-4022-b09a-8be451576f39" />

#### vw_RingkasanRiwayat — Ringkasan Form Riwayat
<img width="1043" height="102" alt="image" src="https://github.com/user-attachments/assets/26c8cf8d-a366-414f-8372-665f27d4aafa" />

---

## Trigger

Trigger dibuat di SQL Server untuk monitoring otomatis setiap perubahan data.

### Daftar Trigger

| Nama Trigger | Event | Fungsi |
|---|---|---|
| `trg_AfterInsertKonsumsi` | AFTER INSERT | Catat aktivitas tambah konsumsi ke LogAktivitasDB |
| `trg_AfterUpdateKonsumsi` | AFTER UPDATE | Catat aktivitas update konsumsi ke LogAktivitasDB |
| `trg_AfterDeleteKonsumsi` | AFTER DELETE | Catat aktivitas hapus konsumsi ke LogAktivitasDB |
| `trg_AfterInsertAktivitas` | AFTER INSERT | Catat aktivitas tambah aktivitas ke LogAktivitasDB |
| `trg_AfterUpdateAktivitas` | AFTER UPDATE | Catat aktivitas update aktivitas ke LogAktivitasDB |
| `trg_AfterDeleteAktivitas` | AFTER DELETE | Catat aktivitas hapus aktivitas ke LogAktivitasDB |
| `trg_PreventMassUpdateKonsumsi` | AFTER UPDATE | Blokir UPDATE massal jika lebih dari 5 baris sekaligus |

### Cara Kerja Trigger Keamanan

Jika ada UPDATE lebih dari 5 data sekaligus (contoh: SQL Injection), trigger akan:
1. Menyimpan log ke tabel `LogKeamanan`
2. Melakukan `ROLLBACK TRANSACTION`
3. Menampilkan pesan error via `RAISERROR`

<!-- Screenshot hasil trigger di LogAktivitasDB -->
<!-- Screenshot trigger keamanan saat SQL Injection diblokir -->

---

## Error Handling & Logging

Setiap operasi database dibungkus dengan `try-catch` yang menangani:
- `SqlException` — error spesifik SQL Server
- `Exception` — error umum

Error yang terjadi otomatis tersimpan ke tabel `LogError` di database.

### Tabel Log

| Nama Tabel | Fungsi |
|---|---|
| `LogError` | Menyimpan pesan error dari aplikasi |
| `LogAktivitasDB` | Menyimpan log setiap INSERT/UPDATE/DELETE via Trigger |
| `LogKeamanan` | Menyimpan log percobaan update massal |

<!-- Screenshot tabel LogError di SSMS -->
<!-- Screenshot tabel LogAktivitasDB di SSMS -->

---

## Transaction Management

Operasi INSERT pada konsumsi menggunakan `SqlTransaction` untuk memastikan atomicity — jika salah satu operasi gagal, seluruh transaksi dibatalkan (Rollback).

```csharp
SqlTransaction trans = conn.BeginTransaction();
try
{
    // INSERT konsumsi
    // INSERT log aktivitas
    trans.Commit();
}
catch (SqlException ex)
{
    trans.Rollback();
    SimpanLog("ROLLBACK INSERT : " + ex.Message);
}
```

---

## Import Data dari Excel

Fitur import Excel tersedia di **Form Konsumsi** dan **Form Aktivitas** menggunakan library `ExcelDataReader`.

### Format File Excel

**Konsumsi** (kolom harus persis):
| nama_item | kalori | tipe | tanggal |
|---|---|---|---|
| Nasi putih | 250 | Makanan | 2026-06-19 |

**Aktivitas** (kolom harus persis):
| nama_aktivitas | kalori_terbakar | tanggal |
|---|---|---|
| Jogging 30 menit | 300 | 2026-06-19 |

### Validasi Duplikat

Import dilengkapi validasi duplikat via OUTPUT PARAMETER di Stored Procedure. Jika data sudah ada, baris tersebut akan di-skip dan dihitung sebagai duplikat.

Pesan hasil import:
```
Import selesai!
Berhasil  : 10 baris
Duplikat  : 3 baris (diskip)
Gagal     : 0 baris
```

<!-- Screenshot proses import Excel -->
<!-- Screenshot pesan hasil import -->

---

## Crystal Reports

Fitur cetak laporan harian menggunakan **SAP Crystal Reports** via Form Rekap.

### Alur Penggunaan

1. Klik menu **📋 Rekap** di navbar
2. Pilih tanggal yang ingin dicetak
3. Klik **Load Data** — preview konsumsi, aktivitas, dan ringkasan muncul
4. Klik **🖨 Cetak Laporan** — Crystal Report terbuka

### Isi Laporan

- Header: judul laporan + logo
- Section Konsumsi: daftar item konsumsi + kalori
- Section Aktivitas: daftar aktivitas + kalori terbakar
- Footer: total kalori + status (TERCAPAI / MELEBIHI)

<!-- Screenshot Form Rekap setelah load data -->
<!-- Screenshot tampilan Crystal Report -->

---

## Dashboard & Grafik

Form Dashboard menampilkan ringkasan kalori hari ini dan grafik tren kalori 7 hari terakhir.

### Fitur Dashboard

- **Info Hari Ini**: target, kalori masuk, kalori terbakar, kalori bersih, status
- **Grafik Column**: perbandingan kalori masuk vs terbakar per hari
- **Garis Target**: visualisasi target kalori sebagai garis merah putus-putus
- **Tombol Refresh**: memperbarui data secara manual

### Stored Procedure Chart

```sql
sp_ChartKaloriMingguan
-- Mengambil data 7 hari terakhir:
-- tanggal, total_masuk, total_terbakar, target_kalori
```

<!-- Screenshot Form Dashboard dengan chart terisi -->

---

## SQL Injection Demo

### Skenario Demo

Demo dilakukan di **Form Konsumsi** pada panel **⚠ Demo SQL Injection**.

**Langkah-langkah:**

**1. Backup Data**

Klik tombol `1. Backup` untuk menyalin data Konsumsi ke tabel `Konsumsi_Backup`.

<img width="1120" height="1032" alt="image" src="https://github.com/user-attachments/assets/736d4437-13d1-48a9-bcff-7dacf21d0f8f" />

---

**2. Simulasi SQL Injection (Query Tidak Aman)**

Ketik payload berikut di kolom **Nama Item**:
```
' OR '1'='1
```

Lalu klik tombol `2. Test Inject`.

Query yang dieksekusi:
```sql
UPDATE Konsumsi SET nama_item = 'HACKED'
WHERE nama_item = '' OR '1'='1'
```

Karena `'1'='1'` selalu benar, **seluruh baris** terupdate menjadi `HACKED`.

> ⚠️ Namun karena ada **Trigger Keamanan** (`trg_PreventMassUpdateKonsumsi`), jika data lebih dari 5 baris maka UPDATE akan diblokir otomatis.

<img width="1169" height="1030" alt="image" src="https://github.com/user-attachments/assets/30451f01-a504-4233-af32-77ec8a2da99f" />
<img width="1051" height="1031" alt="image" src="https://github.com/user-attachments/assets/7b6c831f-b234-459f-bffb-f275bd2a46a6" />

---

**3. Query Aman (Parameterized Query)**

Dengan input payload yang sama, klik tombol `3. Query Aman`.

```sql
UPDATE Konsumsi SET nama_item = 'AMAN' WHERE nama_item = @nama
```

Input diperlakukan sebagai **literal string**, bukan perintah SQL — tidak ada baris yang terupdate.

<img width="1052" height="1031" alt="image" src="https://github.com/user-attachments/assets/b2acbbf5-fba1-4389-8b9c-bd443d10008c" />

---

**4. Reset Data**

Klik tombol `4. Reset Data` untuk mengembalikan semua data ke kondisi backup awal.

<img width="1048" height="1030" alt="image" src="https://github.com/user-attachments/assets/ba836177-c7b6-4021-99a4-502b7a47b052" />

---

## DataGridView Binding & Binding Navigator

### DataGridView Binding

DataGridView menggunakan `BindingSource` yang terhubung ke `DataSet` dan `TableAdapter`.

<img width="249" height="252" alt="image" src="https://github.com/user-attachments/assets/9d2cb834-168b-4ab8-a5e4-5dd367bc48d0" />

### Binding Navigator

Setiap form dilengkapi **Binding Navigator** untuk navigasi antar record.

<img width="1045" height="1032" alt="image" src="https://github.com/user-attachments/assets/ff1d6806-6918-49cb-aff3-8a7566d082d5" />
<img width="1048" height="1032" alt="image" src="https://github.com/user-attachments/assets/39985c65-eb80-4a29-af09-495f08621fa8" />

---

## Deploy Aplikasi

### Konfigurasi untuk Client

Aplikasi menggunakan **Dynamic IP Address** untuk koneksi database, sehingga bisa digunakan di laptop client dalam satu jaringan yang sama.

```csharp
public static string GetLocalIPAddress()
{
    // Mengambil IP address laptop server secara otomatis
    var host = Dns.GetHostEntry(Dns.GetHostName());
    foreach (var ip in host.AddressList)
        if (ip.AddressFamily == AddressFamily.InterNetwork)
            return ip.ToString();
    return string.Empty;
}

private static string BuildConnectionString()
{
    string ip = GetLocalIPAddress();
    return $"Data Source={ip}\\INSTANCE;Initial Catalog=AMKH_DB;User ID=sa;Password=***;";
}
```

### Persyaratan

- SQL Server harus berjalan di laptop server
- TCP/IP harus diaktifkan di SQL Server Configuration Manager
- Laptop client dan server dalam **satu jaringan WiFi yang sama**
- Crystal Reports Runtime harus terinstall di laptop client

### Installer

Installer dibuat menggunakan **Inno Setup Compiler** yang menghasilkan file `AMKHSetup.exe`.

<!-- Screenshot proses instalasi -->
<!-- Screenshot aplikasi berjalan setelah install -->
