namespace mdk_01._01
{
    public partial class Form1 : Form
    {
        private DataBase _data;
        public Form1()
        {
            InitializeComponent();
            _data = new DataBase();
            _data.InInitialize();
            data_class.DataSource= _data.classes.ToList();

        }

         
    }
}