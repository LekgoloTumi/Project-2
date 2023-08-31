# Project-2

# Overview

Customer Management API is a RESTful API that provides endpoints to manage customers in a variety of ways, such as creating, updating, deleting, and retrieving them. The API is hosted on Azure App Service and requires Basic Authentication.

# Endpoints

For Customers:

GET /customers - Get all customers.
GET /customers/{id} - Get a specific customer by ID.
POST /customers - Create a new customer.
PATCH /customers/{id} - Update an existing customer.
DELETE /customers/{id} - Delete a customer.

For Products:

GET /products - Get all product.
GET /products/{id} - Get a specific product by ID.
POST /products - Create a new product.
PATCH /products/{id} - Update an existing product.
DELETE /products/{id} - Delete a product.

For Orders:

GET /orders - Get all orders.
GET /orders/{id} - Get a specific order by ID.
POST /orders - Create a new order.
PATCH /orders/{id} - Update an existing order.
DELETE /orders/{id} - Delete a order.

# Parameters

GET /customers - No parameters required.
GET /customers/{id} - The id parameter is required and specifies the ID of the customer to get.
POST /customers - The name and email parameters are required. The phone parameter is optional.
PATCH /customers/{id} - The id parameter is required. The name, email, and phone parameters are optional.
DELETE /customers/{id} - The id parameter is required.

GET /products - No parameters required.
GET /products/{id} - The id parameter is required and specifies the ID of the customer to get.
POST /products - The name and email parameters are required. The phone parameter is optional.
PATCH /products/{id} - The id parameter is required. The name, email, and phone parameters are optional.
DELETE /products/{id} - The id parameter is required.

GET /orders - No parameters required.
GET /orders/{id} - The id parameter is required and specifies the ID of the customer to get.
POST /orders - The name and email parameters are required. The phone parameter is optional.
PATCH /orders/{id} - The id parameter is required. The name, email, and phone parameters are optional.
DELETE /orders/{id} - The id parameter is required.

# Authentication

Since the API uses both basic authentication and JWT authentication, users must create an account in order to be able to use it as it requires them to create both accounts.

# Cloud Hosting

The API will be hosted on Azure and will be accessible via the internet through the Azure portal from any location with an internet connection.
