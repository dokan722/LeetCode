from abc import ABC, abstractmethod

class Problem(ABC):
    @abstractmethod
    def test(self):
        pass