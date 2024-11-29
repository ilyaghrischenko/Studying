from django.db import models

class Customer(models.Model):
    first_name = models.CharField(max_length=100)
    last_name = models.CharField(max_length=100)
    phone_number = models.CharField(max_length=15)
    email = models.EmailField()

class Seller(models.Model):
    first_name = models.CharField(max_length=100)
    last_name = models.CharField(max_length=100)
    phone_number = models.CharField(max_length=15)
    email = models.EmailField()
    hire_date = models.DateField()
    position_choices = [
        ('Seller', 'Продавець'),
        ('HeadSeller', 'Головний продавець'),
        ('SalesManager', 'Керівник відділу продажів'),
    ]
    position = models.CharField(max_length=50, choices=position_choices)

class Product(models.Model):
    name = models.CharField(max_length=200)
    description = models.TextField()

class Sale(models.Model):
    customer = models.ForeignKey(Customer, on_delete=models.CASCADE)
    seller = models.ForeignKey(Seller, on_delete=models.CASCADE)
    product = models.ForeignKey(Product, on_delete=models.CASCADE)
    sale_date = models.DateField()
    sale_amount = models.DecimalField(max_digits=10, decimal_places=2)
