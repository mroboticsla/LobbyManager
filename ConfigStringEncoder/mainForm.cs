using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigStringEncoder
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private void btn_Encode_Click(object sender, EventArgs e)
        {
            txt_Encoded.Text = Base64Encode(Reverse(txt_ToEncode.Text));
        }

        private void btn_decode_Click(object sender, EventArgs e)
        {
            txt_Decoded.Text = Reverse(Base64Decode(txt_ToDecode.Text));
        }
    }
}
