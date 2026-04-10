A simple **CRUD (Create, Read, Update, Delete) API** built using **ASP.NET Core Web API**.
This project demonstrates how to build RESTful APIs and test them using **Swagger UI**.

---

## 🚀 Features

* Get all products
* Get product by ID
* Add new product
* Update existing product
* Delete product
* Swagger UI for easy API testing

---

## 🛠️ Tech Stack

* ASP.NET Core Web API
* C#
* Swagger (Swashbuckle)
* In-Memory Data (No Database)

---

## 📂 Project Structure

```
ProductApi/
│── Controllers/
│   └── ProductListController.cs
│
│── Models/
│   └── Product.cs
│
│── Data/
│   └── ProductData.cs
│
│── Program.cs
│── appsettings.json
```

---

## ⚙️ Setup & Run

### 1️⃣ Clone Repository

```bash
git clone https://github.com/your-username/ProductApi.git
cd ProductApi
```

### 2️⃣ Run Project

```bash
dotnet run
```

---

## 🌐 Swagger API Testing

After running the project, open:

```
https://localhost:5001/swagger
```

or

```
http://localhost:5000/swagger
```

You can test all API endpoints directly from Swagger UI.

---

## 📌 API Endpoints

### 🔹 Get All Products

```
GET /api/ProductList
```

### 🔹 Get Product By ID

```
GET /api/ProductList/{id}
```

### 🔹 Add Product

```
POST /api/ProductList
```

**Request Body:**

```json
{
  "name": "Laptop",
  "price": 50000
}
```

---

### 🔹 Update Product

```
PUT /api/ProductList/{id}
```

**Request Body:**

```json
{
  "name": "Updated Laptop",
  "price": 55000
}
```

---

### 🔹 Delete Product

```
DELETE /api/ProductList/{id}
```

---

## 🧩 Sample Model

```csharp
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}
```

---

## 📊 Sample In-Memory Data

```csharp
public static class ProductData
{
    public static List<Product> Products = new List<Product>
    {
        new Product { Id = 1, Name = "Mobile", Price = 20000 },
        new Product { Id = 2, Name = "Laptop", Price = 50000 }
    };
}
```

---

## 📖 Learning Purpose

This project is created for:

* Beginners learning ASP.NET Core Web API
* Understanding CRUD operations
* Practicing API testing with Swagger

---

## ✨ Future Improvements

* Connect with SQL Database
* Add Authentication (JWT)
* Add Validation
* Use Entity Framework Core

---

## 👩‍💻 Author

**G. Pavani**
B.Tech CSE (Data Science)

---

## ⭐ Support

If you like this project, give it a ⭐ on GitHub!
