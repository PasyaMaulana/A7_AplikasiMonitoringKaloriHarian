# Aplikasi Monitoring Kalori Harian — UCP 2

## Daftar Isi
- [Tampilan Aplikasi](#tampilan-aplikasi)
- [Stored Procedure](#stored-procedure)
- [View](#view)
- [SQL Injection Demo](#sql-injection-demo)
- [DataGridView Binding & Binding Navigator](#datagridview-binding--binding-navigator)

---

## Tampilan Aplikasi

### Form Utama
<!-- Screenshot form utama / navbar -->
<img width="1040" height="145" alt="image" src="https://github.com/user-attachments/assets/3c90a91e-5e28-434a-89d3-7914e740cd0e" />


### Form Konsumsi
<!-- Screenshot form input konsumsi -->
<img width="1045" height="1031" alt="image" src="https://github.com/user-attachments/assets/27cb83f8-c82c-451b-b9e0-8314b3fed02e" />


### Form Aktivitas
<!-- Screenshot form input aktivitas -->
<img width="1044" height="1033" alt="image" src="https://github.com/user-attachments/assets/2a07337e-8349-4c8a-8969-e2b8fcba1c21" />


### Form Riwayat
<!-- Screenshot form riwayat -->
<img width="1050" height="1031" alt="image" src="https://github.com/user-attachments/assets/4b90bd94-fa41-4e7e-a68b-205af98182f7" />


---

## Stored Procedure

Seluruh operasi manipulasi data dilakukan melalui Stored Procedure yang dibuat di SQL Server, bukan query langsung dari aplikasi.

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

### Bukti Stored Procedure di SQL Server
<!-- Screenshot daftar SP di SSMS (Object Explorer) -->
<img width="438" height="345" alt="image" src="https://github.com/user-attachments/assets/1f1a9460-84d2-4621-9b87-846a87e31309" />


### Bukti Implementasi di Windows Form

#### Tambah Konsumsi (memanggil sp_TambahKonsumsi)
<!-- Screenshot sebelum tambah -->
<img width="1048" height="1031" alt="image" src="https://github.com/user-attachments/assets/bc66eca0-6f62-4d5f-80e6-948f0602921f" />


<!-- Screenshot sesudah tambah / pesan sukses -->
<img width="1044" height="1033" alt="image" src="https://github.com/user-attachments/assets/c7658cfb-bf8a-422e-b97a-6725bd6b500c" />


#### Update Konsumsi (memanggil sp_UpdateKonsumsi)
<!-- Screenshot sebelum update -->
<img width="1047" height="1032" alt="image" src="https://github.com/user-attachments/assets/f9ab2261-f1d4-4f3a-86e5-a3f39f78a114" />


<!-- Screenshot sesudah update -->
<img width="1053" height="1031" alt="image" src="https://github.com/user-attachments/assets/cd1ac983-dfb5-4276-8212-b167cfde3a9f" />


#### Hapus Konsumsi (memanggil sp_HapusKonsumsi)
<!-- Screenshot sebelum hapus -->
<img width="1047" height="1032" alt="image" src="https://github.com/user-attachments/assets/f9ab2261-f1d4-4f3a-86e5-a3f39f78a114" />

<!-- Screenshot sesudah hapus -->
<img width="1047" height="1031" alt="image" src="https://github.com/user-attachments/assets/f71dd973-5642-45d9-943c-dad4b7a3136c" />


#### Tambah Aktivitas (memanggil sp_TambahAktivitas)
<!-- Screenshot -->
<img width="1050" height="1033" alt="image" src="https://github.com/user-attachments/assets/bc183b0f-c1fc-439a-a89f-c7bf1b581d6c" />


#### Update Aktivitas (memanggil sp_UpdateAktivitas)
<!-- Screenshot -->
<img width="1048" height="1029" alt="image" src="https://github.com/user-attachments/assets/c6f87565-76af-474c-a649-1dd71d2bd2a1" />


#### Hapus Aktivitas (memanggil sp_HapusAktivitas)
<!-- Screenshot -->
<img width="1049" height="1032" alt="image" src="https://github.com/user-attachments/assets/0c7241e8-d15c-4a57-a255-2bcd499ebc3c" />


#### Output Parameter — Count Record
<!-- Screenshot label "Total: X record aktif" -->
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
<!-- Screenshot daftar View di SSMS (Object Explorer) -->
<img width="434" height="198" alt="image" src="https://github.com/user-attachments/assets/a9968195-b706-4a03-8f22-1cf0b40d0a62" />


### Bukti Implementasi di Windows Form

#### vw_KonsumsiAktif — Form Konsumsi
<!-- Screenshot DataGridView Form Konsumsi -->
<img width="1041" height="177" alt="image" src="https://github.com/user-attachments/assets/66a6af19-02e7-45dc-8481-9bb478dfc00f" />


#### vw_AktivitasAktif — Form Aktivitas
<!-- Screenshot DataGridView Form Aktivitas -->
<img width="1041" height="75" alt="image" src="https://github.com/user-attachments/assets/85a34819-156a-4451-849b-c74813a2cf19" />


#### vw_RiwayatKonsumsi & vw_RiwayatAktivitas — Form Riwayat
<!-- Screenshot DataGridView Form Riwayat -->
<img width="1044" height="430" alt="image" src="https://github.com/user-attachments/assets/835565b8-fd29-4022-b09a-8be451576f39" />

#### vw_RingkasanRiwayat — Ringkasan Form Riwayat
<!-- Screenshot panel ringkasan: kalori masuk, terbakar, bersih, status -->
<img width="1043" height="102" alt="image" src="https://github.com/user-attachments/assets/26c8cf8d-a366-414f-8372-665f27d4aafa" />

---

## SQL Injection Demo

### Skenario Demo

Demo dilakukan di **Form Konsumsi** pada panel **⚠ Demo SQL Injection**.

**Langkah-langkah:**

**1. Backup Data**

Klik tombol `1. Backup` untuk menyalin data Konsumsi ke tabel `Konsumsi_Backup` sebelum demo dimulai.

<!-- Screenshot setelah klik Backup -->
<img width="1120" height="1032" alt="image" src="https://github.com/user-attachments/assets/736d4437-13d1-48a9-bcff-7dacf21d0f8f" />


---

**2. Simulasi SQL Injection (Query Tidak Aman)**

Ketik payload berikut di kolom **Nama Item**:

```
' OR '1'='1
```

Lalu klik tombol `2. Test Inject`.

Query yang dieksekusi di balik layar:

```sql
UPDATE Konsumsi SET nama_item = 'HACKED'
WHERE nama_item = '' OR '1'='1'
```

Karena `'1'='1'` selalu bernilai benar, **seluruh baris** di tabel Konsumsi terupdate menjadi `HACKED`, bukan hanya baris yang dipilih.

<!-- Screenshot pesan hasil injection: "Baris terupdate: X" -->
<img width="1169" height="1030" alt="image" src="https://github.com/user-attachments/assets/30451f01-a504-4233-af32-77ec8a2da99f" />


<!-- Screenshot DataGridView setelah injection (semua nama jadi HACKED) -->
<img width="1051" height="1031" alt="image" src="https://github.com/user-attachments/assets/7b6c831f-b234-459f-bffb-f275bd2a46a6" />


---

**3. Query Aman (Parameterized Query)**

Dengan input payload yang sama `' OR '1'='1`, klik tombol `3. Query Aman`.

Query yang dieksekusi:

```sql
UPDATE Konsumsi SET nama_item = 'AMAN' WHERE nama_item = @nama
```

Input diperlakukan sebagai **literal string**, bukan perintah SQL, sehingga tidak ada baris yang terupdate.

<!-- Screenshot pesan hasil query aman: "Baris terupdate: 0" -->
<img width="1052" height="1031" alt="image" src="https://github.com/user-attachments/assets/b2acbbf5-fba1-4389-8b9c-bd443d10008c" />


---

**4. Reset Data**

Klik tombol `4. Reset Data` untuk mengembalikan semua data ke kondisi backup awal.

<!-- Screenshot setelah reset, data kembali normal -->
<img width="1048" height="1030" alt="image" src="https://github.com/user-attachments/assets/ba836177-c7b6-4021-99a4-502b7a47b052" />


---

## DataGridView Binding & Binding Navigator

### DataGridView Binding

DataGridView pada setiap form menggunakan konsep **Binding** melalui `BindingSource` yang terhubung ke `DataSet` dan `TableAdapter`.

<!-- Screenshot properties DataGridView di designer menunjukkan DataSource -->
<img width="249" height="252" alt="image" src="https://github.com/user-attachments/assets/9d2cb834-168b-4ab8-a5e4-5dd367bc48d0" />


### Binding Navigator

Setiap form dilengkapi **Binding Navigator** untuk navigasi antar record (first, previous, next, last).

<!-- Screenshot Binding Navigator di Form Konsumsi -->
<img width="1045" height="1032" alt="image" src="https://github.com/user-attachments/assets/ff1d6806-6918-49cb-aff3-8a7566d082d5" />

<!-- Screenshot Binding Navigator di Form Aktivitas -->
<img width="1048" height="1032" alt="image" src="https://github.com/user-attachments/assets/39985c65-eb80-4a29-af09-495f08621fa8" />

<img width="1049" height="1032" alt="image" src="https://github.com/user-attachments/assets/2ced4944-0193-4f61-a4a8-18508fbb68a4" />
