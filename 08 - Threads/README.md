## Concurrent Counter 🚀

**Description:** 🔢

Develop a Java program that uses threads to implement a concurrent counter. The counter should allow multiple threads to increment and decrement its value safely.

**Requirements:** 📈

- Create two classes: Counter and Thread. 
- The Counter class should contain the following methods: 
    - increment(): Increments the counter's value. 
    - decrement(): Decrements the counter's value. 
    - getValue(): Returns the current value of the counter. 
- The Thread class should extend the Thread class and implement the run() method. 
- The run() method should repeatedly call the increment() and decrement() methods of the counter. 

**Implementation:** 🔒

- Use the synchronized class to synchronize access to the counter. 
- Create multiple Thread threads and run them concurrently. 
- Use the getValue() method to print the value of the counter periodically. 📊