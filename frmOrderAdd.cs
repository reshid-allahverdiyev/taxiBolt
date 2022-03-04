﻿using System;
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
    public partial class frmOrderAdd : Form
    {
        public frmOrderAdd()
        {
            InitializeComponent();
        }
        SqlConnect sqlconnect = new SqlConnect();
        private void FrmOrderAdd_Load(object sender, EventArgs e)
        {
            cmbDriverFill();
            cmbCarFill();
            cmbxQueue.SelectedItem = null;
            cmbxQueue.Text = "Növbə seçin";
            chckPayed.Checked = false;
        }
        private void cmbDriverFill()
        {
            try
            {
                string query = "Select driverID, Name+  '  '+surname as  driver  from tblDriver";
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
                string query = @"Select carID, carBrand+  '  '+carModel +'  ('+ carNumber +')'  as  car  from tblCar";
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

        private void BtnOrderAddCancel_Click(object sender, EventArgs e)
        {
            this.Hide();  
        }

        private string setTxtPayedByCash()
        {
            try
            {
                if (txtCommonAmount.Text != "" && txtPayedByCard.Text != "" && txtBoltCompensation.Text != "")
                {
                    return (double.Parse(txtCommonAmount.Text) - double.Parse(txtPayedByCard.Text) - double.Parse(txtBoltCompensation.Text)).ToString();
                }
                else
                {
                    return "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
                return "";
            } 
        }
        private bool checkCarExist()
        {
            bool result = false;
            try
            {                
                string query = @"select * from  tblOrder  o where 
                                o.date='"+ dtOrderDate.Value.ToString() + "' " +
                                " and  o.queue=N'"+ cmbxQueue.SelectedItem.ToString() + "'  " +
                                "and o.carID="+ cmbCar.SelectedValue.ToString() + "";
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(query, sqlconnect.connect());

                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable(); 
                dt.Load(rd);
                if (dt.Rows.Count != 0)
                {
                    result = true;
                }                
                else
                {
                    result =false;
                }
                sqlconnect.close();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");    
            }
            return result;
        }
        private bool checkDriverExist()
        {
            bool result = false;
            try
            {
                string query = @"select * from  tblOrder  o where 
                                o.date='" + dtOrderDate.Value.ToString() + "' " +
                                " and  o.queue=N'" + cmbxQueue.SelectedItem.ToString() + "'  " +
                                "and o.carID=" + cmbDriver.SelectedValue.ToString() + "";
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(query, sqlconnect.connect());

                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                if (dt.Rows.Count != 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                } 
                sqlconnect.close();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
            }
            return result;
        }
        private void BtnOrderAddApply_Click(object sender, EventArgs e)
        {    
            
            if (cmbxQueue.SelectedItem==null)
            {
                MessageBox.Show("Növbəni seçin!!!");
                return;
            }
            if (cmbDriver.SelectedItem == null)
            {
                MessageBox.Show("Sürücünü seçin!!!");
                return;
            }
            if (cmbCar.SelectedItem ==null)
            {
                MessageBox.Show("Maşını seçin!!!");
                return;
            } 
           
            if (txtCommonAmount.Text == "")
            {
                MessageBox.Show("Ümumi məbləğ sahəsi boşdur!!!");
                return;
            }
            if (txtPayedByCard.Text == "")
            {
                MessageBox.Show("Kartla ödənən sahəsi boşdur!!!");
                return;
            } 
            if (txtPayedByCard.Text == "")
            {
                MessageBox.Show("Kartla ödənən sahəsi boşdur!!!");
                return;
            }
            if (txtPayedToBalance.Text == "")
            {
                MessageBox.Show("Balansa ödənən sahəsi boşdur!!!");
                return;
            }
            if (txtBoltCompensation.Text == "")
            {
                MessageBox.Show("Bolt kompensasiya sahəsi boşdur!!!");
                return;
            }
            //if (txtDrivingDistance.Text == "")
            //{
            //    MessageBox.Show("Sürülən məsafə sahəsi boşdur!!!");
            //    return;
            //}
            if (txtLastDistance.Text == "")
            {
                MessageBox.Show("Maşının yürüşü sahəsi boşdur!!!");
                return;
            }
            if (txtFuelMoney.Text == "")
            {
                MessageBox.Show("Yanacaq pulu sahəsi boşdur!!!");
                return;
            }
            if (txtAvance.Text == "")
            {
                MessageBox.Show("Avans sahəsi boşdur!!!");
                return;
            }
            if (txtCommonCost.Text == "")
            {
                txtCommonCost.Text = "0";
                //MessageBox.Show("Ümumi xərc sahəsi boşdur!!!");
                //return;
            }
            if (txtCommonCostNote.Text == "")
            {
                //MessageBox.Show("Ümumi xərc haqda qeyd sahəsi boşdur!!!");
                //return;
            }
            if (txtSpecialCost.Text == "")
            {
                txtSpecialCost.Text = "0";
                //MessageBox.Show("Xüsusi xərc sahəsi boşdur!!!");
                //return;
            }
            if (txtSpecialCostNote.Text == "")
            {
                //MessageBox.Show("Xüsusi xərc haqda qeyd sahəsi boşdur!!!");
                //return;
            }



            int payed;
            if (chckPayed.Checked)
            {
                payed = 1;
            }
            else
            {
                payed = 0;
            }
            DateTime date = dtOrderDate.Value;
            string queue = cmbxQueue.SelectedItem.ToString();
            int driver = Convert.ToInt32(cmbDriver.SelectedValue);
            int car = Convert.ToInt32(cmbCar.SelectedValue); 
            double commonAmount = double.Parse(txtCommonAmount.Text);
            double payedByCard = double.Parse(txtPayedByCard.Text); 
            double payeddToBalance = double.Parse(txtPayedToBalance.Text);
            double boltCompensation = double.Parse(txtBoltCompensation.Text);
            double drivingDistance = double.Parse(txtDrivingDistance.Text);
            double lastDistance = double.Parse(txtLastDistance.Text);
            double fuelMoney = double.Parse(txtFuelMoney.Text);
            double avance = double.Parse(txtAvance.Text);
            double commonCost = double.Parse(txtCommonCost.Text);
            string commonCostNote = txtCommonCostNote.Text;
            double specialCost = double.Parse(txtSpecialCost.Text);
            string specialCostNote = txtSpecialCostNote.Text;

            double payedByCash = commonAmount - payedByCard  - boltCompensation;
            double payedByCash1 = payedByCash;
            double driverMoney;

            driverMoney = Interval.calcInterval(commonAmount);
            
            double forDriver = driverMoney - avance;
            if (payedByCash % 1 < 0.9)
            {
                payedByCash = payedByCash - payedByCash % 1;
            }
            else
            {
                payedByCash = payedByCash - payedByCash % 1 + 1;
            }
            //double lastAmount = payedByCash - payeddToBalance - fuelMoney - avance - commonCost-specialCost;
            //double payedToCard = lastAmount-forDriver;
            //double lastAmountForEmploye = (payedToCard+specialCost) * 0.3; 
            //double profit = (payedToCard - lastAmountForEmploye - specialCost);    


            double lastAmount = payedByCash - payeddToBalance - fuelMoney - avance - commonCost;
            double payedToCard = lastAmount - forDriver;
            double lastAmountForEmploye = (payedToCard) * 0.2;
            double profit = (payedToCard - lastAmountForEmploye - specialCost);

            try
            {
                if (checkCarExist())
                {
                    MessageBox.Show("Cari maşın üçün seçilmiş  vaxtda sifariş mövcuddur!!!");
                    return;
                }
                else if (checkDriverExist())
                {
                    MessageBox.Show("Cari sürücü üçün seçilmiş  vaxtda sifariş mövcuddur!!!");
                    return;
                }
                else
                {
                    string query = @"insert into tblOrder values
                                           (@date,@queue,@commonAmount,
                                            @payedByCard,@payedByCash,@payedToBalance,@boltCompensation,
                                           @drivingDistance,@lastDistance,@fuelMoney,
                                           @driverMoney,@avance,@forDriver,
                                            @payedToCard,@commonCost,@commonCostNote,
                                            @specialCost,@specialCostNote,@lastAmount,
                                           @lastAmountForEmploye,@profit,@driverID,@carID,@payed)";
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand(query, sqlconnect.connect());
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@queue", queue);
                    cmd.Parameters.AddWithValue("@commonAmount", txtCommonAmount.Text);
                    cmd.Parameters.AddWithValue("@payedByCard", txtPayedByCard.Text);
                    cmd.Parameters.AddWithValue("@payedByCash", payedByCash1.ToString());
                    cmd.Parameters.AddWithValue("@payedToBalance", txtPayedToBalance.Text);
                    cmd.Parameters.AddWithValue("@boltCompensation", txtBoltCompensation.Text);
                    cmd.Parameters.AddWithValue("@drivingDistance", txtDrivingDistance.Text);
                    cmd.Parameters.AddWithValue("@lastDistance", txtLastDistance.Text);
                    cmd.Parameters.AddWithValue("@fuelMoney", txtFuelMoney.Text);
                    cmd.Parameters.AddWithValue("@driverMoney", driverMoney.ToString());
                    cmd.Parameters.AddWithValue("@avance", txtAvance.Text);
                    cmd.Parameters.AddWithValue("@forDriver", forDriver.ToString());
                    cmd.Parameters.AddWithValue("@payedToCard", payedToCard.ToString());
                    cmd.Parameters.AddWithValue("@commonCost", txtCommonCost.Text);
                    cmd.Parameters.AddWithValue("@commonCostNote", txtCommonCostNote.Text);
                    cmd.Parameters.AddWithValue("@specialCost", txtSpecialCost.Text);
                    cmd.Parameters.AddWithValue("@specialCostNote", txtSpecialCostNote.Text);
                    cmd.Parameters.AddWithValue("@lastAmount", lastAmount.ToString());
                    cmd.Parameters.AddWithValue("@lastAmountForEmploye", lastAmountForEmploye.ToString());
                    cmd.Parameters.AddWithValue("@profit", profit.ToString());
                    cmd.Parameters.AddWithValue("@driverID", cmbDriver.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@carID", cmbCar.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@payed", payed);
                    cmd.ExecuteNonQuery();
                    sqlconnect.close();
                    MessageBox.Show("Məlumatın əlavə edilməsi uğurla tamamlandı");
                    frmAdminPanel.adminCreateOrModify = false;
                    this.Hide();
                    frmAdminPanel.idOrder = -1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
            }
        }

        private void TxtCommonAmount_TextChanged(object sender, EventArgs e)
        {
            txtPayedByCash.Text = setTxtPayedByCash();
        }

        private void TxtPayedByCard_TextChanged(object sender, EventArgs e)
        {
            txtPayedByCash.Text = setTxtPayedByCash();
        }

        private void TxtBoltCompensation_TextChanged(object sender, EventArgs e)
        {
            txtPayedByCash.Text = setTxtPayedByCash();
        }

        int lastDistance=0;
        private void getLastDistane(string carID)
        {
            try
            {
                string query = "select top 1  lastDistance from  tblOrder where  carID="+carID+" and date<='"+dtOrderDate.Value.ToString()+"'  order by  orderID desc";
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(query, sqlconnect.connect());
                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                if (dt.Rows.Count != 0)
                {
                    lastDistance = Convert.ToInt32(dt.Rows[0][0].ToString());
                }
                sqlconnect.close();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
            }
        }
        private string setTxtDrivingDistance()
        {
            try
            {
                if (txtLastDistance.Text != "")
                {  
                    return (double.Parse(txtLastDistance.Text) - lastDistance).ToString();
                }
                else
                {
                    return "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
                return "";
            }
        }

        private void TxtLastDistance_TextChanged(object sender, EventArgs e)
        {
            if (cmbCar.SelectedValue!=null && txtLastDistance.Text!="")
            {
                getLastDistane(cmbCar.SelectedValue.ToString());
                txtDrivingDistance.Text = setTxtDrivingDistance();
            }            
        }

        private void CmbCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLastDistance.Text = "";
            txtDrivingDistance.Text = "";
        }



        private string setTxtLastAmount()
        {
            try
            {
                if (txtPayedByCash.Text != "" && txtPayedToBalance.Text != "" && txtFuelMoney.Text != "" && txtAvance.Text != "" && txtCommonCost.Text != "" && txtSpecialCost.Text != "")
                {
                    return (double.Parse(txtPayedByCash.Text) - double.Parse(txtPayedToBalance.Text) - double.Parse(txtFuelMoney.Text)- double.Parse(txtAvance.Text)- double.Parse(txtCommonCost.Text)- double.Parse(txtSpecialCost.Text)).ToString();
                }
                else
                {
                    return "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
                return "";
            }
        }

        private void TxtPayedByCash_TextChanged(object sender, EventArgs e)
        {
            txtLastAmount.Text = setTxtLastAmount();
        }

        private void TxtPayedToBalance_TextChanged(object sender, EventArgs e)
        {
            txtLastAmount.Text = setTxtLastAmount();
        }

        private void TxtFuelMoney_TextChanged(object sender, EventArgs e)
        {
            txtLastAmount.Text = setTxtLastAmount();
        }

        private void TxtAvance_TextChanged(object sender, EventArgs e)
        {
            txtLastAmount.Text = setTxtLastAmount();
        }

        private void TxtCommonCost_TextChanged(object sender, EventArgs e)
        {
            txtLastAmount.Text = setTxtLastAmount();
        }

        private void TxtSpecialCost_TextChanged(object sender, EventArgs e)
        {
            txtLastAmount.Text = setTxtLastAmount();
        }
    }
}
