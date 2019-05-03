import unittest
from Calculator import Calculator

class Task1Test(unittest.TestCase):

    def test_EmptyStringShouldReturnZero(self):
        c = Calculator()
        self.assertEqual(c.Add(numbers=""), 0)

    def test_TestResult(self):
        c = Calculator()
        self.assertEqual(c.Add(numbers="1,2,5"), 8)

    

if __name__ == '__main__':
    unittest.main()