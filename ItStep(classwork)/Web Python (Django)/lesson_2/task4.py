# Базовая функция для выпекания пиццы
def bake_pizza(pizza_name):
    def decorator(func):
        def wrapper():
            print(f"Готовим пиццу {pizza_name}...")
            func()  # Выполняем функцию с ингредиентами
            print(f"Пицца {pizza_name} готова!\n")
        return wrapper
    return decorator

@bake_pizza("Маргарита")
def margherita():
    print("Додаємо: томати, сир моцарела")

@bake_pizza("Чотири сири")
def quattro_formaggi():
    print("Додаємо: моцарела, пармезан")

@bake_pizza("Капричоза")
def capricciosa():
    print("Додаємо: томати, моцарела, гриби, шинка")

@bake_pizza("Гавайська")
def hawaiian():
    print("Додаємо: томати, моцарела, шинка, ананас")

margherita()
quattro_formaggi()
capricciosa()
hawaiian()
