namespace tetris
{
    public partial class mainForm : Form
    {
        Shape currentShape;

        int size;
        int[,] map = new int[16, 8];

        public mainForm()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            size = 25;

            currentShape = new Shape(3, 0);

            this.KeyUp += new KeyEventHandler(keyFunc);

            mainTimer.Interval = 1000;
            mainTimer.Tick += new EventHandler(update);
            mainTimer.Start();

            Invalidate();
        }

        private void keyFunc(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    break;

                case Keys.Left:
                    ClearArea();
                    currentShape.MoveLeft();
                    Merge();
                    Invalidate();
                    break;

                case Keys.Right:
                    ClearArea();
                    currentShape.MoveRight();
                    Merge();
                    Invalidate();
                    break;
            }
        }

        private void update(object sender, EventArgs e) { 

            ClearArea();
            currentShape.MoveDown(); 
            Merge(); 
            Invalidate(); 
        }

        public void Merge()
        {
            for (int i = currentShape.y; i < currentShape.y + currentShape.matrixSize; i++)
                for (int j = currentShape.x; j < currentShape.x + currentShape.matrixSize; j++)
                {
                    if (currentShape.matrix[i - currentShape.y, j - currentShape.x] != 0)
                        map[i, j] = currentShape.matrix[i - currentShape.y, j - currentShape.x];
                }
        }

        public void ClearArea()
        {
            for (int i = currentShape.y; i < currentShape.y + currentShape.matrixSize; i++)
                for (int j = currentShape.x; j < currentShape.x + currentShape.matrixSize; j++)
                {
                    if (i >= 0 && j >= 0 && i < 16 && j < 8)
                        map[i, j] = 0;
                }
        }

        public void DrawMap(Graphics graphics)
        {
            for (int i = 0; i < 16; i++)
                for (int j = 0; j < 8; j++)
                {
                    if (map[i, j] == 1) graphics.FillRectangle(Brushes.Red, new Rectangle(50 + j * size + 1, 50 + i * size + 1, size - 1, size - 1));
                }
        }

        public void DrawGrid(Graphics graphics)
        {
            for (int i = 0; i <= 16; i++)
                graphics.DrawLine(Pens.Black, new Point(50, 50 + i * size), new Point(50 + 8 * size, 50 + i * size));

            for (int i = 0; i <= 8; i++)
                graphics.DrawLine(Pens.Black, new Point(50 + i * size, 50), new Point(50 + i * size, 50 + 16 * size));
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            DrawGrid(e.Graphics);
            DrawMap(e.Graphics);
        }
    }
}
