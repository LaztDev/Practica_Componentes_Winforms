namespace Vista_Dinamica__Menu {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void Menu1_Click(object sender, EventArgs e) {
            CargarMenus(new Menu_1()); //llamamos al metodo cargar y le pasamos el objeto Menu_1
        }

        private void CargarMenus(UserControl vista) { // definimos que vista sera el objeto del tipo  user control
            VistasDeMenus.Controls.Clear();  // saca lo anterior del layout en blanco  (similar al console.Clear())
            vista.Dock = DockStyle.Fill;       // le aplicamos un Dock para que ocupe todo el contenedor del layout
            VistasDeMenus.Controls.Add(vista); //Añade al contenido del layout vista(que seria el objeto de usercontrol)
        }
    }
}
