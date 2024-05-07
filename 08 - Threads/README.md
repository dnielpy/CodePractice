## Concurrent API for Fast Data Retrieval 🚀

### Story 📚

Imagine you are a developer working on an e-commerce application that needs to fetch product information from a third-party vendor API. The vendor provides three pieces of data for each product: price, availability, and delivery time.

The challenge is that the vendor's API is slow and returns the data at different times. The price is returned immediately, the availability is returned after 1 second, and the delivery time is returned after 2 seconds.

Your objective is to design and implement a concurrent API that retrieves this three pieces of data as fast as possible. The API must leverage concurrency to fetch the data in parallel and return it to the client at the earliest possible time.

### Requirements 🛠️

- Concurrent API: An API that leverages concurrency to fetch data from the vendor API in parallel.
- Threads: Threads that concurrently fetch data from the vendor API.
- Results Queue: A concurrent queue to store the results returned by the threads.

### Steps 👣

1. Create a concurrent API that accepts requests for product data.
2. Create threads that concurrently fetch data from the vendor API.
3. Use a results queue to store the results returned by the threads.
4. Once all three results are received, the concurrent API returns the data to the client.