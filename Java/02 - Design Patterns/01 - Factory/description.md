# Orders Management System 📦🚚

Welcome to the Orders Management System! Let's dive into the specifics of this exciting capstone project. 🎉

## Objective 🎯

The primary goal of this project is to develop an order management system for an online store. Our system will empower users to create and process different types of orders, including regular, rush, and international orders.

## Functional Requirements 📝

1. **Order Creation**:
   - Users should be able to create new orders by specifying the order type (regular, rush, or international), requested products, and quantities.
   - Imagine a user excitedly adding items to their virtual shopping cart!

2. **Order Processing**:
   - Once an order is created, the system should calculate the total order cost and generate an invoice.
   - We'll crunch the numbers and make sure everything adds up correctly!

3. **Order Viewing**:
   - Users should have access to a list of all created orders.
   - Each order's status (processed or unprocessed) should be clearly visible.
   - Imagine a dashboard where users can keep track of their orders.

## Non-Functional Requirements 🛠️

1. **Design Pattern**:
   - We'll employ the **Factory design pattern** to create objects of different order types.
   - This pattern will help us encapsulate object creation logic and keep our code clean.

2. **User Interface**:
   - Our system will provide a user-friendly interface.
   - Whether it's a sleek command line or a snazzy graphical user interface, we'll make it easy for users to interact with the system.

3. **Robustness**:
   - Our system will handle various user inputs and use cases gracefully.
   - No crashing allowed—our code will be as sturdy as a well-built shipping crate!

## Additional Specifications 🌟

1. **Order Types**:
   - Regular Order: Standard shipping cost and delivery time.
   - Rush Order: Higher shipping cost but lightning-fast delivery.
   - International Order: Higher shipping cost due to customs, with a longer delivery time.
   - Imagine a global marketplace with orders zipping across borders!

2. **Total Cost Calculation**:
   - The total order cost will be the sum of the requested products' costs and the shipping cost based on the order type.
   - We'll crunch those numbers like seasoned accountants!

3. **Invoice Generation**:
   - Invoices will include:
     - Order number
     - Order date
     - Requested products
     - Total cost
