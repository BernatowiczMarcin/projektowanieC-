import random
bank=(" E ", " EG ", " EGZ ", " EGZE ",                    #   HANGMAN
" EGZEK ", " EGZEKU ", "EGZEKUC", " EGZEKUCJ", "EGZEKUCJA - YOU ARE DEAD !")

LIMIT = len(bank)-1                       # MAX_WRONG

slowa=("JEBANKO","ZBOCZONY", "SEKSOWNA","PEJCZ","SMYCZ","BIELIZNA")   #WORDS

word= random.choice(slowa)       #random word from bank
so_far= "*" * len(word)             # sign for cover unable values

wrong=0                 # number of wrong try
used=[]                 # conteiner for used letters

print("\n\t\t\t Welcome in 'EXECUTION' game")
print("\t Rules are simple: your duty is guess the word by type a letter.")
print(" Bur if u will not guess your will be EXECUTED... Have fun then !!!")

while wrong < LIMIT and so_far != word:                 #warunek główny
    print("\tExecution in progress ... ",bank[wrong])
    print("\t You used those letter until now : ",used)
    print("\n Now word what you looking for looks like : ",so_far)

    guess=input("\n\t\t Inser ONE letter : but rember for STAKE of game : ")  #inser letter
    guess=guess.upper()

    while guess in used:
        print("\n\t You already used this letter beafore...")
        guess=input("Insert letter again :")            #WPROWADZENIE LITERY
        guess=guess.upper()
    used.append(guess)                  #DODANIE LITERY DO UŻYTYCH

    if guess in word:
        print('\n Uff you can take deep breath. This word contain YOUR letter ')
        new=""                      # nowa wersja word

        for i in range(len(word)):    #sprawdzanie czy słowo zawiera
            if guess == word[i]:        # litere w kazdej poozycji
                new+=guess              #dodanie do próby wprowadzonej przez gracza
            else:
                new+=so_far[i]           #określenie pozycji dla odkrytej litery
        so_far= new                     #przypisanie zmian do zakrytego słowa

    else:
        print("\n\tUnfortunetly letter :",guess," doesnt exist in word. ")
        print("You are getting closer to be executed....")
        wrong+=1

if wrong==LIMIT:
    print(bank[wrong])
    print("\n\tYOU HAVE BEEN EXECUTED... YOU LOST.")
    input("Press enter to close an application")
    
else:
    print("\n\t  CONGRATULATIONS YOU WON, secret word is : ",word)
    input("Press enter to close an applcation.")
    input("Press enter to close an application")


