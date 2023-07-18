#!/bin/python3

import math
import os
import random
import re
import sys

#
# Complete the 'timeConversion' function below.
#
# The function is expected to return a STRING.
# The function accepts STRING s as parameter.
#

def timeConversion(s):
    hours, minutes, seconds = map(int, s[:-2].split(':'))

    period = s[-2:]
    if period == 'AM':
        if hours == 12:
            hours = 0
    elif period == 'PM':
        if hours != 12:
            hours += 12
    
    military_time = '{:02d}:{:02d}:{:02d}'.format(hours, minutes, seconds)
    
    return military_time

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    s = input()

    result = timeConversion(s)

    fptr.write(result + '\n')

    fptr.close()
