import unittest
from Calculator import Calculator
from NegativeValueException import NegativeValueException
class Task4Test(unittest.TestCase):

 

    def test_Exception(self):
        c = Calculator()
        self.assertRaises(NegativeValueException, c.Add, "-1,2,-5")
 
 


if __name__ == '__main__':
    unittest.main()