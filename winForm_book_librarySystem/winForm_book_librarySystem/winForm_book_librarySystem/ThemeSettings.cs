using System.Drawing;
using System.Windows.Forms;

namespace winForm_book_librarySystem
{
    public static class ThemeSettings
    {
        public static Color DarkNavy = Color.FromArgb(10, 25, 47);
        public static Color Gold = Color.FromArgb(218, 165, 32);
        public static Color LightGray = Color.FromArgb(204, 214, 246);
        public static Color White = Color.White;
        public static Color ButtonText = Color.Black;
        public static Color InputBackground = Color.FromArgb(17, 34, 64);

        public static void ApplyTheme(Form form)
        {
            form.BackColor = DarkNavy;
            form.ForeColor = LightGray;

            ApplyToControls(form.Controls);
        }

        private static void ApplyToControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = Gold;
                    btn.ForeColor = ButtonText;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Font = new Font(btn.Font, FontStyle.Bold);
                }
                else if (control is Label lbl)
                {
                    lbl.ForeColor = LightGray;
                    lbl.BackColor = Color.Transparent;
                }
                else if (control is TextBox txt)
                {
                    txt.BackColor = InputBackground;
                    txt.ForeColor = White;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (control is DataGridView dgv)
                {
                    dgv.BackgroundColor = DarkNavy;
                    dgv.DefaultCellStyle.BackColor = InputBackground;
                    dgv.DefaultCellStyle.ForeColor = White;
                    dgv.DefaultCellStyle.SelectionBackColor = Gold;
                    dgv.DefaultCellStyle.SelectionForeColor = ButtonText;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Gold;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = ButtonText;
                    dgv.EnableHeadersVisualStyles = false;
                    dgv.RowHeadersVisible = false;
                    dgv.BorderStyle = BorderStyle.None;
                }
                else if (control is ComboBox cmb)
                {
                    cmb.BackColor = InputBackground;
                    cmb.ForeColor = White;
                    cmb.FlatStyle = FlatStyle.Flat;
                }
                else if (control is NumericUpDown num)
                {
                    num.BackColor = InputBackground;
                    num.ForeColor = White;
                    num.BorderStyle = BorderStyle.FixedSingle;
                }
                
                if (control.HasChildren)
                {
                    ApplyToControls(control.Controls);
                }
            }
        }
    }
}
