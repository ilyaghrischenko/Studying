import random as rnd

basketballers = {
    'Butnik Dmytro Vitaliyovich': rnd.randint(150,200),
    'Hryshchenko Illia Vladimirovich': rnd.randint(150,200),
    'Yarmolenko Maksym Viktorovich': rnd.randint(150,200)
}

def add(pib):
    basketballers[pib] = rnd.randint(150,200)

def remove(pib):
    del basketballers[pib]

def change(pib, height):
    basketballers[pib] = height


print(basketballers)
add('New Pib')
print(basketballers)
remove('New Pib')
print(basketballers)
change('Hryshchenko Illia Vladimirovich', 10)
print(basketballers)
