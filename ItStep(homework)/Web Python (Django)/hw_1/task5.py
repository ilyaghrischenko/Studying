en_fr_dict = {
    'word': 'mot',
    'cat': 'chat',
    'human': 'humain',
    'house': 'maison',
    'fish': 'poison'
}

def add(english, france):
    en_fr_dict[english] = france

def remove(english):
    del en_fr_dict[english]

def change(english, france):
    if english in en_fr_dict:
        en_fr_dict[english] = france

def get(english):
    return en_fr_dict[english]

print(en_fr_dict)
add('pig', 'porc')
print(en_fr_dict)
remove('pig')
print(en_fr_dict)
change('cat', 'NULL')
print(en_fr_dict)
print(get('cat'))
