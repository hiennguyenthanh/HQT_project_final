using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.DTO
{
    public class Contract
    {
        private string ContractID;
        private string StaffID;
        private string SupplierID;
        private string CodeTax;
        private string Represent;
        private int NBranchRegister;
        private float CFee;
        private int CPercent;
        private DateTime CBegin ;
        private DateTime CEnd;

        public Contract(string contractID, string staffID, string supplierID, string codeTax, string represent, int nBranchRegister, float cFee, int cPercent, DateTime cBegin, DateTime cEnd)
        {
            ContractID = contractID;
            StaffID = staffID;
            SupplierID = supplierID;
            CodeTax = codeTax;
            Represent = represent;
            NBranchRegister = nBranchRegister;
            CFee = cFee;
            CPercent = cPercent;
            CBegin = cBegin;
            CEnd = cEnd;
        }
        public Contract(DataRow row)
        {
            if (row["MAHD"] == DBNull.Value)
            {
                this.ContractID = "";
            }
            else
            {
                this.ContractID = (string)row["MAHD"];
            }
            if (row["MANV"] == DBNull.Value)
            {
                this.StaffID = "";
            }
            else
            {
                this.StaffID = (string)row["MANV"];
            }
            if (row["MADT"] == DBNull.Value)
            {
                this.SupplierID = "";
            }
            else
            {
                this.SupplierID = (string)row["MADT"];
            }
            if (row["MASOTHUE_HD"] == DBNull.Value)
            {
                this.CodeTax = "";
            }
            else
            {
                this.CodeTax = (string)row["MASOTHUE_HD"];
            }
            if (row["NGUOIDAIDIEN_HD"] == DBNull.Value)
            {
                this.Represent = "";
            }
            else
            {
                this.Represent = (string)row["NGUOIDAIDIEN_HD"];
            }
            if (row["SOCHINHANHDK"] == DBNull.Value)
            {
                this.NBranchRegister = 0;
            }
            else
            {
                this.NBranchRegister = (int)row["SOCHINHANHDK"];
            }
            if (row["PHIKICHHOAT"] == DBNull.Value)
            {
                this.CFee = 0;
            }
            else
            {
                this.CFee = (float)row["PHIKICHHOAT"];
            }
            if (row["PHANTRAMHOAHONG"] == DBNull.Value)
            {
                this.CPercent = 0;
            }
            else
            {
                this.CPercent = (int)row["PHANTRAMHOAHONG"];
            }
            if (row["NGAYBATDAU"] == DBNull.Value)
            {
                this.CBegin = DateTime.Now;
            }
            else
            {
                this.CBegin = (DateTime)row["NGAYBATDAU"];
            }
            if (row["NGAYKETTHUC"] == DBNull.Value)
            {
                this.CEnd = DateTime.Now;
            }
            else
            {
                this.CEnd = (DateTime)row["NGAYKETTHUC"];
            }

        }
      
        public string ContractID1 { get => ContractID; set => ContractID = value; }
        public string StaffID1 { get => StaffID; set => StaffID = value; }
        public string SupplierID1 { get => SupplierID; set => SupplierID = value; }
        public string CodeTax1 { get => CodeTax; set => CodeTax = value; }
        public string Represent1 { get => Represent; set => Represent = value; }
        public int NBranchRegister1 { get => NBranchRegister; set => NBranchRegister = value; }
        public float CFee1 { get => CFee; set => CFee = value; }
        public int CPercent1 { get => CPercent; set => CPercent = value; }
        public DateTime CBegin1 { get => CBegin; set => CBegin = value; }
        public DateTime CEnd1 { get => CEnd; set => CEnd = value; }
    }
}
