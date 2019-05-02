

namespace WindowsFormsApp1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            BackColor =
               System.Drawing.Color.FromArgb
               (red: redHScrollBar.Value, green: greenHScrollBar.Value, blue: blueHScrollBar.Value);

        }

        private void HScrollBar_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            BackColor =
                System.Drawing.Color.FromArgb
                (red: redHScrollBar.Value, green: greenHScrollBar.Value, blue: blueHScrollBar.Value);
        }

       
    }
}
