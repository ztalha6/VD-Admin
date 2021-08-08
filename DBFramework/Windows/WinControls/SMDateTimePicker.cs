using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFramework.Windows.WinControls
{
    public partial class SMDateTimePicker : DateTimePicker
    {
        public SMDateTimePicker()
        {
            InitializeComponent();
        }

        public enum DataFormat
        {
            British,// dd/MM/yyyy
            British2,// dd-MM-yyyy
            British3,// dd/MM/yy
            US,// MM/dd/yyyy
            ANSI // yyyy.MM.dd

        }

        private DataFormat dateFormat = DataFormat.British;

        [Category("Custom Date")]
        [Description("British // dd/MM/yyyy, British2 dd-MM-yyyy, British3 dd/MM/yy, US MM/dd/yyyy, ANSI yyyy.MM.dd")]
        public DataFormat DateFormat
        {
            get { return dateFormat;  }
            set
            {
                dateFormat = value;
                if (!MakeEmpty)
                {
                    SetDateFormat();
                }
            }
        }

        private void SetDateFormat()
        {
            if (DateFormat == DataFormat.British)
            {
                this.CustomFormat = "dd/MM/yyyy";
            }
            if (DateFormat == DataFormat.British2)
            {
                this.CustomFormat = "dd-MM-yyyy";
            }
            if (DateFormat == DataFormat.British3)
            {
                this.CustomFormat = "dd/MM/yy";
            }
            if (DateFormat == DataFormat.US)
            {
                this.CustomFormat = "MM/dd/yyyy";
            }
            if (DateFormat == DataFormat.ANSI)
            {
                this.CustomFormat = "yyyy.MM.dd";
            }
        }

        private bool makeEmpty=false;


        [Category("Custom Date")]
        [Description("Make Control Empty")]
        public bool MakeEmpty 
        { 
            get { return makeEmpty; }
            set
            {
                makeEmpty = value;
                if (makeEmpty == true)
                {
                    CustomFormat = " ";
                    Format = DateTimePickerFormat.Custom;
                }
                if (makeEmpty == false)
                {
                    SetDateFormat();
                    Format = DateTimePickerFormat.Custom;
                }
            }
        }
        private void SMDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (MakeEmpty)
            {
                SetDateFormat();
            }
            
        }

        private void SMDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (MakeEmpty)
            {
                if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
                {
                    this.CustomFormat = " ";
                }
            }
            
        }

        [Browsable(false)]
        public new DateTimePickerFormat Format
        {
            get { return base.Format; }
            set
            {
                base.Format = value;
            }
        }

        [Browsable(false)]
        public new string CustomFormat
        {
            get { return base.CustomFormat; }
            set
            {
                base.CustomFormat = value;
            }
        }
    }
}
