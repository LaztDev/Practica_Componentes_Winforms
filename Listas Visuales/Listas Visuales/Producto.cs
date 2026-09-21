
namespace Listas_Visuales;

public class Producto {
    private string _nombre = string.Empty;
    private int _stock;
    private decimal _precio;

    public string Nombre {
        get => _nombre;
        set { 
            if (string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException("El nombre no puede estar vacio");
            }
            _nombre = value;
        }
    }
    public int Stock {
        get => _stock;
        set { 
            if (value < 0) {
                throw new ArgumentException("el stock debe ser un entero mayor o igual a cero");
            }
            _stock = value;
        }
    }
    public decimal Precio {
        get => _precio;
        set {
            if (value < 0) {
                throw new ArgumentException("el precio debe ser un entero mayor a cero");
            }
            _precio = value;
        }
    }

    public Producto(string nombre, decimal precio, int stoc) {
        Nombre = nombre;
        Precio = precio;
        Stock = stoc;
    }



}
