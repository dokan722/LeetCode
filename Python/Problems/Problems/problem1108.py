from .problem import Problem


class Problem1108(Problem):
    def test(self):
        address = "1.1.1.1"

        expected = "1[.]1[.]1[.]1"

        result = self.defangIPaddr(address)

        print(result)

        return expected == result

    def defangIPaddr(self, address):
        return address.replace(".", "[.]")