print("\n\t\t \\ WELCOME IN RUNNER COLLECTOR 1.0 /")
'''
You can add, delete, sort your personal record of running. 
    Insert your choice:
    1 - Exit
    2 - Show your scores
    3 - Add score
    4 - Remove score 
    5 - Sort score
'''
records =[]
choice = None

while choice != 0:
    choice=int(input("\nSelect your choice NOW :  "))

    if choice ==1:
        print("\nThank you for use Runner Collector 1.0  Goodbye")
        break

    elif choice ==2:
        print("Your finnished scores are here : ",records)

    elif choice ==3:
        record= float(input("Insert your sore here : "))
        records.append(record)

    elif choice ==4:
        print(records)
        record = float(input("Insert your sore here : "))

        if record in records:
            records.remove(record)
        else:
            print("\n\t There is no score in records")
    elif choice ==5:
        records.sort(reverse=False)
        print(records)
    else:
        print("Insert a number 1-5")