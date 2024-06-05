print("\n\t Tworzenie plików tekstowych i binarnych w p3 ")


select=None
while select != "0":
    print("\n\t Czy chcesz utworzyc plik tekstowy ??")
    odp = input("\nWprowadź wybór tak lub nie : ")
    if odp=="tak":
        print("\n\n\t\tdobrze, utworzę dla ciebei plik teksotwy")
        text_file = open("tekstowy1.txt", "w")
        print("plik został utworzony :)")
        break
    elif odp =="nie":
        print("W takim razie nie utworzępliku")
        break
    else:
        print("WPROWADZONO NIEWŁAŚCIWY WYBÓR")
        break
input("press any button to continue ")

print("\n\t Skoro mamy już plik, postarajmy się zapełnić go treścią !!!")

text_file=open("tekstowy1.txt","w")
linia1=input("wprowadz PIERWSZY wiersz tekst do pliku :"  + "\n")
text_file.write(linia1+ "\n")
linia2=input("wprowadz DRUGI tekst do pliku :" +  "\n")
text_file.write(linia2 + "\n")
linia3=input("wprowadz TRZECI tekst do pliku :"  + "\n")
text_file.write(linia3+ "\n")
text_file.close()

print("Sprawdzimy czy dane zostały zapisane :) ")
text_file=open("tekstowy1.txt","r")
lines = text_file.readlines()

for element in lines:
 
    print(element)

text_file.close()
input("press any button to continue")
