from django.shortcuts import render
from .models import Customer, Seller, Product, Sale
from .forms import CustomerForm, SellerForm, ProductForm, SaleForm

def customer_list(request):
    customers = Customer.objects.all()
    return render(request, 'sales_app/customer_list.html', {'customers': customers})

def seller_list(request):
    sellers = Seller.objects.all()
    return render(request, 'sales_app/seller_list.html', {'sellers': sellers})

def product_list(request):
    products = Product.objects.all()
    return render(request, 'sales_app/product_list.html', {'products': products})

def sale_list(request):
    sales = Sale.objects.all()
    return render(request, 'sales_app/sale_list.html', {'sales': sales})

def add_customer(request):
    if request.method == "POST":
        form = CustomerForm(request.POST)
        if form.is_valid():
            form.save()
            return redirect('customer_list')
    else:
        form = CustomerForm()
    return render(request, 'sales_app/add_customer.html', {'form': form})

def add_seller(request):
    if request.method == "POST":
        form = SellerForm(request.POST)
        if form.is_valid():
            form.save()
            return redirect('seller_list')
    else:
        form = SellerForm()
    return render(request, 'sales_app/add_seller.html', {'form': form})

def add_product(request):
    if request.method == "POST":
        form = ProductForm(request.POST)
        if form.is_valid():
            form.save()
            return redirect('product_list')
    else:
        form = ProductForm()
    return render(request, 'sales_app/add_product.html', {'form': form})

def add_sale(request):
    if request.method == "POST":
        form = SaleForm(request.POST)
        if form.is_valid():
            form.save()
            return redirect('sale_list')
    else:
        form = SaleForm()
    return render(request, 'sales_app/add_sale.html', {'form': form})
