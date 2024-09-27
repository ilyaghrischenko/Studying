companies = ('Audi', 'BMW', 'Honda', 'Mazda', 'Tesla', 'BMW', 'Mazda', 'Audi', 'Tesla')
companies = list(companies)

userSearch = input('Enter a company: ')
userReplace = input('Enter a replace company: ')
for i in range(len(companies)):
    if userSearch == companies[i]:
        companies[i] = userReplace

companies = tuple(companies)
print(companies)