from random import randint

los= randint(1,10)
i=0
moja = -1
print("witaj w grze - odgadnij liczbe")

while los != int(moja):
    i+=1
    moja = int(input("podaj swoja liczbe : "))
    print("wybrałeś liczbę ",  moja)
    if int(moja) > los:
        print("twoja liczba jest większa od wylosowanej")
    elif int(moja) < los:
        print("twoja liczba jest mniejsza od wylosowanej")
    else:
        print("brawo zgadleś liczbę  za próbą nr ", i)
