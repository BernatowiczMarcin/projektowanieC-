print("\n\t\t\\\\\\ Welcome in The coin flipper 1.0 ! ///")
flip_number=int(input("Insert number how many coin flips do you need ?:"))

print("\n Okay, now I will throw coin ",flip_number," times. GET READY!")
bet=(input("Bet what will win eagle or value ?"))
print("\n So... you bet : ",bet,)
        
print("\n Please wait a second.")
import random
i=int(0)
count_c=int(0)
count_e=int(0)
flip=0
while i<= flip_number:
    flip=random.randint(1,2)
    i+=1
    if flip== 1:
        count_c+=1
    else:
        count_e+=1
if count_c > count_e:
    print("\n VALUE WON with score: ",count_c,)
elif count_c < count_e:
    print("\n EAGLE WON with socre: ",count_e,)
else:
    print("\n It is a draw !")

input("\n Press eneter to close a program ")

                
