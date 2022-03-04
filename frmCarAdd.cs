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
    public partial class frmCarAdd : Form
    {
        public frmCarAdd()
        {
            InitializeComponent();
        }
        SqlConnect sqlconnect = new SqlConnect();

        private void FrmCarAdd_Load(object sender, EventArgs e)
        {
            if (!frmAdminPanel.carCreateOrModify)
            {
                pnlCarModify.Visible = false;
                pnlCarAdd.Visible = true;
            }
            else
            {
                pnlCarAdd.Visible = false;
                pnlCarModify.Visible = true;   
            } 
        }

        #region regionCarAdd

        private void BtnCarAddCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void BtnCarAddApply_Click(object sender, EventArgs e)
        {
            if (txtBrand.Text == "")
            {
                MessageBox.Show("Marka sahəsi boşdur!!!");
                return;
            }
            if (txtModel.Text == "")
            {
                MessageBox.Show("Model sahəsi sahəsi boşdur!!!");
                return;
            }
            if (txtNumber.Text == "")
            {
                MessageBox.Show("Nömrə sahəsi boşdur!!!");
                return;
            }
            if (txtYear.Text == "")
            {
                MessageBox.Show("İl sahəsi boşdur!!!");
                return;
            }
            if (txtCarColor.Text == "")
            {
                MessageBox.Show("Rəng sahəsi boşdur!!!");
                return;
            }
            try
            {
                string query = "insert into tblCar values(@carBrand,@carModel,@carNumber,@carYear,@carColor)";
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(query, sqlconnect.connect());
                cmd.Parameters.AddWithValue("@carBrand", txtBrand.Text);
                cmd.Parameters.AddWithValue("@carModel", txtModel.Text);
                cmd.Parameters.AddWithValue("@carNumber", txtNumber.Text);
                cmd.Parameters.AddWithValue("@carYear", txtYear.Text);
                cmd.Parameters.AddWithValue("@carColor", txtCarColor.Text);
                cmd.ExecuteNonQuery();
                sqlconnect.close();
                MessageBox.Show("Məlumatın əlavə edilməsi uğurla tamamlandı");
                frmAdminPanel.carCreateOrModify = false;
                this.Hide();
                frmAdminPanel.idCar = -1; 
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
            }
        }



        #endregion


        #region region CarModify
        private void BtnCarCancelModify_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

         

        private void BtnCarApplyModify_Click(object sender, EventArgs e)
        {
            string s = MessageBox.Show("Məlumata düzəliş edilməsinə əminsiniz?", "Diqqət", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (s == "Yes")
            {
                string query = "";

                if (txtBrandModify.Text != "")
                {
                    query += " carBrand=N'" + txtBrandModify.Text + "'";
                }

                if (txtModelModify.Text != "")
                {
                    if (query != "")
                    {
                        query += " , carModel=N'" + txtModelModify.Text + "'";
                    }
                    else
                    {
                        query += " carModel=N'" + txtModelModify.Text + "'";
                    }
                }


                if (txtNumberModify.Text != "")
                {
                    if (query != "")
                    {
                        query += " , carNumber=N'" + txtNumberModify.Text + "'";
                    }
                    else
                    {
                        query += " carNumber=N'" + txtNumberModify.Text + "'";
                    }
                }

                if (txtYearModify.Text != "")
                {
                    if (query != "")
                    {
                        query += " , carYear=N'" + txtYearModify.Text + "'";
                    }
                    else
                    {
                        query += " carYear=N'" + txtYearModify.Text + "'";
                    }
                }

                if (txtColorModify.Text != "")
                {
                    if (query != "")
                    {
                        query += " , carColor=N'" + txtColorModify.Text + "'";
                    }
                    else
                    {
                        query += " carColor=N'" + txtColorModify.Text + "'";
                    }
                }
                if (query != "")
                {
                    string fullquery = "UPDATE tblCar SET " + query + " Where carID=" + frmAdminPanel.idCar;
                    try
                    {

                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand(fullquery, sqlconnect.connect());
                        cmd.ExecuteNonQuery();
                        sqlconnect.close();
                        MessageBox.Show("Düzəliş uğurla tamamlandı");
                        frmAdminPanel.carCreateOrModify = false;
                        this.Hide();
                        sqlconnect.close();
                        frmAdminPanel.idCar = -1;
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
