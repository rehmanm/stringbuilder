import re
from Calculator import Calculator
from NegativeValueException import NegativeValueException


def main():
    print("main")

    c = Calculator()
    print(c.Add(""))
    print(c.Add("1,2,3"))
    print(c.Add("2,1001"))
    
    print(c.Add("1,\n2,4"))
    print("Task 3: delimiter '$'", c.Add("//$\n1$2$3"))    
    print("Task 3: delimiter ';'", c.Add("//;\n1;3;4"))
    print("Task 3: delimiter '@'", c.Add("//@\n2@3@8"))
    print("Task 3: delimiter '***'", c.Add("//***\n1***3***8"))

    print("Bonus delimiter multiple delimiters", c.Add("//***,$,@\n1$2@3***4"))
    
    try:
        c.Add("-1,3,-5")
    except NegativeValueException:
        print("Task 4: Negative Number:", "Negative Not Allowed")    

  
        

# display some lines

if __name__ == "__main__": 
    main()