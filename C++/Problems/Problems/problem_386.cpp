#include "problem_386.h"

bool problem_386::test() {
    auto n = 13;

    auto expected = std::vector{ 1, 10, 11, 12, 13, 2, 3, 4, 5, 6, 7, 8, 9 };

    auto result = lexicalOrder(n);

    return expected.size() == result.size() && std::equal(expected.begin(), expected.end(), result.begin());
}

std::vector<int> problem_386::lexicalOrder(int n) {
    auto result = std::vector<int>();

    lexicalOrderRec(n, 1, &result);
    return result;
}

void problem_386::lexicalOrderRec(int n, int num, std::vector<int>* result) {
    if (num > n)
        return;

    result->push_back(num);
    lexicalOrderRec(n, num * 10, result);

    if (num % 10 != 9)
        lexicalOrderRec(n, num + 1, result);
}


