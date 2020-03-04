using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            var request = new RequestInvoices();
            var result = await request.MakeRequestAsync("xxxx", "xxxx", "{0}");
            //Στο Πρώτο πεδίο θέλει το UserID, στο δεύτερο το Subscription
            // και στο τρίτο το Mark(από ότι καταλαβαίνω το Mark πρέπει να έχει να περιλαμβάνει { } )

            Cursor.Current = Cursors.Default;
            MessageBox.Show(result);
        }
        
    }
}