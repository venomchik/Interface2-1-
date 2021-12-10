namespace Interface2_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ContextMenuStrip = contextMenuStrip2;
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (messageToolStripMenuItem1.Enabled == false)
            {
                messageToolStripMenuItem1.Enabled = true;
                checkToolStripMenuItem.Checked = false;
            }
            else
            {

                messageToolStripMenuItem1.Enabled = false;
                checkToolStripMenuItem.Checked = true;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("v0.0.0.1.0");
        }

        private void showTableToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (tableToolStripMenuItem.Enabled == false)
            {
                tableToolStripMenuItem.Enabled = true;
                showTableToolStripMenuItem.Checked = true;
            }
            else
            {

                tableToolStripMenuItem.Enabled = false;
               showTableToolStripMenuItem.Checked = false;
            }
        }

        private void contextMenuStrip2_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        
    }
}
