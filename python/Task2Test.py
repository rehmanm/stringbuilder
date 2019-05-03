import unittest
from Calculator import Calculator

class Task2Test(unittest.TestCase):

    def test_HandleNewLines1(self):
        c = Calculator()
        self.assertEqual(c.Add(numbers="1\n,2,3"), 6)
 
    def test_HandleNewLines2(self):
        c = Calculator()
        self.assertEqual(c.Add(numbers="1,\n2,4"), 7)
 


    

if __name__ == '__main__':
    unittest.main()