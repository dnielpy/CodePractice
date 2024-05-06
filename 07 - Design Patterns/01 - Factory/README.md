## Factory 🎯

## What is it?

A factory design pattern is a creational design pattern that provides an interface for creating objects in a manner that is independent of the actual creation code. It basically allows us to create objects without specifying the concrete class of the objects that will be created.

## When to use it? 📝

- Multiple classes of products (objects) are required that share a common interface.
- Object creation code is complex or subject to frequent change.
- You want to decouple the object creation code from client code.
- You want to provide a unified interface for creating different types of objects.

## Steps to implement it 🛠

1. Define a product interface that specifies the common functionality of all products.
2. Create concrete product classes that implement the product interface.
3. Define a factory interface that declares the method to create products.
4. Create concrete factory classes that implement the factory interface and use the product classes to create objects.
5. Client code only interacts with the factory interface to create products.

## Advantages of using it over not using it 🌟

- Increased flexibility: Allows for the creation of different types of objects without modifying client code.
- Increased extensibility: New product or factory classes can be added without affecting existing code.
- Increased decoupling: Object creation code is separated from client code, improving maintainability and concurrency.
- Centralized creation: All objects are created through a central interface, simplifying control and dependency management.
- Simplicity: Client code only needs to interact with one factory interface instead of a variety of product classes.