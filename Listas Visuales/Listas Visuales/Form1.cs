namespace Listas_Visuales {
    public partial class Form1 : Form {

        List<Producto> producto = new List<Producto>();

        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {

        }
        private void btnCargar_Click(object sender, EventArgs e) {
            // recibimos los campos del formulario
            string nombre = textBoxNombre.Text;
            string precio = textBoxPrecio.Text;
            string stock = textBoxStock.Text;

            //validamos los datos del formulario
            validarDatos(nombre, precio, stock);
        }
        private void validarDatos(string nom, string prec, string stoc) {
            string nombre;
            decimal precio;
            int stock;
            // intentamos hacer la conversion y captura el error con trycatch
            try { //try (intenta)
                nombre = string.IsNullOrWhiteSpace(nom) ? throw new ArgumentException("Nombre no puede estar vacio") : nom;
                if (decimal.TryParse(prec, out precio) && precio >= 0) {
                }
                else {
                    throw new ArgumentException("el precio debe ser un decimal mayor a cero");
                }
                if (int.TryParse(stoc, out stock) && stock >= 0) {
                }
                else {
                    throw new ArgumentException("el precio debe ser un entero mayor o igual a cero"); //excepcion de argumento que tiramos al escucha del trycatch
                }
            }
            catch (Exception ex) { // catch (captura si el intento falla)   ex es la excepcion que tiramos
                MessageBox.Show($"Error al cargar los campos \n({ex.Message})", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);//ex.messasge muestra el mensaje qeu tiramos en el try
                return;
            }
            //instanciamos un prod. en caso de pasar el trycatch
            Producto produ = new Producto(nombre, precio, stock);

            if (producto.Count() == 0) { //agregamos sin preguntar su existencia en base al largo de la lista
                producto.Add(produ); //añadimos a la lista producto el objjeto produ creado despue del catch
                // a la lista de checklist le agregamos un item
                // los checklist muestran Items, con .add añadimos items, 
                // los "items" que se añaden son solo texto del tipo string, 
                chekListBxProductos.Items.Add($"{produ.Nombre}  -   Precio: ${produ.Precio}  -  Stock: {produ.Stock}"); // añadimos un item mostrando nombre precio stock del producto de la lista
                limpiarCampos(); // dejamos limpios los campos del formulario
            }
            else {
                for (int i = 0; i < producto.Count(); i++) { // recorremos la lista de productos y comparamos si el nuevo producto cargado ya existe 
                    if (producto[i].Nombre == produ.Nombre) {
                        MessageBox.Show("El producto ya existe", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); //tira un mensaje de error si existe el producto
                    }
                }
                //añadimos a la lista el nuevo producto si no existe 
                producto.Add(produ);
                //actualizamos el checklist agregando un nuevo Elemento con las prop. de produ
                chekListBxProductos.Items.Add($"{produ.Nombre}  -   Precio: ${produ.Precio}  -  Stock: {produ.Stock}");
                // metodod e actualizar
                limpiarCampos();
            }
        }
        private void limpiarCampos() {
            textBoxNombre.Text = "";
            textBoxPrecio.Text = "";
            textBoxStock.Text = "";
        }
        private void button1_Click(object sender, EventArgs e) {
            foreach (string item in chekListBxProductos.CheckedItems) {
                foreach (Producto produ in producto) { 
                    if (produ.ToString() == item) {
                        producto.Remove(produ);
                        chekListBxProductos.Items.Remove(item);
                        return;
                    }
                }
            }
        }
    }
}
