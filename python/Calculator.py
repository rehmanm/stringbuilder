import re
from NegativeValueException import NegativeValueException
class Calculator:

    def Add(self, numbers):

        result = 0 
        
        separators, seperatorIndexOf = self.GetSeperators(numbers)

        raiseNegativeException = False;
        negativeNumbers = []
 
        for n in re.split(separators, numbers[seperatorIndexOf:]):
            if n == '':
                continue;
            num = int(n)
            if num <= 1000:
                result+=num
            if num <0:
                raiseNegativeException = True
                negativeNumbers.append(str(num))
        
            if raiseNegativeException:
                raise NegativeValueException("Negative Not Allowed", ''.join(negativeNumbers))


        return result

    def GetSeperators(self, numbers):
 
        seperatorIndexOf = 0

        if (numbers.startswith("//")):
            
            seperatorIndexOf = numbers.index("\n")

            extractSeperators = numbers[2:seperatorIndexOf] 
            separators = ""
            for s in extractSeperators.split(','):
                for s1 in s:
                    separators += "\\"+ s1
                separators += "|" 
            
            separators = separators[:-1]

        else:
            separators = "\,"# [","]

        return (separators, seperatorIndexOf)
