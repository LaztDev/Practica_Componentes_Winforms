namespace Listas_Visuales {
    public partial class Form1 : Form {

        List<Producto> producto = new List<Producto>();

        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {

        }
        private void btnCargar_Click(object sender, EventArgs e) {
            string nombre = textBoxNombre.Text;
            string precio = textBoxPrecio.Text;
            string stock = textBoxStock.Text;

            validarDatos(nombre, precio, stock);

        }
        private void validarDatos(string nom, string prec, string stoc) {
            string nombre = nom;
            decimal precio;
            int stock;
            try {
                string.IsNullOrWhiteSpace(nombre);
                precio = decimal.Parse(prec);
                stock = int.Parse(stoc);
            }
            catch {
                MessageBox.Show("Error al cargar los campos", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                return;
            }
            Producto produ = new Producto(nombre, precio, stock);

            producto.Add(produ);


        }


    }
}
