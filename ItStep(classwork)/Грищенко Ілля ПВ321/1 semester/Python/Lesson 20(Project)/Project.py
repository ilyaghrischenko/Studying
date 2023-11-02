import random

def draw(board):
    print("+-------"*3, "|", sep='')
    for row in range(3):
        print("|       "*3, "|", sep='')
        for col in range(3):
            print("|   "+str(board[row][col]) + "   ", end='')
        print("|")
        print("|       "*3, "|", sep='')
        print("+-------"*3, "|", sep='')

def check_free(board):
    free = []
    for row in range(3):
        for col in range(3):
            if board[row][col] not in ['0', 'X']:
                free.append((row, col))
    print(free)
    return free

def move(board):
    while True:
        hid = int(input("Ваш хід: ")) - 1
        row = hid // 3
        col = hid % 3
        if board[row][col] not in ['0', 'X']:
            board[row][col] = '0'
            break
        else:
            print("Ця клітинка вже зайнята. Спробуйте ще раз.")

def comp_move(board):
    free_cells = check_free(board)
    hid = random.randrange(len(free_cells))
    row, col = free_cells[hid]
    board[row][col] = 'X'

def win(board, sgn):
    if sgn=='X':
        who="X"
    elif sgn=="0":
        who="0"
    else:
        who=None
    for rc in range(3):
        if board[rc][0] == sgn and board[rc][1] == sgn and board[rc][2] == sgn:
            return who
        if board[0][rc] == sgn and board[1][rc] == sgn and board[2][rc] == sgn:
            return who
    if board[0][0] == sgn and board[1][1] == sgn and board[2][2] == sgn:
        return who
    if board[0][2] == sgn and board[1][1] == sgn and board[2][0] == sgn:
        return who
    return None


board = [[j * 3 + i + 1 for i in range(3)] for j in range(3)]
board[1][1] = "X"
draw(board)

free = check_free(board)
human_turn = True

while len(free) > 0:
    if human_turn:
        move(board)
        vict = win(board, "0")
    else:
        comp_move(board)
        vict = win(board, "X")
    if vict != None:
        break

    draw(board)


    human_turn = not human_turn
    free = check_free(board)
draw(board)
if vict == "0":
    print("Ви виграли!")
elif vict == "X":
    print("Комп'ютер виграв")
else:
    print("Нічия")
