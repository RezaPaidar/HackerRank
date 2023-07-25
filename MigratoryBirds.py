#!/bin/python3

import math
import os
import random
import re
import sys

#
# Complete the 'migratoryBirds' function below.
#
# The function is expected to return an INTEGER.
# The function accepts INTEGER_ARRAY arr as parameter.
#

def migratoryBirds(arr):
    bird_count = {}  
    for bird_type in arr:
        bird_count[bird_type] = bird_count.get(bird_type, 0) + 1

    max_freq = max(bird_count.values())
    most_frequent_types = [bird_type for bird_type, freq in bird_count.items() if freq == max_freq]

    return min(most_frequent_types)

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    arr_count = int(input().strip())

    arr = list(map(int, input().rstrip().split()))

    result = migratoryBirds(arr)

    fptr.write(str(result) + '\n')

    fptr.close()
