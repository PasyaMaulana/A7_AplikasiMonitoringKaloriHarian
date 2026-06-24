using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMKH
{
    public class DAL
    {
        // ── CONNECTION ────────────────────────────────────

        public static string GetLocalIPAddress()
        {
            string localIP = string.Empty;
            try
            {
                var host = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        localIP = ip.ToString();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting local IP address: " + ex.Message);
            }
            return localIP;
        }

        private static string BuildConnectionString()
        {
            string ip = GetLocalIPAddress();
            return $"Data Source={ip}\\PASYA;Initial Catalog=AMKH_DB;User ID=sa;Password=040707;";
        }

        private string connectionString = BuildConnectionString();

        public string GetConnectionString()
        {
            return connectionString;
        }

        // ── KONSUMSI ──────────────────────────────────────

        public DataTable GetKonsumsi()
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var cmd = new SqlCommand("SELECT * FROM vw_KonsumsiAktif", c);
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public int CountKonsumsi()
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var cmd = new SqlCommand("sp_CountKonsumsi", c)
                { CommandType = CommandType.StoredProcedure };
                var p = cmd.Parameters.Add("@total", SqlDbType.Int);
                p.Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                return (int)p.Value;
            }
        }

        public void TambahKonsumsi(string namaItem, decimal kalori,
            string tipe, DateTime tanggal)
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var cmd = new SqlCommand("sp_TambahKonsumsi", c)
                { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@nama_item", namaItem);
                cmd.Parameters.AddWithValue("@kalori", kalori);
                cmd.Parameters.AddWithValue("@tipe", tipe);
                cmd.Parameters.AddWithValue("@tanggal", tanggal);
                cmd.ExecuteNonQuery();
            }
        }

        public string UpdateKonsumsi(int idKonsumsi, string namaItem,
            decimal kalori, string tipe, DateTime tanggal)
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var cmd = new SqlCommand("sp_UpdateKonsumsi", c)
                { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@id_konsumsi", idKonsumsi);
                cmd.Parameters.AddWithValue("@nama_item", namaItem);
                cmd.Parameters.AddWithValue("@kalori", kalori);
                cmd.Parameters.AddWithValue("@tipe", tipe);
                cmd.Parameters.AddWithValue("@tanggal", tanggal);
                var pPesan = cmd.Parameters.Add("@pesan", SqlDbType.VarChar, 200);
                pPesan.Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                return pPesan.Value.ToString();
            }
        }

        public bool HapusKonsumsi(int idKonsumsi)
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var cmd = new SqlCommand("sp_HapusKonsumsi", c)
                { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@id_konsumsi", idKonsumsi);
                var p = cmd.Parameters.Add("@target_juga_dihapus", SqlDbType.Bit);
                p.Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                return (bool)p.Value;
            }
        }

        public void SetTarget(DateTime tanggal, decimal targetKalori,
            out bool isUpdate)
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var cmd = new SqlCommand("sp_SetTarget", c)
                { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@tanggal", tanggal);
                cmd.Parameters.AddWithValue("@target_kalori", targetKalori);
                var p = cmd.Parameters.Add("@is_update", SqlDbType.Bit);
                p.Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                isUpdate = (bool)p.Value;
            }
        }

        public string ImportKonsumsi(string namaItem, decimal kalori,
            string tipe, DateTime tanggal)
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var cmd = new SqlCommand("sp_ImportKonsumsi", c)
                { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@nama_item", namaItem);
                cmd.Parameters.AddWithValue("@kalori", kalori);
                cmd.Parameters.AddWithValue("@tipe", tipe);
                cmd.Parameters.AddWithValue("@tanggal", tanggal.Date);
                var pStatus = cmd.Parameters.Add("@status", SqlDbType.VarChar, 20);
                pStatus.Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                return pStatus.Value?.ToString() ?? "SKIPPED";
            }
        }

        // ── AKTIVITAS ─────────────────────────────────────

        public DataTable GetAktivitas()
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var cmd = new SqlCommand("SELECT * FROM vw_AktivitasAktif", c);
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public int CountAktivitas()
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var cmd = new SqlCommand("sp_CountAktivitas", c)
                { CommandType = CommandType.StoredProcedure };
                var p = cmd.Parameters.Add("@total", SqlDbType.Int);
                p.Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                return (int)p.Value;
            }
        }

        public void TambahAktivitas(string namaAktivitas,
            decimal kaloriTerbakar, DateTime tanggal)
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var cmd = new SqlCommand("sp_TambahAktivitas", c)
                { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@nama_aktivitas", namaAktivitas);
                cmd.Parameters.AddWithValue("@kalori_terbakar", kaloriTerbakar);
                cmd.Parameters.AddWithValue("@tanggal", tanggal);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateAktivitas(int idAktivitas, string namaAktivitas,
            decimal kaloriTerbakar, DateTime tanggal)
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var cmd = new SqlCommand("sp_UpdateAktivitas", c)
                { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@id_aktivitas", idAktivitas);
                cmd.Parameters.AddWithValue("@nama_aktivitas", namaAktivitas);
                cmd.Parameters.AddWithValue("@kalori_terbakar", kaloriTerbakar);
                cmd.Parameters.AddWithValue("@tanggal", tanggal);
                cmd.ExecuteNonQuery();
            }
        }

        public void HapusAktivitas(int idAktivitas)
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var cmd = new SqlCommand("sp_HapusAktivitas", c)
                { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@id_aktivitas", idAktivitas);
                cmd.ExecuteNonQuery();
            }
        }

        public string ImportAktivitas(string namaAktivitas,
            decimal kaloriTerbakar, DateTime tanggal)
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var cmd = new SqlCommand("sp_ImportAktivitas", c)
                { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@nama_aktivitas", namaAktivitas);
                cmd.Parameters.AddWithValue("@kalori_terbakar", kaloriTerbakar);
                cmd.Parameters.AddWithValue("@tanggal", tanggal.Date);
                var pStatus = cmd.Parameters.Add("@status", SqlDbType.VarChar, 20);
                pStatus.Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                return pStatus.Value?.ToString() ?? "SKIPPED";
            }
        }

        // ── RIWAYAT ───────────────────────────────────────

        public DataTable GetRiwayatKonsumsi(DateTime tanggal)
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var cmd = new SqlCommand(
                    "SELECT * FROM vw_RiwayatKonsumsi WHERE tanggal = @tgl ORDER BY id_konsumsi", c);
                cmd.Parameters.AddWithValue("@tgl", tanggal);
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetRiwayatAktivitas(DateTime tanggal)
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var cmd = new SqlCommand(
                    "SELECT * FROM vw_RiwayatAktivitas WHERE tanggal = @tgl ORDER BY id_aktivitas", c);
                cmd.Parameters.AddWithValue("@tgl", tanggal);
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetRingkasanRiwayat(DateTime tanggal)
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var cmd = new SqlCommand(
                    "SELECT * FROM vw_RingkasanRiwayat WHERE tanggal = @tgl", c);
                cmd.Parameters.AddWithValue("@tgl", tanggal);
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ── INFO KALORI ───────────────────────────────────

        public decimal GetTotalKaloriHariIni(DateTime tanggal)
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var cmd = new SqlCommand(
                    "SELECT ISNULL(SUM(kalori),0) FROM Konsumsi WHERE tanggal=@tgl", c);
                cmd.Parameters.AddWithValue("@tgl", tanggal);
                return (decimal)cmd.ExecuteScalar();
            }
        }

        public decimal GetTargetKalori(DateTime tanggal)
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var cmd = new SqlCommand(
                    "SELECT ISNULL(target_kalori,0) FROM Target WHERE tanggal=@tgl", c);
                cmd.Parameters.AddWithValue("@tgl", tanggal);
                object result = cmd.ExecuteScalar();
                return (result != null && result != DBNull.Value)
                    ? (decimal)result : 0;
            }
        }

        public decimal GetTotalKaloriTerbakar(DateTime tanggal)
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var cmd = new SqlCommand(
                    "SELECT ISNULL(SUM(kalori_terbakar),0) FROM Aktivitas WHERE tanggal=@tgl", c);
                cmd.Parameters.AddWithValue("@tgl", tanggal);
                return (decimal)cmd.ExecuteScalar();
            }
        }

        // ── REPORT ────────────────────────────────────────

        public DataTable GetDataReport(DateTime tanggal)
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var cmd = new SqlCommand("sp_ReportKonsumsi", c)
                { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@tanggal", tanggal.Date);
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetDataReportAktivitas(DateTime tanggal)
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var cmd = new SqlCommand("sp_ReportAktivitas", c)
                { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@tanggal", tanggal.Date);
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetDataReportRingkasan(DateTime tanggal)
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var cmd = new SqlCommand("sp_ReportRingkasan", c)
                { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@tanggal", tanggal.Date);
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ── DASHBOARD / CHART ─────────────────────────────

        public DataTable GetChartKaloriMingguan()
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var cmd = new SqlCommand("sp_ChartKaloriMingguan", c)
                { CommandType = CommandType.StoredProcedure };
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}