using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.DTO
{
    public class Driver
    {
       
        private string ID;
        private string Name;
        private string CMND;
        private string Gender;
        private DateTime DoB;
        private string Phone;
        private string NoMoto;
        private string Area;
        private string Email;
        private string Bank;
        private float Income;
        private string[] Addr;
        private string Login;
        private string Pass;
        private int StatusAcc;

        public Driver()
        {
            ID1 = "";
            Name = "";
            CMND = "";
            Gender1 = "";
            DoB = DateTime.Now;
            Phone = "";
            NoMoto = "";
            Area = "";
            Email = "";
            Bank1 = "";
            Income = 0;
            Addr = defautA();
            Login = "";
            Pass = "";
            StatusAcc = 0;
        }
        public static string[] defautA()
        {
            string c = "default";
            string[] s = { c, c, c, c, c };
            return s;
        }
        public Driver(string iD, string name, string cMND, string gender, DateTime doB, string phone, string noMoto, string area, string email, string bank, float income, string[] addr, string login, string pass, int statusAcc)
        {
            ID1 = iD;
            Name = name;
            CMND = cMND;
            Gender1 = gender;
            DoB = doB;
            Phone = phone;
            NoMoto = noMoto;
            Area = area;
            Email = email;
            Bank1= bank;
            Income = income;
            Addr = addr;
            Login = login;
            Pass = pass;
            StatusAcc = statusAcc;
        }
        public Driver(DataRow row)
        {
            this.ID1 = (string)row["MaTX"];
            this.Area = (string)row["KhuVucHoatDong"];
            this.Name = (string)row["TenTX"];
            this.CMND = (string)row["CMND"];
            this.Gender1 = (string)row["CMND"];
            this.DoB = (DateTime)row["NgaySinh"];
            this.Phone = (string)row["SDT_TX"];
            this.NoMoto = (string)row["BienSoXe"];
            this.Email = (string)row["Email_TX"];
            this.Bank1 = (string)row["TKNganHang"];
            var income = Convert.ToDecimal(row["ThuNhap"]);
            this.Income = (float)income;
            this.Addr = Driver.CovertToAddress(row);
            this.Gender = (string)row["GioiTinh"];
            string value1=row.Field<string>(1);
            this.Login = value1;
            string value2 = row.Field<string>(2);
            this.Pass = value2;
            
        }
        public static string[] CovertToAddress(DataRow row)
        {
            int No;
            string street, ward, district, city;
            No = (int)row["SoNha_TX"];
            if (row["Duong_TX"]== DBNull.Value)
            {
                street = "default";
            }
            else
            {
                street = (string)row["Duong_TX"];
            }
            
            ward= (string)row["Phuong_TX"];
            district= (string)row["Quan_TX"];
            city= (string)row["ThanhPho_TX"];
            string[] r = { No.ToString(), street.ToString(), ward.ToString(), district.ToString(), city.ToString() };
            return r;
        }

        public string GetStatusAcc1()
        {
            return ID1;
        }

        public void SetStatusAcc1(string value)
        {
            ID1 = value;
        }

        public string Name1 { get => Name; set => Name = value; }
        public string CMND1 { get => CMND; set => CMND = value; }
        public DateTime DoB1 { get => DoB; set => DoB = value; }
        public string Phone1 { get => Phone; set => Phone = value; }
        public string NoMoto1 { get => NoMoto; set => NoMoto = value; }
        public string Area1 { get => Area; set => Area = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Bank1 { get => Bank; set => Bank = value; }
        public float Income1 { get => Income; set => Income = value; }
        public string[] Addr1 { get => Addr; set => Addr = value; }
        public string Gender1 { get => Gender; set => Gender = value; }
        public string Login1 { get => Login; set => Login = value; }
        public string Pass1 { get => Pass; set => Pass = value; }
        public int StatusAcc1 { get => StatusAcc; set => StatusAcc = value; }
        public string ID1 { get => ID; set => ID = value; }
    }
}
