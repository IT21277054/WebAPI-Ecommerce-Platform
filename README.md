# 🛒 E-commerce Backend System

## 🌟 Overview
This repository contains the **backend system** for an E-commerce platform. The platform features a **web application** for managing products, orders, vendors, and customers, as well as a **mobile application** for customers to browse and purchase products.

The backend is built using a **client-server architecture** and features a centralized web service that manages business logic and data processing.

## ⚙️ Features
- **👤 User Management**: Supports different roles such as Administrator, Vendor, and Customer Service Representative (CSR).
- **📦 Product Management**: Vendors can create, update, and delete products, manage product activation, and control inventory.
- **📋 Order Management**: Manage customer orders, track order status, and handle cancellations.
- **📊 Inventory Management**: Track and manage stock levels and generate alerts for low stock.
- **🏪 Vendor Management**: Administrators can create and manage vendors. Customers can rate and comment on vendors.
- **📱 Mobile Application Integration**: Allows customers to browse products, add items to cart, place orders, and track order status via the mobile app.
- **🔔 Notifications**: System-generated notifications for important actions such as order updates and low stock.

## 🛠️ Technology Stack
- **Backend**: C# Web API
- **Database**: NoSQL (for managing data storage)
- **Web Application**: React.js
- **Mobile Application**: Android (Java)

## 🚀 Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/Ecommerce-Backend-System.git

Set up the database:
Configure your NoSQL database (e.g., MongoDB, Firebase, etc.) and update the connection string in the appsettings.json.

## 🔗 API Endpoints
### 👥 User Management
- **POST** `/api/users` - Create a new user
- **GET** `/api/users/{id}` - Get user details
- **PUT** `/api/users/{id}` - Update user details
- **DELETE** `/api/users/{id}` - Delete a user
### 🛍️ Product Management
- **POST** `/api/products` - Create a new product
- **GET** `/api/products/{id}` - Get product details
- **PUT** `/api/products/{id}` - Update product details
- **DELETE** `/api/products/{id}` - Delete a product
### 📦 Order Management
- **POST** `/api/orders` - Create a new order
- **GET** `/api/orders/{id}` - Get order details
- **PUT** `/api/orders/{id}` - Update order details
- **DELETE** `/api/orders/{id}` - Cancel an order
## 📈 Future Improvements
- Implement real payment gateways.
- Add detailed analytics and reporting for inventory and order management.
- Extend mobile app support for iOS.
## 👥 Authors
- **Shiraz M.S** it21277054 - `shamryshiraz@gmail.com`
- **Umaira M.M** it21258312 - `mumaira0625@gmail.com`
- **Mallawaarachchi T.D.R** it21282836 - `thejani.mallawaarachchi@gmail.com`
- **Peiris A.R.D** It21249266 - `ardpeiris@gmail.com`
