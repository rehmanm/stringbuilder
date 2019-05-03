
class Calculator:

    def Add(numbers):

        result = 0
        
        for n in numbers.split(","):
            if n <=1000:
                result+=n
        
        return result