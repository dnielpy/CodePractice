# Orders Manage System

Specific and Clear Requirements for Order Management Capstone Project:

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
