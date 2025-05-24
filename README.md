*Abstract factory design pattern* 
**Client does not know which object to create.**
* **Client only interacts with the interface** (`IDataBaseConnection`), not with the concrete classes.
* **Concrete classes** (`SqlConnector`, `PostSqlConnector`) implement the interface, providing specific functionality (e.g., connecting to different types of databases).
* The **client class** (`DataBaseClient`) receives an instance of the interface type in its constructor.
* The **concrete class** to be used is passed into the client class in the **main method**.
* The **internal working of the object** (like database-specific logic) is hidden from the client.
* The **client only calls methods** defined in the interface (`connect()`), with no knowledge of how the connection is made.
* This design decouples the client code from the concrete implementation, promoting flexibility and extensibility.
