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
    public partial class frmAdminAdd : Form
    {
        public frmAdminAdd()
        {
            InitializeComponent();
        }
        SqlConnect sqlconnect = new SqlConnect();
        Random random = new Random();
        private void FrmAdminAdd_Load(object sender, EventArgs e)
        {
            if (!frmAdminPanel.adminCreateOrModify)
            {
                pnlAdminModify.Visible = false;
                pnlAdminAdd.Visible = true;
                txtAdminPasswordAdd.Enabled = false;
                txtAdminPasswordAdd1.Enabled = false;
                chckBxAdminPasswordAdd.Checked = false;
                lblPasswordRepeatAdd.Enabled = false;
                lblAdminPasswordAdd.Enabled = false;
            }
            else
            {

                chckBxAdminPasswordModify.Enabled = false;
                pnlAdminAdd.Visible = false;
                pnlAdminModify.Visible = true;
                txtAdminPasswordModify.Enabled = false;
                txtAdminPasswordModify1.Enabled = false;
                chckBxAdminPasswordModify.Checked = false;
                lblAdminPasswordModify.Enabled = false;
                lblPasswordRepeatModify.Enabled = false;  
            }
        }

        #region regionAdminAdd
        private void BtnAdminAddCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void BtnAdminAddApply_Click(object sender, EventArgs e)
        {
            string password = "";
            if (txtAdminNameAdd.Text == "")
            {
                MessageBox.Show("Ad sahəsi boşdur!!!");
                return;
            }
            if (txtAdminSurnameAdd.Text == "")
            {
                MessageBox.Show("Soyad sahəsi boşdur!!!");
                return;
            }
            if (txtAdminFatherNameAdd.Text == "")
            {
                MessageBox.Show("Ata adı sahəsi boşdur!!!");
                return;
            }
            if (txtAdminFinAdd.Text == "")
            {
                MessageBox.Show("Fin sahəsi boşdur!!!");
                return;
            }
            if (txtAdminUsernameAdd.Text == "")
            {
                MessageBox.Show("İstifadəçi adı sahəsi boşdur!!!");
                return;
            }
            if (!chckBxAdminPasswordAdd.Checked)
            {
                password = "";
                for (int i = 0; i < 10; i++)
                {
                    password += random.Next(0, 9).ToString();
                }
            }
            else
            {
                if (txtAdminPasswordAdd.Text == "")
                {
                    MessageBox.Show("Şifrə sahəsi boşdur!!!");
                    return;
                }
                if (txtAdminPasswordAdd1.Text == "")
                {
                    MessageBox.Show("Şifrəni təkrar daxil edin!!!");
                    return;
                }
                if (txtAdminPasswordAdd.Text != txtAdminPasswordAdd1.Text)
                {
                    MessageBox.Show("Şifrənin təkrarı yalnışdır!!!");
                    return;
                }
                else
                {
                    password = txtAdminPasswordAdd.Text;
                }
            }
            try
            {
                string query = "insert into tblAdmin values(@Name,@Surname,@fathername,@Fin,@Birthday,@Username,@Password)";
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(query, sqlconnect.connect());
                cmd.Parameters.AddWithValue("@Name", txtAdminNameAdd.Text);
                cmd.Parameters.AddWithValue("@Surname", txtAdminSurnameAdd.Text);
                cmd.Parameters.AddWithValue("@fathername", txtAdminFatherNameAdd.Text);
                cmd.Parameters.AddWithValue("@Birthday", dateAdminBirthdayAdd.Value);
                cmd.Parameters.AddWithValue("@Fin", txtAdminFinAdd.Text);
                cmd.Parameters.AddWithValue("@Username", txtAdminUsernameAdd.Text);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.ExecuteNonQuery();
                sqlconnect.close();
                MessageBox.Show("Məlumatın əlavə edilməsi uğurla tamamlandı");
                frmAdminPanel.adminCreateOrModify = false;
                this.Hide();
                frmAdminPanel.idAdmin = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
            }
        }
        private void ChckBxAdminPasswordAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBxAdminPasswordAdd.Checked)
            {
                txtAdminPasswordAdd.Enabled = true;
                txtAdminPasswordAdd1.Enabled = true;
                txtAdminPasswordAdd.Text = "";
                txtAdminPasswordAdd1.Text = "";
                lblPasswordRepeatAdd.Enabled = true;
                lblAdminPasswordAdd.Enabled = true;
            }
            else
            {
                txtAdminPasswordAdd.Enabled = false;
                txtAdminPasswordAdd1.Enabled = false;
                lblPasswordRepeatAdd.Enabled = false;
                lblAdminPasswordAdd.Enabled = false;
            }
        }
        #endregion

        #region regionAdminModify  
        private void BtnAdminModifyCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void BtnAdminModifyApply_Click(object sender, EventArgs e)
        {
            string s = MessageBox.Show("Məlumata düzəliş edilməsinə əminsiniz?", "Diqqət", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();

            if (s == "Yes")
            {
                string query = "";
                string password = "";
                if (txtAdminNameModify.Text != "")
                {
                    query += " name=N'" + txtAdminNameModify.Text + "'";
                }

                if (txtAdminSurnameModify.Text != "")
                {
                    if (query != "")
                    {
                        query += " , surname=N'" + txtAdminSurnameModify.Text + "'";
                    }
                    else
                    {
                        query += " surname=N'" + txtAdminSurnameModify.Text + "'";
                    }
                }


                if (txtAdminFatherNameModify.Text != "")
                {
                    if (query != "")
                    {
                        query += " , fathername=N'" + txtAdminFatherNameModify.Text + "'";
                    }
                    else
                    {
                        query += " fathername=N'" + txtAdminFatherNameModify.Text + "'";
                    }
                }

                if (txtAdminFinModify.Text != "")
                {
                    if (query != "")
                    {
                        query += " , fin=N'" + txtAdminFinModify.Text + "'";
                    }
                    else
                    {
                        query += " fin=N'" + txtAdminFinModify.Text + "'";
                    }
                }

                if (dtAdminBirtdayModify.Text != "")
                {
                    if (query != "")
                    {
                        query += " , birtday='" + dtAdminBirtdayModify.Value.ToString() + "'";
                    }
                    else
                    {
                        query += " birtday='" + dtAdminBirtdayModify.Value.ToString() + "'";
                    }
                }
                if (txtAdminUsernameModify.Text != "")
                {
                    if (query != "")
                    {
                        query += " , username=N'" + txtAdminUsernameModify.Text + "'";
                    }
                    else
                    {
                        query += " username=N'" + txtAdminUsernameModify.Text + "'";
                    }
                }

                if (chckBxAdminPasswordModify1.Checked)
                {
                    if (!chckBxAdminPasswordModify.Checked)
                    {
                        password = "";
                        for (int i = 0; i < 10; i++)
                        {
                            password += random.Next(0, 9).ToString();
                        }
                        if (query == "")
                        {
                            query += "Password='" + password + "'";
                        }
                        else
                        {
                            query += ",Password='" + password + "'";
                        }
                    }
                    else
                    {
                        if (txtAdminPasswordModify.Text == "")
                        {
                            MessageBox.Show("Şifrə sahəsi boşdur!!!");
                            return;
                        }
                        if (txtAdminPasswordModify1.Text == "")
                        {
                            MessageBox.Show("Şifrəni təkrar daxil edin!!!");
                            return;
                        }
                        if (txtAdminPasswordModify.Text != txtAdminPasswordModify1.Text)
                        {
                            MessageBox.Show("Şifrənin təkrarı yalnışdır!!!");
                            return;
                        }
                        if (query == "")
                        {
                            query += "Password='" + txtAdminPasswordModify.Text + "'";
                        }
                        else
                        {
                            query += ",Password='" + txtAdminPasswordModify.Text + "'";
                        }
                    }
                }

                if (query != "")
                {
                    string fullquery = "UPDATE tblAdmin SET " + query + " Where adminID=" + frmAdminPanel.idAdmin;
                    try
                    {

                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand(fullquery, sqlconnect.connect());
                        cmd.ExecuteNonQuery();
                        sqlconnect.close();
                        MessageBox.Show("Düzəliş uğurla tamamlandı");
                        frmAdminPanel.adminCreateOrModify = false;
                        this.Hide();
                        sqlconnect.close();
                        frmAdminPanel.idAdmin = -1;
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
        private void ChckBxAdminPasswordModify1_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBxAdminPasswordModify1.Checked)
            {
                chckBxAdminPasswordModify.Enabled = true;
            }
            else
            {
                chckBxAdminPasswordModify.Enabled = false;
                chckBxAdminPasswordModify.Checked = false;
            }
        }
        private void ChckBxAdminPasswordModify_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBxAdminPasswordModify.Checked)
            {
                txtAdminPasswordModify.Enabled = true;
                txtAdminPasswordModify1.Enabled = true;
                chckBxAdminPasswordModify.Checked = true;
                lblAdminPasswordModify.Enabled = true;
                lblPasswordRepeatModify.Enabled = true;
            }
            else
            {
                txtAdminPasswordModify.Enabled = false;
                txtAdminPasswordModify1.Enabled = false;
                chckBxAdminPasswordModify.Checked = false;
                lblAdminPasswordModify.Enabled = false;
                lblPasswordRepeatModify.Enabled = false;
            }
        }
        #endregion
    }
}
