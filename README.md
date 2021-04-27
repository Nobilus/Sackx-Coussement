
# Back-end - Project



## Indices

* [Ungrouped](#ungrouped)

  * [add customer](#1-add-customer)
  * [add order](#2-add-order)
  * [add product](#3-add-product)
  * [add staff member](#4-add-staff-member)
  * [customer](#5-customer)
  * [customers](#6-customers)
  * [product](#7-product)
  * [products](#8-products)
  * [staff member](#9-staff-member)
  * [staff members](#10-staff-members)
  * [units](#11-units)


--------


## Ungrouped



### 1. add customer



***Endpoint:***

```bash
Method: POST
Type: RAW
URL: http://localhost:5000/api/customer
```



***Body:***

```js        
{
    "companyNumber": "0755697108",
    "firstName": "Test validation api",
    "lastName": "test"
}
```



### 2. add order



***Endpoint:***

```bash
Method: POST
Type: RAW
URL: http://localhost:5000/api/order
```



***Body:***

```js        
{
    "amount": 1,
    "customerId": 1,
    "products": [
        "c62f54e4-fe3c-4c24-ab01-0112ef2d620c"
        ]

}
```



### 3. add product



***Endpoint:***

```bash
Method: POST
Type: RAW
URL: http://localhost:5000/api/product
```



***Body:***

```js        
{
 "name": "Testhout"   ,
 "thickness": 5.0,
 "width": 2.1,
 "price": 2.10,
 "unitId": 1
}
```



### 4. add staff member



***Endpoint:***

```bash
Method: POST
Type: RAW
URL: http://localhost:5000/api/staff
```



***Body:***

```js        
{
    "firstName": "Willy",
    "lastName": "Wortel",
    "telephoneNumber": "0471814125",
    "email": "willy@wortel.com"
}
```



### 5. customer



***Endpoint:***

```bash
Method: GET
Type: 
URL: http://localhost:5000/api/customer/1
```



### 6. customers



***Endpoint:***

```bash
Method: GET
Type: 
URL: http://localhost:5000/api/customers
```



### 7. product



***Endpoint:***

```bash
Method: GET
Type: 
URL: http://localhost:5000/api/products/f1e8e78c-be10-42c4-abe9-8f0465a2dcce
```



### 8. products



***Endpoint:***

```bash
Method: GET
Type: 
URL: http://localhost:5000/api/products
```



### 9. staff member



***Endpoint:***

```bash
Method: GET
Type: 
URL: http://localhost:5000/api/staff/2
```



### 10. staff members



***Endpoint:***

```bash
Method: GET
Type: 
URL: http://localhost:5000/api/staff
```



### 11. units



***Endpoint:***

```bash
Method: GET
Type: 
URL: http://localhost:5000/api/units
```



***Available Variables:***

| Key | Value | Type |
| --- | ------|-------------|
| dotnet | http://localhost:5000/api/ |  |



---
[Back to top](#back-end---project)
> Made with &#9829; by [thedevsaddam](https://github.com/thedevsaddam) | Generated at: 2021-04-27 19:51:36 by [docgen](https://github.com/thedevsaddam/docgen)
