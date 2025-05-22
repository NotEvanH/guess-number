import time
import random
import math

start_time = time.time()
random_number = random.randint(1, 1000)

print("Guess a number between 1 and 1000 and see how long it takes you")

while True:
    guess = int(input("Guess number: "))
    if guess == random_number:
        break
    else:
        print("Wrong!!")

print("Good job!")
print(f"It took you {math.ceil(time.time() - start_time)}.")
