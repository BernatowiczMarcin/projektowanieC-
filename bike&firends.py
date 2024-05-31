print("\n\t\t \\\\ Welcome in 'Bike note' with friends // ")
wybor=None
wyniki=[]
print("\n\t Let's check who have best personal record of bike ride ")

'''
        
        MENU : 
        
    1 - Close program
    2 - Add a score
    3 - Show best scores

'''
while wybor !=0:
    wybor=int(input("\nMake a choice here : "))

    if wybor ==1:
        print("Thank you for use  BIKE NOTE")
        break
    elif wybor==2:
        print("You are going to add a score now ")
        name=input("\n\tInsert name of player : ")
        score=int(input("Insert personal record here " ))
        entry = (score, name)
        wyniki.append(entry)
        print(name," personal record is: ",score, " kilometers ")

    elif wybor==3:
        licznik=int(input("\nInsert a number how many best score do you want to see : "))
        print("\t\n You are going to see : ",licznik," best score")

        wyniki=wyniki[:licznik]
        wyniki.sort(reverse=True)
        for entry in wyniki:
            score,name= entry
            wyniki=wyniki[:licznik]
            print(name, "\t", score)


    else:
        print("Insert correct possition from menu ...")
        input("Press enter to close an aplication ")