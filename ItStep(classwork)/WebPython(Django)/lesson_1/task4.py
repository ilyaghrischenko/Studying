countries = {'Ukraine', 'USA', 'Poland', 'France'}

userChoice = 0
while userChoice != -1:
    userChoice = int(input('0 - Show\n'
                           '1 - Add country\n'
                           '2 - Del country\n'
                           '3 - Search by symbol\n'
                           '-1 - Exit\n'
                           ": "))

    if userChoice == 0:
        print(f'\n{countries}')
        input("Press Enter to continue...\n")
    elif userChoice == 1:
        newCountry = input('Enter country name: ')
        countries.add(newCountry)
    elif userChoice == 2:
        delCountry = input('Enter country name: ')
        countries.remove(delCountry)
    elif userChoice == 3:
        symbol = input('Enter symbol: ')
        matchingCountries = [item for item in countries if symbol in item]
        if matchingCountries:
            print(f"\nCountries containing '{symbol}': {', '.join(matchingCountries)}")
        else:
            print(f"\nNo countries contain the symbol '{symbol}'.")
        input("Press Enter to continue...\n")