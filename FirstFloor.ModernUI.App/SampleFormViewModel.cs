using FirstFloor.ModernUI.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstFloor.ModernUI.App
{
    public class SampleFormViewModel
        : NotifyPropertyChanged, IDataErrorInfo
    {
        private string fName;
        private string Regid;
        private string uname;
        private string contact;
        private string email;
        private string spec;
        private string deg;
        private string mname;
        private string cname;
        private string comn;
        private string gardname;

        private string pname;
        private string pid;
        private string dnhod;
        private string dihod;
        private string dass;
        private string nur;



        public string P_name
        {
            get { return this.pname; }
            set
            {
                if (this.pname != value)
                {
                    this.pname = value;
                    OnPropertyChanged("P_name");
                }
            }
        }

        public string P_id
        {
            get { return this.pid; }
            set
            {
                if (this.pid != value)
                {
                    this.pid = value;
                    OnPropertyChanged("P_id");
                }
            }
        }


        public string dhod
        {
            get { return this.dnhod; }
            set
            {
                if (this.dnhod != value)
                {
                    this.dnhod = value;
                    OnPropertyChanged("dhod");
                }
            }
        }


        public string di_hod
        {
            get { return this.dihod; }
            set
            {
                if (this.dihod != value)
                {
                    this.dihod = value;
                    OnPropertyChanged("di_hod");
                }
            }
        }


        public string d_ass
        {
            get { return this.dass; }
            set
            {
                if (this.dass != value)
                {
                    this.dass = value;
                    OnPropertyChanged("d_ass");
                }
            }
        }

        public string nurse
        {
            get { return this.nur; }
            set
            {
                if (this.nur != value)
                {
                    this.nur = value;
                    OnPropertyChanged("nurse");
                }
            }
        }

        public string Common
        {
            get { return this.comn; }
            set
            {
                if (this.comn != value)
                {
                    this.comn = value;
                    OnPropertyChanged("Common");
                }
            }
        }

        public string ganame
        {
            get { return this.gardname; }
            set
            {
                if (this.gardname != value)
                {
                    this.gardname = value;
                    OnPropertyChanged("ganame");
                }
            }
        }


        public string FullName
        {
            get { return this.fName; }
            set
            {
                if (this.fName != value) {
                    this.fName = value;
                    OnPropertyChanged("FullName");
                }
            }
        }

        public string RegistrationId
        {
            get { return this.Regid; }
            set
            {
                if (this.Regid != value) {
                    this.Regid = value;
                    OnPropertyChanged("RegistrationId");
                }
            }
        }

        public string UserName
        {
            get { return this.uname; }
            set
            {
                if (this.uname != value)
                {
                    this.uname = value;
                    OnPropertyChanged("UserName");
                }
            }
        }

        public string ContactNo
        {
            get { return this.contact; }
            set
            {
                if (this.contact != value)
                {
                    this.contact = value;
                    OnPropertyChanged("ContactNo");
                }
            }
        }


        public string EmailId
        {
            get { return this.email; }
            set
            {
                if (this.email != value)
                {
                    this.email = value;
                    OnPropertyChanged("EmailId");
                }
            }
        }

        public string Specilization
        {
            get { return this.spec; }
            set
            {
                if (this.spec != value)
                {
                    this.spec = value;
                    OnPropertyChanged("Specilization");
                }
            }
        }


        public string Designation
        {
            get { return this.deg; }
            set
            {
                if (this.deg != value)
                {
                    this.deg = value;
                    OnPropertyChanged("Designation");
                }
            }
        }

        public string MedicineName
        {
            get { return this.mname; }
            set
            {
                if (this.mname != value)
                {
                    this.mname = value;
                    OnPropertyChanged("MedicineName");
                }
            }
        }

        public string CompanyName
        {
            get { return this.cname; }
            set
            {
                if (this.cname != value)
                {
                    this.cname = value;
                    OnPropertyChanged("CompanyName");
                }
            }
        }

        



        public string Error
        {
            get { return null; }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "FullName") {
                    return string.IsNullOrEmpty(this.fName) ? " Full Name Required " : null;
                }
                if (columnName == "RegistrationId") {
                    return string.IsNullOrEmpty(this.Regid) ? "RegistrationId Required " : null;
                }
                if (columnName == "UserName")
                {
                    return string.IsNullOrEmpty(this.uname) ? " UserName Required" : null;
                }
                if (columnName == "ContactNo")
                {
                    return string.IsNullOrEmpty(this.contact) ? " ContactNo Required (10 digit)" : null;
                }
                if (columnName == "EmailId")
                {
                    return string.IsNullOrEmpty(this.email) ? "EmailId  Required " : null;
                }
                if (columnName == "Specilization")
                {
                    return string.IsNullOrEmpty(this.spec) ? "Specilization Required " : null;
                }
                if (columnName == "Designation")
                {
                    return string.IsNullOrEmpty(this.deg) ? " Designation Required" : null;
                }
                if (columnName == "MedicineName")
                {
                    return string.IsNullOrEmpty(this.mname) ? "MedicineName  Required" : null;
                }
                if (columnName == "CompanyName")
                {
                    return string.IsNullOrEmpty(this.cname) ? "CompanyName Required" : null;
                }
                if (columnName == "Common")
                {
                    return string.IsNullOrEmpty(this.comn) ? "Required value" : null;
                }
                if (columnName == "ganame")
                {
                    return string.IsNullOrEmpty(this.gardname) ? "Gardian Name Required" : null;
                }

                if (columnName == "nurse")
                {
                    return string.IsNullOrEmpty(this.nur) ? "Nurse Name" : null;
                }
                if (columnName == "d_ass")
                {
                    return string.IsNullOrEmpty(this.dass) ? "Assistant Doctor Name" : null;
                }
                if (columnName == "di_hod")
                {
                    return string.IsNullOrEmpty(this.dihod) ? "Head Doctor id" : null;
                }
                if (columnName == "dhod")
                {
                    return string.IsNullOrEmpty(this.dnhod) ? "Head Doctor Name" : null;
                }
                if (columnName == "P_id")
                {
                    return string.IsNullOrEmpty(this.pid) ? "Patient Id" : null;
                }
                if (columnName == "P_name")
                {
                    return string.IsNullOrEmpty(this.pname) ? "Patient Name" : null;
                }
                return null;
            }
        }
    }



}
