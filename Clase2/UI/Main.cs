using BLL.BussinesEntite;

namespace UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CursosBE curso = new CursosBE();
        }
    }
}
