# Seonghyeon Choe
# schoe@seonghyeonchoe.com
# 2021

import sys
import math

# light_x: the X position of the light of power
# light_y: the Y position of the light of power
# initial_tx: Thor's starting X position
# initial_ty: Thor's starting Y position
light_x, light_y, initial_tx, initial_ty = [int(i) for i in input().split()]

# game loop
while True:
    remaining_turns = int(input())  # The remaining amount of turns Thor can move. Do not remove this line.

    # Write an action using print
    # To debug: print("Debug messages...", file=sys.stderr, flush=True)

    print("initial_ty " + str(initial_ty) + ", light_y " + str(light_y), file=sys.stderr, flush=True)
    print("initial_tx " + str(initial_tx) + ", light_x " + str(light_x), file=sys.stderr, flush=True)

    if initial_ty > light_y:
        print("N", sep='', end='')
        initial_ty -= 1
    elif initial_ty < light_y:
        print("S", sep='', end='')
        initial_ty += 1

    if initial_tx > light_x:
        print("W", sep='', end='')
        initial_tx -= 1
    elif initial_tx < light_x:
        print("E", sep='', end='')
        initial_tx += 1

    print()