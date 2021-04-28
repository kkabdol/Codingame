// Seonghyeon Choe
// schoe@seonghyeonchoe.com

#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <stdbool.h>

int main()
{
    // the X position of the light of power
    int light_x;
    // the Y position of the light of power
    int light_y;
    // Thor's starting X position
    int initial_tx;
    // Thor's starting Y position
    int initial_ty;
    scanf("%d%d%d%d", &light_x, &light_y, &initial_tx, &initial_ty);

    // game loop
    while (1) {
        // The remaining amount of turns Thor can move. Do not remove this line.
        int remaining_turns;
        scanf("%d", &remaining_turns);

        if (initial_ty > light_y )
        {
            putchar('N');
            --initial_ty;
        }
        else if (initial_ty < light_y )
        {
            putchar('S');
            ++initial_ty;
        }

        if (initial_tx > light_x )
        {
            putchar('W');
            --initial_tx;
        }
        else if (initial_tx < light_x )
        {
            putchar('E');
            ++initial_tx;
        }

        putchar('\n');;
    }

    return 0;
}