from django.http import HttpResponse
from django.urls import reverse
from django.views.decorators.csrf import csrf_exempt



# def hello_view(request):
    #http://127.0.0.1:8000/HelloApp/?name=Anna&age=10
    # Повертаємо HTTP-відповідь з текстом і посиланням на головну сторінку
    # name = request.GET.get('name', 'Guest')  # 'Guest' - значення за замовчуванням, якщо параметр не знайдено
    # age = request.GET.get('age', 'unknown')

    # # Формування відповіді
    # response_text = (
    #     f"Hello, {name}! You are {age} years old.<br>"
    #     "This is HelloFromDjango Page.<br>"
    #     "<a href='/'>Go to Main Page</a>."
    # )
    # return HttpResponse(response_text)

@csrf_exempt
def hello_view(request):
    # Отримання всіх параметрів з URL
    #parameters = request.GET
    parameters = request.POST

    # Формування відповіді
    response_text = "Received parameters:<br>"
    
    # Перебір всіх параметрів і їх значень
    for key, value in parameters.items():
        response_text += f"{key}: {value}<br>"
    
    response_text += "<a href='/'>Go to Main Page</a>."
    
    return HttpResponse(response_text)


def main_view(request):
    # Використовуємо reverse для отримання URL з ім'ям 'helloview'
    #url_ = reverse('helloview')
    response_text = f"This is main Page.<br> Go to <a href='/HelloPage'>Hello Page</a>.<br>"
    response_text +=f"Go to <a href='/FormPage'>Form Page</a>."
    
    return HttpResponse(response_text)


def form_view(request):
    name=''
    age=''
    # Формування HTML-форми
    response_text = f"""
    <form method="POST" action="{reverse('helloview')}">
        <label for="name">Name:</label>
        <input type="text" id="name" name="name" value="{name}">
        <br>
        <label for="age">Age:</label>
        <input type="number" id="age" name="age" value="{age}">
        <br>
        <input type="submit" value="Submit">
    </form>
    <br>
    """
    return HttpResponse(response_text)
