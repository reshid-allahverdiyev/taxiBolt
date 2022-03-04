using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taxiBolt
{
    public partial class frmAdminPanel : Form
    {
        public frmAdminPanel()
        {
            InitializeComponent();
        }

        SqlConnect sqlconnect = new SqlConnect();
        GridViewDesignClass g = new GridViewDesignClass();
        public static List<double> report = new List<double>();
        bool dtOrderCheck = false;
        string selectedRows = "";
        private void FrmAdminPanel_Load(object sender, EventArgs e)
        {
            refreshOrder();
            lblCurrentUserName.Text = frmLogin.user_name;   
            chckDate.Checked = false;
            dtOrderDate1.Enabled = false;
            chckDate.Text = "Tarix(aralıq üzrə)";
            lblOrderdate.Text = "Tarix"; 
        }

        private void FrmAdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void TabControl1_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "tbpgCar": refreshCar(); break;
                case "tbpgDriver": refreshDriver(); break;
                case "tbpgAdmin": refreshAdmin(); break;
                case "tbpgOrder": refreshOrder(); break;
            }
        }
        private void Label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }


        #region regionCar
        public static bool carCreateOrModify = false;
        public static int idCar = -1;
        public  void refreshCar()
        {
            try
            {
                grdvwCar.Columns.Clear();
                string query = "Select * from tblCar";
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(query, sqlconnect.connect());

                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                if (dt.Rows.Count != 0)
                {
                    grdvwCar.DataSource = dt;
                    g.GridViewDesign(dt.Rows.Count, grdvwCar);

                }
                else
                {
                    MessageBox.Show("Maşın tapılmadı!");
                }

                sqlconnect.close();
                idCar = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
            }
        }
        private void cleanCar()
        {
            txtBrand.Text = "";
            txtModel.Text = "";
            txtCarColor.Text = "";
            txtYear.Text = "";
            txtNumber.Text = ""; 
        }
        private void BtnCarRefresh_Click(object sender, EventArgs e)
        {
            refreshCar();
            cleanCar();
        }
        private void BtnCarSearch_Click(object sender, EventArgs e)
        {
            string query = "";

            if (txtBrand.Text != "")
            {
                query += " carBrand=N'" + txtBrand.Text + "'";
            }

            if (txtModel.Text != "")
            {
                if (query != "")
                {
                    query += " and carModel=N'" + txtModel.Text + "'";
                }
                else
                {
                    query += " carModel=N'" + txtModel.Text + "'";
                }
            }


            if (txtNumber.Text != "")
            {
                if (query != "")
                {
                    query += " and carNumber=N'" + txtNumber.Text + "'";
                }
                else
                {
                    query += " carNumber=N'" + txtNumber.Text + "'";
                }
            } 

            if (txtYear.Text != "")
            {
                if (query != "")
                {
                    query += " and carYear=N'" + txtYear.Text + "'";
                }
                else
                {
                    query += " carYear=N'" + txtYear.Text + "'";
                }
            }

            if (txtCarColor.Text != "")
            {
                if (query != "")
                {
                    query += " and carColor=N'" + txtCarColor.Text + "'";
                }
                else
                {
                    query += " carColor=N'" + txtCarColor.Text + "'";
                }
            }


            string fullquery = "Select * from tblCar where " + query;
            if (query != "")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand(fullquery, sqlconnect.connect());
                    SqlDataReader rd = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rd);
                    if (dt.Rows.Count != 0)
                    {
                        grdvwCar.Columns.Clear();
                        grdvwCar.DataSource = dt;
                        g.GridViewDesign(dt.Rows.Count, grdvwCar);
                    }
                    else
                    {
                        MessageBox.Show("Uyğun maşın tapılmadı!");
                    }
                    sqlconnect.close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
                }
            }
            else
            {
                MessageBox.Show("Axtarış üçün ən azı bir sahə doldurulmalıdır!");
            }
            idCar = -1;
        }  
        private void BtnCarAdd_Click(object sender, EventArgs e)
        {
            carCreateOrModify = false;
            frmCarAdd frmCarAdd = new frmCarAdd();
            frmCarAdd.Text = "Yeni maşın";
            frmCarAdd.ShowDialog();
        } 
        private void BtnCarEdit_Click(object sender, EventArgs e)
        {
            if (idCar != -1)
            {
                carCreateOrModify = true;
                frmCarAdd frmCarAdd = new frmCarAdd();
                frmCarAdd.Text = "Düzəliş";
                frmCarAdd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Məlumat seçilməyib!");
            }
        }
        private void BtnCarDelete_Click(object sender, EventArgs e)
        {
            if (idCar != -1)
            {
                string s = MessageBox.Show("Silmək istədiyinizdən əminsiniz?", "Diqqət", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (s == "Yes")
                {
                    string query = "Delete from tblCar Where carID=" + idCar;
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand(query, sqlconnect.connect());
                        cmd.ExecuteNonQuery();
                        sqlconnect.close();
                        MessageBox.Show("Silinmə uğurla tamamlandı");
                        refreshCar();
                        cleanCar();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
                    }
                }
            }
            else
            {
                MessageBox.Show("Məlumat seçilməyib!");
            }
            idCar = -1;

        }
        private void GrdvwCar_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cleanCar();
            int index = e.RowIndex;
            DataGridViewRow row = grdvwCar.Rows[index];
            idCar = Int32.Parse(row.Cells[0].Value.ToString());
            txtBrand.Text = row.Cells[2].Value.ToString();            
            txtModel.Text = row.Cells[3].Value.ToString();
            txtNumber.Text = row.Cells[4].Value.ToString();
            txtYear.Text = row.Cells[5].Value.ToString();
            txtCarColor.Text = row.Cells[6].Value.ToString();  
        }
        private void GrdvwCar_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < grdvwCar.Rows.Count; i++)
            {
                grdvwCar.Rows[i].Cells[1].Value = (i + 1).ToString();
            }
        }


        #endregion


        #region regionDriver
        public static bool driverCreateOrModify = false;
        public static int idDriver = -1;
        public void refreshDriver()
        {
            try
            {
                grdvwDriver.Columns.Clear();
                string query = "Select * from tblDriver";
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(query, sqlconnect.connect());

                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                if (dt.Rows.Count != 0)
                {
                    grdvwDriver.DataSource = dt;
                    g.GridViewDesign(dt.Rows.Count, grdvwDriver);

                }
                else
                {
                    MessageBox.Show("Sürücü tapılmadı!");
                }

                sqlconnect.close();
                idDriver = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
            }
        }
        private void cleanDriver()
        {
            txtDriverName.Text = "";
            txtDriverSurname.Text = "";
            txtDriverFatherName.Text = "";
            txtDriverFin.Text = "";
            dtDriverBirtday.Text = "";
        }
        private void BtnDriverRefresh_Click(object sender, EventArgs e)
        {
            refreshDriver();
            cleanDriver();
        }
        private void BtnDriverSearch_Click(object sender, EventArgs e)
        {
            string query = "";

            if (txtDriverName.Text != "")
            {
                query += " name=N'" + txtDriverName.Text + "'";
            }

            if (txtDriverSurname.Text != "")
            {
                if (query != "")
                {
                    query += " and surname=N'" + txtDriverSurname.Text + "'";
                }
                else
                {
                    query += " surname=N'" + txtDriverSurname.Text + "'";
                }
            }


            if (txtDriverFatherName.Text != "")
            {
                if (query != "")
                {
                    query += " and fathername=N'" + txtDriverFatherName.Text + "'";
                }
                else
                {
                    query += " fathername=N'" + txtDriverFatherName.Text + "'";
                }
            }

            if (txtDriverFin.Text != "")
            {
                if (query != "")
                {
                    query += " and fin=N'" + txtDriverFin.Text + "'";
                }
                else
                {
                    query += " fin=N'" + txtDriverFin.Text + "'";
                }
            }

           

            string fullquery = "Select * from tblDriver where " + query;
            if (query != "")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand(fullquery, sqlconnect.connect());
                    SqlDataReader rd = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rd);
                    if (dt.Rows.Count != 0)
                    {
                        grdvwDriver.Columns.Clear();
                        grdvwDriver.DataSource = dt;
                        g.GridViewDesign(dt.Rows.Count, grdvwDriver);
                    }
                    else
                    {
                        MessageBox.Show("Uyğun sürücü  tapılmadı!");
                    }
                    sqlconnect.close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
                }
            }
            else
            {
                MessageBox.Show("Axtarış üçün ən azı bir sahə doldurulmalıdır!");
            }
            idDriver=-1;
        }
        private void BtnDriverAdd_Click(object sender, EventArgs e)
        {
            driverCreateOrModify = false;
            frmDriverAdd frmDriverAdd = new frmDriverAdd();
            frmDriverAdd.Text = "Yeni Sürücü";
            frmDriverAdd.ShowDialog();
        }  
        private void BtnDriverModify_Click(object sender, EventArgs e)
        {
            if (idDriver != -1)
            {
                driverCreateOrModify = true;
                frmDriverAdd frmDriverAdd = new frmDriverAdd();
                frmDriverAdd.Text = "Düzəliş";
                frmDriverAdd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Məlumat seçilməyib!");
            }
        }
        private void BtnDriverDelete_Click(object sender, EventArgs e)
        {
            if (idDriver != -1)
            {
                string s = MessageBox.Show("Silmək istədiyinizdən əminsiniz?", "Diqqət", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (s == "Yes")
                {
                    string query = "Delete from tblDriver Where driverID=" + idDriver;
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand(query, sqlconnect.connect());
                        cmd.ExecuteNonQuery();
                        sqlconnect.close();
                        MessageBox.Show("Silinmə uğurla tamamlandı");
                        refreshDriver();
                        cleanDriver();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
                    }
                }
            }
            else
            {
                MessageBox.Show("Məlumat seçilməyib!");
            }
            idDriver = -1;
        }

 
        private void GrdvwDriver_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < grdvwDriver.Rows.Count; i++)
            {
                grdvwDriver.Rows[i].Cells[1].Value = (i + 1).ToString();
            }
        }

        private void GrdvwDriver_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cleanDriver();
            int index = e.RowIndex;
            DataGridViewRow row = grdvwDriver.Rows[index];
            idDriver = Int32.Parse(row.Cells[0].Value.ToString());
            txtDriverName.Text = row.Cells[2].Value.ToString();
            txtDriverSurname.Text = row.Cells[3].Value.ToString();
            txtDriverFatherName.Text = row.Cells[4].Value.ToString();
            txtDriverFin.Text = row.Cells[5].Value.ToString();
            dtDriverBirtday.Value= Convert.ToDateTime(row.Cells[6].Value);
        }


        #endregion


        #region regionAdmin
        public static bool adminCreateOrModify = false;
        public static int idAdmin= -1;
        public void refreshAdmin()
        {
            try
            {
                grdvwAdmin.Columns.Clear();
                string query = "Select * from tblAdmin";
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(query, sqlconnect.connect());

                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                if (dt.Rows.Count != 0)
                {
                    grdvwAdmin.DataSource = dt;
                    g.GridViewDesign(dt.Rows.Count, grdvwAdmin);

                }
                else
                {
                    MessageBox.Show("İstifadəçi tapılmadı!");
                }

                sqlconnect.close();
                idAdmin = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
            }
        }
        private void cleanAdmin() 
        {
            txtAdminName.Text = "";
            txtAdminSurname.Text = "";
            txtAdminFatherName.Text = "";
            txtAdminFin.Text = "";
            txtAdminUsername.Text = "";
            txtAdminPassword.Text = "";
            dtAdminBirtday.Text = "";

        }
        private void BtnAdminRefresh_Click(object sender, EventArgs e)
        {
            refreshAdmin();
            cleanAdmin();       
        }
        private void BtnAdminSearch_Click(object sender, EventArgs e)
        {
            string query = "";

            if (txtAdminName.Text != "")
            {
                query += " name=N'" + txtAdminName.Text + "'";
            }

            if (txtAdminSurname.Text != "")
            {
                if (query != "")
                {
                    query += " and surname=N'" + txtAdminSurname.Text + "'";
                }
                else
                {
                    query += " surname=N'" + txtAdminSurname.Text + "'";
                }
            }


            if (txtAdminFatherName.Text != "")
            {
                if (query != "")
                {
                    query += " and fathername=N'" + txtAdminFatherName.Text + "'";
                }
                else
                {
                    query += " fathername=N'" + txtAdminFatherName.Text + "'";
                }
            }

            if (txtAdminFin.Text != "")
            {
                if (query != "")
                {
                    query += " and fin=N'" + txtAdminFin.Text + "'";
                }
                else
                {
                    query += " fin=N'" + txtAdminFin.Text + "'";
                }
            }

            if (txtAdminUsername.Text != "")
            {
                if (query != "")
                {
                    query += " and username=N'" + txtAdminUsername.Text + "'";
                }
                else
                {
                    query += " username=N'" + txtAdminUsername.Text + "'";
                }
            }

            if (txtAdminPassword.Text != "")
            {
                if (query != "")
                {
                    query += " and password=N'" + txtAdminPassword.Text + "'";
                }
                else
                {
                    query += " password=N'" + txtAdminPassword.Text + "'";
                }
            }

             

            string fullquery = "Select * from tblAdmin where " + query;
            if (query != "")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand(fullquery, sqlconnect.connect());
                    SqlDataReader rd = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rd);
                    if (dt.Rows.Count != 0)
                    {
                        grdvwAdmin.Columns.Clear();
                        grdvwAdmin.DataSource = dt;
                        g.GridViewDesign(dt.Rows.Count, grdvwAdmin);
                    }
                    else
                    {
                        MessageBox.Show("Uyğun istifadəçi  tapılmadı!");
                    }
                    sqlconnect.close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
                }
            }
            else
            {
                MessageBox.Show("Axtarış üçün ən azı bir sahə doldurulmalıdır!");
            }
            idAdmin = -1;
        }
        private void BtnAdminAdd_Click(object sender, EventArgs e)
        {
            adminCreateOrModify = false;
            frmAdminAdd frmAdminAdd = new frmAdminAdd();
            frmAdminAdd.Text = "Yeni İstifadəçi";
            frmAdminAdd.ShowDialog();
        }
        private void BtnAdminModify_Click(object sender, EventArgs e)
        {
            if (idAdmin!= -1)
            {
                adminCreateOrModify = true;
                frmAdminAdd frmAdminAdd = new frmAdminAdd();
                frmAdminAdd.Text = "Düzəliş";
                frmAdminAdd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Məlumat seçilməyib!");
            }
        } 
        private void BtnAdminDelete_Click(object sender, EventArgs e)
        {
            if (idAdmin != -1)
            {
                string s = MessageBox.Show("Silmək istədiyinizdən əminsiniz?", "Diqqət", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (s == "Yes")
                {
                    string query = "Delete from tblAdmin Where adminID=" + idAdmin;
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand(query, sqlconnect.connect());
                        cmd.ExecuteNonQuery();
                        sqlconnect.close();
                        MessageBox.Show("Silinmə uğurla tamamlandı");
                        refreshAdmin();
                        cleanAdmin();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
                    }
                }
            }
            else
            {
                MessageBox.Show("Məlumat seçilməyib!");
            }
            idDriver = -1;
        }
        private void GrdvwAdmin_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cleanAdmin();
            int index = e.RowIndex;
            DataGridViewRow row = grdvwAdmin.Rows[index];
            idAdmin = Int32.Parse(row.Cells[0].Value.ToString());
            txtAdminName.Text = row.Cells[2].Value.ToString();
            txtAdminSurname.Text = row.Cells[3].Value.ToString();
            txtAdminFatherName.Text = row.Cells[4].Value.ToString();
            txtAdminFin.Text = row.Cells[5].Value.ToString();
            dtAdminBirtday.Value = Convert.ToDateTime(row.Cells[6].Value); 
            txtAdminUsername.Text = row.Cells[7].Value.ToString();
            txtAdminPassword.Text = row.Cells[8].Value.ToString();
        }
        private void GrdvwAdmin_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < grdvwAdmin.Rows.Count; i++)
            {
                grdvwAdmin.Rows[i].Cells[1].Value = (i + 1).ToString();
            }
        }

        #endregion



        #region regionOrder

        public static bool orderCreateOrModify = false;
        public static int idOrder= -1;
        public static bool cmbPayedCheck = false;
        public void refreshOrder()
        {
            cmbDriverFill();
            cmbCarFill();
            cmbQueue();
            cmbPayedFill();
            dtOrderDate.Value = DateTime.Now;
            dtOrderDate1.Value = DateTime.Now;
            txtCommonCostNote.Text = "";
            txtSpecialCostNote.Text = "";
            dtOrderCheck = false;
            selectedRows = "";
            cmbPayedCheck = false;
            chckBegin.Checked = true;
            chckBegin.Enabled = false;
            chckEnd.Checked = true;
            chckEnd.Enabled = false;
            chckDate.Checked = false;
            try
            {
                btnOrderModify.Columns.Clear();
                string query = @"SELECT o.orderID 
                              ,o.date   tarix 
                              ,o.queue növbə
                              ,o.commonAmount ümumi_məbləğ
                              ,o.payedByCard  kartla_ödənən
                              ,o.payedByCash  nəğd_ödənən
                              ,o.payedToBalance  balansa_ödənən
                              ,o.boltCompensation  Bolt_kompensasiya
                              ,o.drivingDistance   sürülən_məsafə
                              ,o.lastDistance    maşının_yürüşü
                              ,o.fuelMoney       yanacaq_pulu
                              ,o.driverMoney     sürücü_pulu
                              ,o.avance        avans
                              ,o.forDriver     sürücüyə_verilməlidir
                              ,o.payedToCard  karta_vurulan_pul
                              ,o.lastAmount         'son_məbləğ(Nəzarətçidə qalan)'
                              ,o.commonCost    ümumi_xərc
                              ,o.commonCostNote  ümumi_xərclə_bağlı_qeyd
                              ,o.specialCost      xüsusi_xərc
                              ,o.specialCostNote    xüsusi_xərclə_vağlı_qeyd                              
                              ,o.lastAmountForEmploye   'işçinin_pulu(nəzarətçinin pulu)'
                              ,o.profit   qazanc
	                          ,c.carBrand+' '+c.carModel+' ('+c.carNumber+')'  Maşın
	                          ,d.name+ ' '+d.surname +' '+ d.fathername   Sürücü
                              ,case  when  o.payed=1 
                               then  N'Ödənilib'  
                               else N'Ödənilməyib'
                               end Ödənilmə
                          FROM tblOrder o 
                          left join  tblCar c on o.carID=c.carID
                          left join  tblDriver  d on  o.driverID=d.driverID order  by o.date";
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(query, sqlconnect.connect());

                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                if (dt.Rows.Count != 0)
                {
                    btnOrderModify.DataSource = dt; 
                    g.GridViewDesign(dt.Rows.Count, btnOrderModify);
                    for (int i = 1; i < dt.Columns.Count; i++)
                    {
                        btnOrderModify.Columns[i].Width = 50;
                    }
                }   
                else
                {
                    MessageBox.Show("Sifariş tapılmadı!");
                }

                sqlconnect.close();
                idOrder = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
            }
        }
        private void cmbDriverFill()
        {
            try
            {                 
                string query = "Select -1 as driverID, N'Hamısı'  as  driver union all  select driverID, Name+  '  '+surname as  driver  from tblDriver";
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(query, sqlconnect.connect());
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                cmbDriver.DataSource = ds.Tables[0];
                cmbDriver.DisplayMember = "driver";
                cmbDriver.ValueMember = "driverID"; 
                cmbDriver.SelectedItem = null;
                cmbDriver.Text = "Sürücü seçin";
                sqlconnect.close();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin!");
            }
        }
        private void cmbCarFill()
        {
            try
            {
                string query = @"Select  -1 as carID, N'Hamısı'  as  car union all  select carID, carBrand+  '  '+carModel +'  ('+ carNumber +')'  as  car  from tblCar";
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(query, sqlconnect.connect());
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                cmbCar.DataSource = ds.Tables[0];
                cmbCar.DisplayMember = "car";
                cmbCar.ValueMember = "carID";
                cmbCar.SelectedItem = null;
                cmbCar.Text = "Maşın seçin";
                sqlconnect.close();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin!");
            }
        }
        private void cmbQueue()
        {
            cmbxQueue.Items.Clear();
            cmbxQueue.ResetText();
            cmbxQueue.Items.Add("Hamısı");
            cmbxQueue.Items.Add("Gündüz");
            cmbxQueue.Items.Add("Gecə");
            cmbxQueue.SelectedItem = null;
            cmbxQueue.SelectedText = "Növbə seçin";
        }
        private void cmbPayedFill()
        {
            cmbPayed.Items.Clear();
            cmbPayed.ResetText();
            cmbPayed.Items.Add("Hamısı");
            cmbPayed.Items.Add("Ödənilmişlər");
            cmbPayed.Items.Add("Ödənilməyənlər");
            cmbPayed.SelectedItem = null;
            cmbPayed.SelectedText = "Seçin";
        }
        private void BtnOrderRefresh_Click(object sender, EventArgs e)
        {
            refreshOrder();
        }
        private void BtnOrderDelete_Click(object sender, EventArgs e)
        {
            if (idOrder != -1)
            {
                string s = MessageBox.Show("Silmək istədiyinizdən əminsiniz?", "Diqqət", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (s == "Yes")
                {
                    string query = "Delete from tblOrder Where orderID=" + idOrder;
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand(query, sqlconnect.connect());
                        cmd.ExecuteNonQuery();
                        sqlconnect.close();
                        MessageBox.Show("Silinmə uğurla tamamlandı");
                        refreshOrder(); 
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
                    }
                }
            }
            else
            {
                MessageBox.Show("Məlumat seçilməyib!");
            }
            idOrder = -1;
        }
        private void GrdvwOrder_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        { 
            int index = e.RowIndex;
            DataGridViewRow row = btnOrderModify.Rows[index];
            idOrder = Int32.Parse(row.Cells[0].Value.ToString()); 
        } 
        private void GrdvwOrder_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < btnOrderModify.Rows.Count; i++)
            {
                btnOrderModify.Rows[i].Cells[1].Value = (i + 1).ToString();
            }
        } 
        private void BtnOrderAdd_Click(object sender, EventArgs e)
        { 
            orderCreateOrModify = false;
            frmOrderAdd frmOrderAdd = new frmOrderAdd();
            frmOrderAdd.Text = "Yeni Sifariş";
            frmOrderAdd.ShowDialog();
            
        }
        private void ChckDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chckDate.Checked)
            {
                dtOrderDate1.Enabled = true;
                chckDate.Text = "Son tarix(aralıq üzrə)";
                lblOrderdate.Text = "Başlanğıc tarix"; 
                chckBegin.Enabled = true; 
                chckEnd.Enabled = true;

            }
            else
            {
                dtOrderDate1.Enabled = false;
                chckDate.Text = "Tarix(aralıq üzrə)";
                lblOrderdate.Text = "Tarix";
                chckBegin.Checked = true;
                chckBegin.Enabled = false;
                chckEnd.Checked = true;
                chckEnd.Enabled = false;
                cmbxQueue.Items.Clear();
                cmbxQueue.ResetText();
                cmbxQueue.Items.Add("Hamısı");
                cmbxQueue.Items.Add("Gündüz");
                cmbxQueue.Items.Add("Gecə");
                cmbxQueue.SelectedItem = null;
                cmbxQueue.SelectedText = "Növbə seçin";
                cmbxQueue.Enabled = true;
            }
        }
        private void DtOrderDate_ValueChanged(object sender, EventArgs e)
        {
            dtOrderCheck = true;
        }
        private void DtOrderDate1_ValueChanged(object sender, EventArgs e)
        {
            dtOrderCheck = true;
        }
        private void BtnOrderSearch_Click(object sender, EventArgs e)
        {
            string query = "";
            bool t = false;
            if (cmbxQueue.SelectedItem != null)
            {
                if (cmbxQueue.SelectedItem.ToString() != "Hamısı")
                {
                    query += " o.queue=N'" + cmbxQueue.SelectedItem.ToString() + "'";
                }
                else
                {
                    t = true;
                }
            }
            if (cmbDriver.SelectedItem != null)
            {
                if (cmbDriver.SelectedValue.ToString() !="-1")
                {
                    if (query != "")
                    {
                        query += " and d.driverID=" + cmbDriver.SelectedValue.ToString() + "";
                    }
                    else
                    {
                        query += " d.driverID=" + cmbDriver.SelectedValue.ToString() + "";
                    }
                }
                else
                {
                    t = true;
                }
            }
            if (cmbCar.SelectedItem != null)
            { 
                if (cmbCar.SelectedValue.ToString() != "-1")
                {
                    if (query != "")
                    {
                        query += " and c.carID=" + cmbCar.SelectedValue.ToString() + "";
                    }
                    else
                    {
                        query += " c.carID=" + cmbCar.SelectedValue.ToString() + "";
                    }
                }
                else
                {
                    t = true;
                }
            }
            if (cmbPayed.SelectedItem != null)
            {
                string i="";
                if (cmbPayed.SelectedItem.ToString()== "Ödənilmişlər")
                {
                    i = "1";
                }
                else if(cmbPayed.SelectedItem.ToString() == "Ödənilməyənlər")
                {
                    i = "0";
                }
                if (i!="")
                {
                    if (query != "")
                    {
                        query += " and o.payed=" + i;
                    }
                    else
                    {
                        query += " o.payed=" + i;
                    }
                }
                else
                {
                    if (query != "")
                    {
                        query += " and o.payed in(0,1)";
                    }
                    else
                    {
                        query += " o.payed in(0,1)";
                    }
                }
            }
            if (txtCommonCostNote.Text != "")
            {
                if (query != "")
                {
                    query += " and o.commonCostNote like N'%" + txtCommonCostNote.Text + "%'";
                }
                else
                {
                    query += " o.commonCostNote like N'%" + txtCommonCostNote.Text + "%'";
                }
            }
            if (txtSpecialCostNote.Text != "")
            {
                if (query != "")
                {
                    query += " and o.specialCostNote like N'%" + txtSpecialCostNote.Text + "%'";
                }
                else
                {
                    query += " o.specialCostNote like N'%" + txtSpecialCostNote.Text + "%'";
                }
            }

            if (dtOrderCheck)
            {   
                if (!chckDate.Checked)
                {
                    if (query != "")
                    {
                        query += " and o.date='" + dtOrderDate.Value + "'";
                    }
                    else
                    {
                        query += " o.date = '" + dtOrderDate.Value + "'";
                    }
                }
                else
                {
                    if (chckBegin.Checked && chckEnd.Checked)
                    {
                        if (query != "")
                        {
                            query += " and o.date between '" + dtOrderDate.Value + "' and  '" + dtOrderDate1.Value + "'";
                        }
                        else
                        {
                            query += "   o.date between '" + dtOrderDate.Value + "' and  '" + dtOrderDate1.Value + "'";
                        }
                    }
                    else
                    {
                        string q1 = "";
                        string q2 = "";
                        DateTime dt1;
                        DateTime dt2;
                        if (!chckBegin.Checked)
                        {
                            q1 += " or ( o.date='" + dtOrderDate.Value + "' and  o.queue=N'Gündüz')";
                            dt1 = dtOrderDate.Value.AddDays(1);
                        }
                        else
                        {
                            dt1 = dtOrderDate.Value;
                        }
                        if (!chckEnd.Checked)
                        {
                            q2 += " or ( o.date='" + dtOrderDate1.Value + "' and  o.queue=N'Gecə')";
                            dt2 = dtOrderDate1.Value.AddDays(-1);
                        }
                        else
                        {
                            dt2 = dtOrderDate1.Value;
                        }
                        if (query != "")
                        { 
                            query += " and ( o.date between '" + dt1 + "' and  '" + dt2 + "' "+q1+"  "+q2+" ) ";
                        }
                        else
                        {
                            query += "   ( o.date between '" + dt1 + "' and  '" + dt2 + "' " + q1 + "  " + q2 + " ) ";
                        }
                    }
                }
            }

            if (query == "" && t)
            {
                query = "1=1";
            }
            string fullquery = @"Select  
                               o.orderID 
                              ,o.date   tarix 
                              ,o.queue növbə
                              ,o.commonAmount ümumi_məbləğ
                              ,o.payedByCard  kartla_ödənən
                              ,o.payedByCash  nəğd_ödənən
                              ,o.payedToBalance  balansa_ödənən
                              ,o.boltCompensation  Bolt_kompensasiya
                              ,o.drivingDistance   sürülən_məsafə
                              ,o.lastDistance    maşının_yürüşü
                              ,o.fuelMoney       yanacaq_pulu
                              ,o.driverMoney     sürücü_pulu
                              ,o.avance        avans
                              ,o.forDriver     sürücüyə_verilməlidir
                              ,o.payedToCard  karta_vurulan_pul
                              ,o.lastAmount         'son_məbləğ(Nəzarətçidə qalan)'
                              ,o.commonCost    ümumi_xərc
                              ,o.commonCostNote  ümumi_xərclə_bağlı_qeyd
                              ,o.specialCost      xüsusi_xərc
                              ,o.specialCostNote    xüsusi_xərclə_vağlı_qeyd 
                              ,o.lastAmountForEmploye   'işçinin_pulu(nəzarətçinin pulu)'
                              ,o.profit   qazanc
	                          ,c.carBrand+' '+c.carModel+' ('+c.carNumber+')'  Maşın
	                          ,d.name+ ' '+d.surname +' '+ d.fathername   Sürücü
                              ,case  when  o.payed=1 
                               then  N'Ödənilib'  
                               else N'Ödənilməyib'
                               end Ödənilmə
                               from tblOrder o
                               left join  tblCar c on o.carID=c.carID
                               left join  tblDriver  d on  o.driverID=d.driverID
                               where " + query+ "  order  by o.date"; 
            if (query != "")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand(fullquery, sqlconnect.connect());
                    SqlDataReader rd = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rd);
                    if (dt.Rows.Count != 0)
                    {
                        btnOrderModify.Columns.Clear();
                        btnOrderModify.DataSource = dt;
                        g.GridViewDesign(dt.Rows.Count, btnOrderModify);
                        for (int i = 1; i < dt.Columns.Count; i++)
                        {
                            btnOrderModify.Columns[i].Width = 50;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Uyğun sifariş  tapılmadı!");
                    }
                    sqlconnect.close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
                }
            }
            else
            {
                MessageBox.Show("Axtarış üçün ən azı bir sahə doldurulmalıdır!");
            }
            idOrder = -1;
        }
        private void BtnOrderToExcel_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < btnOrderModify.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = btnOrderModify.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < btnOrderModify.Rows.Count ; i++)
            {
                for (int j = 0; j < btnOrderModify.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = btnOrderModify.Rows[i].Cells[j].Value.ToString();
                }
            }

            // save the application  
            //workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();

             

        }

        private void orderRaport()
        {
            report.Clear();
            double commonAmount=0;
            double payedByCard = 0;
            double payedByCash = 0;
            double payedToBalance = 0;
            double boltCompensation = 0;
            double drivingDistance = 0;
            double fuelMoney = 0;
            double driverMoney = 0;
            double avance = 0;
            double forDriver = 0;
            double payedToCard = 0;
            double commonCost = 0;
            double specialCost = 0;
            double lastAmount = 0;
            double lastAmountForEmploye = 0;
            double profit = 0;
            double d;
            double isPayedAmount = 0;
            double isNotPayedAmount = 0;
            for (int i = 0; i < btnOrderModify.Rows.Count; i++)
            {
                if (double.TryParse(btnOrderModify.Rows[i].Cells[4].Value.ToString(), out d))
                {
                    commonAmount += Convert.ToDouble(btnOrderModify.Rows[i].Cells[4].Value);
                }
                if (double.TryParse(btnOrderModify.Rows[i].Cells[5].Value.ToString(), out d))
                {
                    payedByCard += Convert.ToDouble(btnOrderModify.Rows[i].Cells[5].Value);
                }
                if (double.TryParse(btnOrderModify.Rows[i].Cells[6].Value.ToString(), out d))
                {
                    payedByCash += Convert.ToDouble(btnOrderModify.Rows[i].Cells[6].Value);
                }
                if (double.TryParse(btnOrderModify.Rows[i].Cells[7].Value.ToString(), out d))
                {
                    payedToBalance += Convert.ToDouble(btnOrderModify.Rows[i].Cells[7].Value);
                }
                if (double.TryParse(btnOrderModify.Rows[i].Cells[8].Value.ToString(), out d))
                {
                    boltCompensation += Convert.ToDouble(btnOrderModify.Rows[i].Cells[8].Value);
                }
                if (double.TryParse(btnOrderModify.Rows[i].Cells[9].Value.ToString(), out d))
                {
                    drivingDistance += Convert.ToDouble(btnOrderModify.Rows[i].Cells[9].Value);
                }
                if (double.TryParse(btnOrderModify.Rows[i].Cells[11].Value.ToString(), out d))
                {
                    fuelMoney += Convert.ToDouble(btnOrderModify.Rows[i].Cells[11].Value);
                }
                if (double.TryParse(btnOrderModify.Rows[i].Cells[12].Value.ToString(), out d))
                {
                    driverMoney += Convert.ToDouble(btnOrderModify.Rows[i].Cells[12].Value);
                }
                if (double.TryParse(btnOrderModify.Rows[i].Cells[13].Value.ToString(), out d))
                {
                    avance += Convert.ToDouble(btnOrderModify.Rows[i].Cells[13].Value);
                }
                if (double.TryParse(btnOrderModify.Rows[i].Cells[14].Value.ToString(), out d))
                {
                    forDriver += Convert.ToDouble(btnOrderModify.Rows[i].Cells[14].Value);
                }
                if (double.TryParse(btnOrderModify.Rows[i].Cells[15].Value.ToString(), out d))
                {
                    payedToCard += Convert.ToDouble(btnOrderModify.Rows[i].Cells[15].Value);
                }
                if (double.TryParse(btnOrderModify.Rows[i].Cells[17].Value.ToString(), out d))
                {
                    commonCost += Convert.ToDouble(btnOrderModify.Rows[i].Cells[17].Value);
                }
                if (double.TryParse(btnOrderModify.Rows[i].Cells[19].Value.ToString(), out d))
                {
                    specialCost += Convert.ToDouble(btnOrderModify.Rows[i].Cells[19].Value);
                }
                if (double.TryParse(btnOrderModify.Rows[i].Cells[16].Value.ToString(), out d))
                {
                    lastAmount += Convert.ToDouble(btnOrderModify.Rows[i].Cells[16].Value);
                }
                if (double.TryParse(btnOrderModify.Rows[i].Cells[21].Value.ToString(), out d))
                {
                    lastAmountForEmploye += Convert.ToDouble(btnOrderModify.Rows[i].Cells[21].Value);
                }
                if (double.TryParse(btnOrderModify.Rows[i].Cells[22].Value.ToString(), out d))
                {
                    profit += Convert.ToDouble(btnOrderModify.Rows[i].Cells[22].Value);
                }
                if (double.TryParse(btnOrderModify.Rows[i].Cells[15].Value.ToString(), out d))
                {
                    if (btnOrderModify.Rows[i].Cells[25].Value.ToString()== "Ödənilib")
                    {
                        isPayedAmount += Convert.ToDouble(btnOrderModify.Rows[i].Cells[15].Value);
                    }
                    else
                    {
                        isNotPayedAmount += Convert.ToDouble(btnOrderModify.Rows[i].Cells[15].Value);
                    } 
                }
            }
            report.Add(commonAmount);
            report.Add(payedByCard);
            report.Add(payedByCash);
            report.Add(payedToBalance);
            report.Add(boltCompensation);
            report.Add(drivingDistance);
            report.Add(fuelMoney);
            report.Add(driverMoney);
            report.Add(avance);
            report.Add(forDriver);
            report.Add(payedToCard);
            report.Add(commonCost);
            report.Add(specialCost);
            report.Add(lastAmount);
            report.Add(lastAmountForEmploye);
            report.Add(profit);
            report.Add(isPayedAmount);
            report.Add(isNotPayedAmount);
        }
        private void CmbPayed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPayed.SelectedItem!=null && cmbPayed.SelectedItem.ToString()!="Hamısı")
            {
                cmbPayedCheck = true;
            }
            else
            {
                cmbPayedCheck = false;
            } 
        }
        private void BtnOrderRaport_Click(object sender, EventArgs e)
        {
            orderRaport(); 
            frmOrderRaport frmOrderRaport = new frmOrderRaport();
            frmOrderRaport.Text = "Hesabat";
            frmOrderRaport.ShowDialog();
        }
        private void getSelectedRows()
        {
            selectedRows = "";
            if (btnOrderModify.SelectedRows.Count > 0)
            { 
                foreach (DataGridViewRow row in btnOrderModify.SelectedRows)
                {
                    if (string.IsNullOrEmpty(selectedRows))
                    {
                        selectedRows = row.Cells["orderID"].Value.ToString();
                    }
                    else
                    {
                        selectedRows += "," + row.Cells["orderID"].Value.ToString();
                    }
                }
            }
        }
        private void updateSelectedPayedRows(string isPayed)
        {
            if (selectedRows != "")
            {
                string query = "UPDATE tblOrder SET  payed="+isPayed+" where orderID in (" + selectedRows + ")";
                try
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand(query, sqlconnect.connect());
                    cmd.ExecuteNonQuery();
                    sqlconnect.close();
                    MessageBox.Show("Düzəliş uğurla tamamlandı");  
                }
                catch (Exception)
                {
                    MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
                }
            }
            else
            {
                MessageBox.Show("Sətir seçilməyib!");
            }
        }
        private void ÖdənilmişKimiQeydEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getSelectedRows();
            updateSelectedPayedRows("1");
        }
        private void ÖdənilməmişKimiQeydEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getSelectedRows();
            updateSelectedPayedRows("0");
        }
        private void BtnOrdeModify_Click(object sender, EventArgs e)
        {
            if (idOrder!=-1)
            {
                orderCreateOrModify = true;
                frmOrderModify frmOrderModify = new frmOrderModify();
                frmOrderModify.Text = "Düzəliş et";
                frmOrderModify.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sifariş seçin!!!"); 
            }
          
        } 
        private void ChckBegin_CheckedChanged(object sender, EventArgs e)
        {
            if (!chckBegin.Checked && chckDate.Checked )
            {
                cmbxQueue.SelectedIndex = cmbxQueue.FindStringExact("Hamısı");
                cmbxQueue.Enabled = false;
            }
            if (chckBegin.Checked && chckEnd.Checked)
            {
                cmbxQueue.Enabled = true;
            }
        } 
        private void ChckEnd_CheckedChanged(object sender, EventArgs e)
        {
            if (!chckEnd.Checked && chckDate.Checked)
            {
                cmbxQueue.SelectedIndex = cmbxQueue.FindStringExact("Hamısı");
                cmbxQueue.Enabled = false;
            }
            if (chckBegin.Checked && chckEnd.Checked)
            {
                cmbxQueue.Enabled = true;
            }
        }



        #endregion


        #region RegionConstructor
        List<int> lstUpdateData;
        private void getAllID()
        {
            try
            {
                lstUpdateData = new List<int>();
                string query = "select orderID from  tblOrder"; 
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(query, sqlconnect.connect());
                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                if (dt.Rows.Count != 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        lstUpdateData.Add(Convert.ToInt32(dt.Rows[i][0].ToString()));
                    } 
                }
                sqlconnect.close();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
            }
        }
        private updateData getDataByID(int id)
        {
            updateData updateData = new updateData();
            try
            {
                string query = @"SELECT  
                               o.date     
                              ,o.queue  
                              ,o.commonAmount  
                              ,o.payedByCard   
                              ,o.payedByCash   
                              ,o.payedToBalance   
                              ,o.boltCompensation   
                              ,o.drivingDistance    
                              ,o.lastDistance     
                              ,o.fuelMoney       
                              ,o.driverMoney      
                              ,o.avance         
                              ,o.forDriver      
                              ,o.payedToCard   
                              ,o.lastAmount          
                              ,o.commonCost     
                              ,o.commonCostNote   
                              ,o.specialCost       
                              ,o.specialCostNote                                   
                              ,o.lastAmountForEmploye   
                              ,o.profit   qazanc
	                          ,o.driverID
	                          ,o.carID
                              ,o.payed
                          FROM tblOrder o 
                          left join  tblCar c on o.carID=c.carID
                          left join  tblDriver  d on  o.driverID=d.driverID 
                          where o.orderID=" + id.ToString() + "  order  by o.date";
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(query, sqlconnect.connect());
                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                if (dt.Rows.Count != 0)
                {
                    DataRow row = dt.Rows[0];
                    updateData.date = row["date"].ToString();
                    updateData.queue = row["queue"].ToString();
                    updateData.driverID = row["driverID"].ToString();
                    updateData.carID = row["carID"].ToString();
                    updateData.commonAmount = row["commonAmount"].ToString();
                    updateData.payedByCard = row["payedByCard"].ToString();
                    updateData.payedToBalance = row["payedToBalance"].ToString();
                    updateData.boltCompensation = row["boltCompensation"].ToString();
                    updateData.payedByCash = row["payedByCash"].ToString();
                    updateData.lastAmount = row["lastAmount"].ToString();
                    updateData.drivingDistance = row["drivingDistance"].ToString();
                    updateData.lastDistance = row["lastDistance"].ToString();
                    updateData.fuelMoney = row["fuelMoney"].ToString();
                    updateData.avance = row["avance"].ToString();
                    updateData.commonCost = row["commonCost"].ToString();
                    updateData.commonCostNote = row["commonCostNote"].ToString();
                    updateData.specialCost = row["specialCost"].ToString();
                    updateData.specialCostNote = row["specialCostNote"].ToString();
                    updateData.payed = row["payed"].ToString();
                }
                sqlconnect.close();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin"); 
            }
            return updateData;
        }
        private void updateData(updateData updateData,int id)
        {
            string payed=updateData.payed;
            string date = updateData.date;
            string queue = updateData.queue;
            int driver = Convert.ToInt32(updateData.driverID);
            int car = Convert.ToInt32(updateData.carID);
            double commonAmount = Convert.ToDouble(updateData.commonAmount);
            double payedByCard = Convert.ToDouble(updateData.payedByCard);
            double payeddToBalance = Convert.ToDouble(updateData.payedToBalance);
            double boltCompensation = Convert.ToDouble(updateData.boltCompensation);
            double drivingDistance = Convert.ToDouble(updateData.drivingDistance);
            double lastDistance = Convert.ToDouble(updateData.lastDistance);
            double fuelMoney = Convert.ToDouble(updateData.fuelMoney);
            double avance = Convert.ToDouble(updateData.avance);
            double commonCost = Convert.ToDouble(updateData.commonCost);
            string commonCostNote = updateData.commonCostNote;
            double specialCost = Convert.ToDouble(updateData.specialCost);
            string specialCostNote = updateData.specialCostNote;
            double payedByCash = commonAmount - payedByCard - boltCompensation;
            double payedByCash1 = payedByCash;
            double driverMoney;
            if (commonAmount <= 45)
            {
                driverMoney = 0;
            }
            else if (commonAmount <= 55)
            {
                driverMoney = 10;
            }
            else if (commonAmount <= 60)
            {
                driverMoney = 12;
            }
            else if (commonAmount <= 70)
            {
                driverMoney = 15;
            }
            else if (commonAmount <= 80)
            {
                driverMoney = 18;
            }
            else if (commonAmount <= 90)
            {
                driverMoney = 20;
            }
            else if (commonAmount <= 100)
            {
                driverMoney = 25;
            }
            else if (commonAmount <= 110)
            {
                driverMoney = 30;
            }
            else
            {
                driverMoney = 35;
            }

            double forDriver = driverMoney - avance;
            if (payedByCash % 1 < 0.9)
            {
                payedByCash = payedByCash - payedByCash % 1;
            }
            else
            {
                payedByCash = payedByCash - payedByCash % 1 + 1;
            }
            double lastAmount = payedByCash - payeddToBalance - fuelMoney - avance - commonCost;
            double payedToCard = lastAmount - forDriver;
            double lastAmountForEmploye = (payedToCard) * 0.3;
            double profit = (payedToCard - lastAmountForEmploye - specialCost);

            try
            {
                string query = @"update   tblOrder set  
                                           date=@date,queue=@queue,commonAmount=@commonAmount,
                                            payedByCard=@payedByCard,payedByCash=@payedByCash,payedToBalance=@payedToBalance,boltCompensation=@boltCompensation,
                                           drivingDistance=@drivingDistance,lastDistance=@lastDistance,fuelMoney=@fuelMoney,
                                           driverMoney=@driverMoney,avance=@avance,forDriver=@forDriver,
                                            payedToCard=@payedToCard,commonCost=@commonCost,commonCostNote=@commonCostNote,
                                            specialCost=@specialCost,specialCostNote=@specialCostNote,lastAmount=@lastAmount,
                                           lastAmountForEmploye=@lastAmountForEmploye,profit=@profit,driverID=@driverID,carID=@carID,payed=@payed where orderID=" + id.ToString() + "";
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(query, sqlconnect.connect());
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@queue", queue);
                cmd.Parameters.AddWithValue("@commonAmount", commonAmount.ToString());
                cmd.Parameters.AddWithValue("@payedByCard", payedByCard.ToString());
                cmd.Parameters.AddWithValue("@payedByCash", payedByCash1.ToString());
                cmd.Parameters.AddWithValue("@payedToBalance", payeddToBalance.ToString());
                cmd.Parameters.AddWithValue("@boltCompensation", boltCompensation.ToString());
                cmd.Parameters.AddWithValue("@drivingDistance", drivingDistance.ToString());
                cmd.Parameters.AddWithValue("@lastDistance", lastDistance.ToString());
                cmd.Parameters.AddWithValue("@fuelMoney", fuelMoney.ToString());
                cmd.Parameters.AddWithValue("@driverMoney", driverMoney.ToString());
                cmd.Parameters.AddWithValue("@avance", avance.ToString());
                cmd.Parameters.AddWithValue("@forDriver", forDriver.ToString());
                cmd.Parameters.AddWithValue("@payedToCard", payedToCard.ToString());
                cmd.Parameters.AddWithValue("@commonCost", commonCost.ToString());
                cmd.Parameters.AddWithValue("@commonCostNote", txtCommonCostNote.Text);
                cmd.Parameters.AddWithValue("@specialCost", specialCost.ToString());
                cmd.Parameters.AddWithValue("@specialCostNote", txtSpecialCostNote.Text);
                cmd.Parameters.AddWithValue("@lastAmount", lastAmount.ToString());
                cmd.Parameters.AddWithValue("@lastAmountForEmploye", lastAmountForEmploye.ToString());
                cmd.Parameters.AddWithValue("@profit", profit.ToString());
                cmd.Parameters.AddWithValue("@driverID", driver.ToString());
                cmd.Parameters.AddWithValue("@carID", car.ToString());
                cmd.Parameters.AddWithValue("@payed", payed);
                cmd.ExecuteNonQuery();
                sqlconnect.close();  
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
            }
        }
        private void BtnUpdateData_Click(object sender, EventArgs e)
        { 
            string s = MessageBox.Show("Bütün məlumatların yeni qaydaya uyğun hesablanmasına  əminsiniz?!", "Diqqət", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (s == "Yes")
            {
                getAllID();
                foreach (var id in lstUpdateData)
                {
                    updateData(getDataByID(id),id);
                }
                MessageBox.Show("Bütün  məlumatlar  yenidən hesablandı!");
            } 
        }

        #endregion

        private void BtnOrderModify_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
