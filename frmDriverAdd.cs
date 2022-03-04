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
    public partial class frmDriverAdd : Form
    {
        public frmDriverAdd()
        {
            InitializeComponent();
        }
        SqlConnect sqlconnect = new SqlConnect();

        private void FrmDriverAdd_Load(object sender, EventArgs e)
        {
            if (!frmAdminPanel.driverCreateOrModify)
            {
                pnlDriverModify.Visible = false;
                pnlDriverAdd.Visible = true;
            }
            else
            {
                pnlDriverAdd.Visible = false;
                pnlDriverModify.Visible = true;
            }
        }




        #region regionDriverAdd
        private void BtnDriverAddCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void BtnDriverAddApply_Click(object sender, EventArgs e)
        {
            if (txtDriverNameAdd.Text == "")
            {
                MessageBox.Show("Ad sahəsi boşdur!!!");
                return;
            }
            if (txtDriverSurnameAdd.Text == "")
            {
                MessageBox.Show("Soyad sahəsi sahəsi boşdur!!!");
                return;
            }
            if (txtDriverFatherNameAdd.Text == "")
            {
                MessageBox.Show("Ata adı sahəsi boşdur!!!");
                return;
            }
            if (dtDriverBirtdayAdd.Text == "")
            {
                MessageBox.Show("Doğum tarixi sahəsi boşdur!!!");
                return;
            }
            if (txtDriverFinAdd.Text == "")
            {
                MessageBox.Show("Fin sahəsi boşdur!!!");
                return;
            }
            try
            {
                string query = "insert into tblDriver values(@name,@surname,@fathername,@fin,@birtday)";
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(query, sqlconnect.connect());
                cmd.Parameters.AddWithValue("@name", txtDriverNameAdd.Text);
                cmd.Parameters.AddWithValue("@surname", txtDriverSurnameAdd.Text);
                cmd.Parameters.AddWithValue("@fathername", txtDriverFatherNameAdd.Text);
                cmd.Parameters.AddWithValue("@fin", txtDriverFinAdd.Text);
                cmd.Parameters.AddWithValue("@birtday", dtDriverBirtdayAdd.Value);
                cmd.ExecuteNonQuery();
                sqlconnect.close();
                MessageBox.Show("Məlumatın əlavə edilməsi uğurla tamamlandı");
                frmAdminPanel.driverCreateOrModify = false;
                this.Hide();
                frmAdminPanel.idDriver = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
            }
        }
         
        #endregion


        #region region CarModify

        private void BtnDriverCancelModify_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnDriverApplyModify_Click(object sender, EventArgs e)
        {
            string s = MessageBox.Show("Məlumata düzəliş edilməsinə əminsiniz?", "Diqqət", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (s == "Yes")
            {
                string query = "";

                if (txtDriverNameModify.Text != "")
                {
                    query += " name=N'" + txtDriverNameModify.Text + "'";
                }

                if (txtDriverSurnameModify.Text != "")
                {
                    if (query != "")
                    {
                        query += " , surname=N'" + txtDriverSurnameModify.Text + "'";
                    }
                    else
                    {
                        query += " surname=N'" + txtDriverSurnameModify.Text + "'";
                    }
                }


                if (txtDriverFatherNameModify.Text != "")
                {
                    if (query != "")
                    {
                        query += " , fathername=N'" + txtDriverFatherNameModify.Text + "'";
                    }
                    else
                    {
                        query += " fathername=N'" + txtDriverFatherNameModify.Text + "'";
                    }
                }

                if (txtDriverFinModify.Text != "")
                {
                    if (query != "")
                    {
                        query += " , fin=N'" + txtDriverFinModify.Text + "'";
                    }
                    else
                    {
                        query += " fin=N'" + txtDriverFinModify.Text + "'";
                    }
                }

                if (dtDriverBirtdayModify.Text != "")
                {
                    if (query != "")
                    {
                        query += " , birtday='" + dtDriverBirtdayModify.Value.ToString() + "'";
                    }
                    else
                    {
                        query += " birtday='" + dtDriverBirtdayModify.Value.ToString() + "'";
                    }
                }
                if (query != "")
                {
                    string fullquery = "UPDATE tblDriver SET " + query + " Where driverID=" + frmAdminPanel.idDriver;
                    try
                    {

                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand(fullquery, sqlconnect.connect());
                        cmd.ExecuteNonQuery();
                        sqlconnect.close();
                        MessageBox.Show("Düzəliş uğurla tamamlandı");
                        frmAdminPanel.driverCreateOrModify = false;
                        this.Hide();
                        sqlconnect.close();
                        frmAdminPanel.idDriver = -1;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
                    }
                }
                else
                {
                    MessageBox.Show("Düzəlişləri daxil edin!");
                }
            }
        } 
         
        #endregion
    }
}
