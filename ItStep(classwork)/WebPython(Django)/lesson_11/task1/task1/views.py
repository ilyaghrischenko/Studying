from datetime import datetime
from django.shortcuts import render

def day(request):
    day_of_week = datetime.now().weekday()
    days = ['Понеділок', 'Вівторок', 'Середа', 'Четвер', 'П\'ятниця', 'Субота', 'Неділя']
    colors = {
        0: 'yellow',
        1: 'red',
        2: 'green',
        3: 'blue',
        4: 'pink',
        5: 'cyan',
        6: 'magenta'
    }

    current_day = days[day_of_week]
    color = colors[day_of_week]

    response = {
        'current_day': current_day,
        'color': color
    }

    return render(request, 'day.html', response)
