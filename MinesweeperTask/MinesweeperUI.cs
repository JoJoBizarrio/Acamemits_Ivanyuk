namespace MinesweeperTask
{
    public partial class MinesweeperUI : Form
    {
        public MinesweeperUI()
        {
            InitializeComponent();

            // FieldTableLayoutPanel.ColumnStyles.Add(new Button());
            
            Button button12314 = new Button();
            FieldTableLayoutPanel.SetColumn(button12314, 1);
            FieldTableLayoutPanel.Controls.Add(button12314, 1, 1);
            button12314.Dock = DockStyle.Fill;
            button12314.BackColor = FieldTableLayoutPanel.BackColor;
            Image mineImage = Image.FromFile("..\\mine.png");
            button12314.BackgroundImage = mineImage;
            button12314.BackgroundImageLayout = ImageLayout.Stretch;
            button12314.Enabled = false;
        }

        public void DrawLinesPoint(PaintEventArgs e)
        {
            // Create pen.
            Pen pen = new Pen(Color.Black, 3);

            // Create array of points that define lines to draw.
            Point[] points =
                     {
                 new Point(10,  10),
                 new Point(10, 100),
                 new Point(200,  50),
                 new Point(250, 300)
             };

            //Draw lines to screen.
            e.Graphics.DrawLines(pen, points);
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            {
                g.DrawLine(Pens.Black, new Point(0, 0), new Point(20, 100));
                g.DrawLine(Pens.Black, new Point(20, 100), new Point(250, 100));
            }

            //Image image = new Bitmap("..\\mine.png");
            //button1.Image = Image.FromFile("..\\mine.png");

            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.RowCount = 9;
            tableLayoutPanel.ColumnCount = 9;
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel.BackColor = Color.Black ;
            tableLayoutPanel.Enabled = true;

        }

        private void MinesweeperUI_Load(object sender, EventArgs e)
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.RowCount = 9;
            tableLayoutPanel.ColumnCount = 9;
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel.BackColor = Color.Black;
            tableLayoutPanel.CreateControl();
            tableLayoutPanel.Show();
            tableLayoutPanel.Enabled = true;
        }

        //private void button1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    Image mineImage = Image.FromFile("..\\mine.png");
        //    Image flagImage = Image.FromFile("..\\flag.png");
                

        //    if (e.Button == MouseButtons.Right)
        //    {
        //        button1.BackgroundImage = flagImage;
        //        button1.BackgroundImageLayout = ImageLayout.Stretch;
        //        button1.Text = "";
        //    }

        //    if (button1.BackgroundImage.Size != flagImage.Size & e.Button == MouseButtons.Left)
        //    {
        //        button1.BackgroundImage = mineImage;
        //        button1.BackgroundImageLayout = ImageLayout.Stretch;
        //        button1.Text = "";
        //    }
        //}

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        public void Open(Minesweeper minesweeper, int x, int y)
        {
            if (minesweeper.MinesweeperArrayRepresentation[x, y] == 0)
            {

            }
        }
    }
}