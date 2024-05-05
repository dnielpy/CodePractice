Objective: Develop an order management system for an online store that enables users to create and process different types of orders (regular, rush, and international).

Functional Requirements:

• Order Creation: Users should be able to create new orders by specifying the order type (regular, rush, or international), requested products, and quantities.
• Order Processing: Users should be able to process orders, which involves calculating the total order cost and generating an invoice.
• Order Viewing: Users should be able to view a list of all created orders, along with their status (processed or unprocessed).

Non-Functional Requirements:

• Design Pattern: The system should utilize the Factory design pattern to create objects of different order types.
• User Interface: The system should provide a user interface (e.g., a command line or graphical user interface) that allows users to interact with the system.
• Robustness: The system should be robust and capable of handling various user input and use cases.

Additional Specifications:

• Order Types:
    * Regular Order: A regular order has a standard shipping cost and a standard delivery time.
    * Rush Order: A rush order has a higher shipping cost and a faster delivery time.
    * International Order: An international order has a higher shipping cost and a longer delivery time due to customs and other factors.
• Total Cost Calculation: The total order cost is calculated by summing the cost of the requested products and the shipping cost corresponding to the order type.
• Invoice Generation: Invoices should include the order number, order date, requested products, total cost, and shipping address.


-- Español--
Requisitos específicos y claros para el proyecto práctico del patrón Factory de gestión de pedidos:

Objetivo: Desarrollar un sistema de gestión de pedidos para una tienda online que permita a los usuarios crear y procesar diferentes tipos de pedidos (normales, urgentes e internacionales).

Requisitos funcionales:

• Creación de pedidos: Los usuarios deben poder crear nuevos pedidos especificando el tipo de pedido (normal, urgente o internacional), los productos solicitados y las cantidades.
• Procesamiento de pedidos: Los usuarios deben poder procesar los pedidos, lo que implica calcular el coste total del pedido y generar una factura.
• Visualización de pedidos: Los usuarios deben poder ver una lista de todos los pedidos creados, junto con su estado (procesado o no procesado).

Requisitos no funcionales:

• Patrón de diseño: El sistema debe utilizar el patrón de diseño Factory para crear objetos de diferentes tipos de pedidos.
• Interfaz de usuario: El sistema debe proporcionar una interfaz de usuario (por ejemplo, una línea de comandos o una interfaz gráfica de usuario) que permita a los usuarios interactuar con el sistema.
• Robustez: El sistema debe ser robusto y capaz de manejar diferentes tipos de entrada de usuario y casos de uso.

Especificaciones adicionales:

• Tipos de pedidos:
    * Pedido normal: Un pedido normal tiene un coste de envío estándar y un tiempo de entrega estándar.
    * Pedido urgente: Un pedido urgente tiene un coste de envío más alto y un tiempo de entrega más rápido.
    * Pedido internacional: Un pedido internacional tiene un coste de envío más alto y un tiempo de entrega más largo debido a las aduanas y otros factores.
• Cálculo del coste total: El coste total de un pedido se calcula sumando el coste de los productos solicitados y el coste de envío correspondiente al tipo de pedido.
• Generación de facturas: Las facturas deben incluir el número de pedido, la fecha del pedido, los productos solicitados, el coste total y la dirección de envío.