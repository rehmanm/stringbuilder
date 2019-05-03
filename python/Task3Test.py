import unittest
from Calculator import Calculator

class Task3Test(unittest.TestCase):

 

    def test_SemiColonSeperated(self):
        c = Calculator()
        self.assertEqual(c.Add(numbers="//;\n1;3;4"), 8)

    def test_AtTheRateSeperated(self):
        c = Calculator()
        self.assertEqual(c.Add(numbers="//@\n1@3@8"), 12)


    def test_DollarSeperated(self):
        c = Calculator()
        self.assertEqual(c.Add(numbers="//$\n1$2$3"), 6)


if __name__ == '__main__':
    unittest.main()