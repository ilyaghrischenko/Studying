numbers = (1, 20, 300, 4000, 4, 12, 356, 412)

oneDigit = 0
twoDigit = 0
threeDigit = 0
fourDigit = 0
for number in numbers:
    if len(str(number)) == 1:
        oneDigit += 1
    elif len(str(number)) == 2:
        twoDigit += 1
    elif len(str(number)) == 3:
        threeDigit += 1
    else:
        fourDigit += 1

print(f'1 digit: {oneDigit} elements\n'
      f'2 digit: {twoDigit} elements\n'
      f'3 digit: {threeDigit} elements\n'
      f'4 digit: {fourDigit} elements')