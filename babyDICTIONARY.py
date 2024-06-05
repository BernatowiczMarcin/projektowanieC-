print("\n\t\t \\\\ Welcome at ""Dictionary of baby things"" //:")

dic={"chair":" Thing to take a seat on it, example: whe you are eating.",
"bike": " You use that for ride and do sport, example: Cycling with Mommy and Daddy.",
"book":" Source of knownledge, example: Use books in schools for a study.",
"cutlery":" Stuff to easy eat our meals, exaple: fork,spoon,knife.",
"soap":" Thing what kills bacteria, example: used every time before meal. "}

choice = None

print("\n\t Menu of dictionary is below :")
print("\n 0 - EXIT")
print("\n 1 - Search in dictionary")
print("\n 2 - Add record into dictionary")
print("\n 3 - Change definition of word")
print("\n 4 - Remove record from dictionary ")
while choice != "0":
    choice=int(input("\n\t\tSelect possition from menu here : "))
    if choice==0:
        print("\n\t Goodbye, hope to see you soon !")
        break
    elif choice==1:
        szukaj=input("Type word what would you like to read  :")
        if szukaj in dic:
            definicja=dic[szukaj]
            print("Mean of word  '",szukaj,"' is : ",definicja, )
        else:
            print("DICTIONARY do not contain ",szukaj," you can add a definition in menu. ")
    elif choice==2:
        dodaj=input("Type a word what you want add into dictionary : ")
        if dodaj is not dic:
            znaczenie=input("What does it means ? Type here : ")
            dic[dodaj]=znaczenie
            print("Word '''",dodaj,"''' has been added into dictionary.")
        else:
            print("Word '", dodaj, "' already exist in dictionary.")
    elif choice==3:
        zmien = input("Type a word what definition should be changed : ")
        if zmien in dic:
            zmiana=input("type a new definition here :")
            dic[zmien]=zmiana
        else:
            print("Dictionary doesnt contain ",zmien," try add it word by menu")
    elif choice == 4:
        usun=input("Insert word what will be deleted from dictionary :")
        if usun in dic:
            del dic[usun]
            print("Word '",usun,"' has been deleted")
        else:
            print("Word '",usun,"' doesn't exist in dictionary")