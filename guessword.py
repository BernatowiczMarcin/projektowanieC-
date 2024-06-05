print("\n\t\t Welcone at Guess the word 1.0")
word = input("\nInsert any word : ")
for letter in word:
    print(letter)

print("\n\t Lenght of your word is : ...",len(word))
print("The most used letter in english is lettet 'a' so let check it in your word")
if "a" in word:
        print("\n\t Yes it is !")
else:
        print("\n\t No  it isnt")
input("Press enter to close a game")        
