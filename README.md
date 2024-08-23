● ¿Cuál de estas relaciones considera que se realiza por composición y cuál por agregación?
Composicion es el caso del Pedido Cliente, ya que si no hay clientes, no habra pedidos
Todos los demas casos son por Agregacion

● ¿Qué métodos considera que debería tener la clase Cadetería y la clase Cadete?
La clase Cadeteria podria tener un metodo que retorne la cantidad de pedidos entregados por dia, o el salario designado en cadetes.
La clase Cadete podria tener un metodo que determine su calificacion, recolectando la puntuacion de los clientes.

● Teniendo en cuenta los principios de abstracción y ocultamiento, que atributos, propiedades y métodos deberían ser públicos y cuáles privados.
Todos los atributos de las clases deben ser privadas, asi no puedan ser accedidas de cualquier lugar. Lo que si puede ser publico, son los metodos.

● ¿Cómo diseñaría los constructores de cada una de las clases?
El constructor de la clase cadeteria podria ir vacio o con nombre y direccion, en la clase cadete con los datos personales del cadete mientras que el ID se inicializa solo y la lista de pedidos igual, en la clase pedidos se le puede pasar el cliente en el constructor y en la clase cliente pueden ser todos los datos

● ¿Se le ocurre otra forma que podría haberse realizado el diseño de clases?
Si, podria agregar en la clase de pedido, un campo que haga referencia al cadete encargado de ese pedido.
En la clase de cadete, quitar el atributo de listadoPedidos pero poner algo que cuente la cantidad de pedidos entrego.
La clase cliente tambien podemos introducirla en la clase de pedidos.
