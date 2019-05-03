import unittest
from Calculator import Calculator

class BonusTest(unittest.TestCase):

    def test_IgnoreGreaterThan1000(self):
        c = Calculator()
        self.assertEqual(c.Add(numbers="2,1001"), 2)

    def test_DelimitersWithArbitraryLength(self):
        c = Calculator()
        self.assertEqual(c.Add(numbers="//***\n1***2***3"), 6)

    def test_MultipleDelimiters(self):
        c = Calculator()
        self.assertEqual(c.Add(numbers="//$,@\n1$2@3"), 6)
    
    def test_ArbitraryWithMultipleDelimiters(self):
        c = Calculator()
        self.assertEqual(c.Add(numbers="//***,$,@\n1$2@3***4"), 10)
    

if __name__ == '__main__':
    unittest.main()