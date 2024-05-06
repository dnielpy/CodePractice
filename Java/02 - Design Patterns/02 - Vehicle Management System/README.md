# Vehicle Management System 🚗🔧

Welcome to the Vehicle Management System! Let's build a practical project to practice the Factory design pattern in Java. Buckle up, and let's hit the road! 🛣️

## Requirements 📝

### Functionalities

1. **Create New Vehicles**:
   - Users should be able to create new vehicles (cars, motorcycles, trucks)
   - Imagine users assembling their dream vehicles! 🚘🛵🚚

2. **Process Vehicles**:
   - Once a vehicle is created, the system should calculate the manufacturing cost and generate an invoice.
   - We'll crunch the numbers and ensure accurate billing! 💰🧾

3. **View Vehicle List**:
   - Users should have access to a list of all created vehicles.
   - Each vehicle's status (processed or unprocessed) should be clearly visible.
   - Imagine a dashboard where users can track their vehicle orders. 📊🚛

### Non-Functional Requirements 🛠️

1. **Factory Design Pattern**:
   - We'll utilize the **Factory design pattern** to create objects of different vehicle types.
   - This pattern will allow us to encapsulate object creation logic and maintain code flexibility. 🏭🔍

2. **User Interface**:
   - Our system will provide a straightforward user interface (e.g., a command-line interface).
   - Let's keep it simple and user-friendly! 🖥️👤

### Additional Specifications 🌟

1. **Vehicle Types**:
   - Coche (Car): Standard manufacturing cost and production time.
   - Moto (Motorcycle): Lower manufacturing cost and faster production time.
   - Camión (Truck): Higher manufacturing cost and longer production time.
   - Imagine a bustling vehicle assembly line! 🏭🚛🏍️

2. **Invoice Generation**:
   - Invoices should include:
     - Vehicle number
     - Manufacturing date
     - Total cost
   - Imagine beautifully formatted invoices arriving in customers' mailboxes. 📮💼

## Implementation Steps 🛠️

1. Create a `Vehicle` interface defining the necessary methods for creating, processing, and viewing vehicles.
2. Implement concrete classes (`Car`, `Motorcycle`, `Truck`) that adhere to the `Vehicle` interface.
3. Create a `Factory` class responsible for creating instances of the concrete vehicle classes based on the specified vehicle type.
4. Develop a `Main` class containing the user interface menu and handling user input.
