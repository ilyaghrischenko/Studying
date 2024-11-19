from django.shortcuts import render
from django.http import HttpResponse
  
def index(request):
    return HttpResponse("<h2>Главная</h2>")
 
def about(request):
    return HttpResponse('<h2>О сайте</h2>')
                           
 
def contact(request,name='Noname',adress='Noadress'):
    responsetext="<h2>Контакты</h2>"
    responsetext+=f"<p>Name: {name}</p>"
    responsetext+=f"<p>Adress: {adress}</p>"
    return HttpResponse(responsetext)
