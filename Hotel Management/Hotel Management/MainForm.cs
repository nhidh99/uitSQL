using System.Drawing;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();
            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void simpleButton3_Click(object sender, System.EventArgs e)
        {
            var EditForm = new EditFormListRooms();
            EditForm.Show();
        }

        private void simpleButton7_Click(object sender, System.EventArgs e)
        {
            var EditForm = new EditFormRoom();
            EditForm.Show();
        }

        private void simpleButton16_Click(object sender, System.EventArgs e)
        {
            var EditForm = new EditFormMaxCustomers();
            EditForm.Show();
        }

        private void simpleButton17_Click(object sender, System.EventArgs e)
        {
            var EditForm = new EditFormAdditionPrice();
            EditForm.Show();
        }

        private void simpleButton21_Click(object sender, System.EventArgs e)
        {
            var EditForm = new EditFormRoomTypes();
            EditForm.Show();
        }

        private void btnEditCustomer_2_Click(object sender, System.EventArgs e)
        {
            var EditForm = new EditFormCustomer();
            EditForm.Show();
        }

        private void btnEditCustomerType_6_Click(object sender, System.EventArgs e)
        {
            var EditForm = new EditFormCustomerTypes();
            EditForm.Show();
        }
    }
}
