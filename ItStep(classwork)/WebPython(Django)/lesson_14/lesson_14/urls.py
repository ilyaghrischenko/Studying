"""
URL configuration for lesson_14 project.

The `urlpatterns` list routes URLs to views. For more information please see:
    https://docs.djangoproject.com/en/4.2/topics/http/urls/
Examples:
Function views
    1. Add an import:  from my_app import views
    2. Add a URL to urlpatterns:  path('', views.home, name='home')
Class-based views
    1. Add an import:  from other_app.views import Home
    2. Add a URL to urlpatterns:  path('', Home.as_view(), name='home')
Including another URLconf
    1. Import the include() function: from django.urls import include, path
    2. Add a URL to urlpatterns:  path('blog/', include('blog.urls'))
"""
# from django.contrib import admin
from django.urls import path

from sales_app import views

urlpatterns = [
    path('customers/', views.customer_list, name='customer_list'),
    path('sellers/', views.seller_list, name='seller_list'),
    path('products/', views.product_list, name='product_list'),
    path('sales/', views.sale_list, name='sale_list'),

    path('add_customer/', views.add_customer, name='add_customer'),
    path('add_seller/', views.add_seller, name='add_seller'),
    path('add_product/', views.add_product, name='add_product'),
    path('add_sale/', views.add_sale, name='add_sale'),
]
