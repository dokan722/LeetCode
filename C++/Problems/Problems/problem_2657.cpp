#include "problem_2657.h"

#include <unordered_set>

bool problem_2657::test() {
    std::vector A { 1, 3, 2, 4 };
    std::vector B { 3, 1, 2, 4 };

    std::vector expected { 0, 2, 3, 4 };

    auto result = findThePrefixCommonArray(A, B);

    print1DVector(result);

    return result == expected;
}

std::vector<int> problem_2657::findThePrefixCommonArray(std::vector<int> &A, std::vector<int> &B) {
    int n = A.size();
    int curr = 0;
    std::vector<int> result(n);
    std::unordered_set<int> setA;
    std::unordered_set<int> setB;
    for (int i = 0; i < n; ++i)
    {
        if (A[i] == B[i])
            curr++;
        else
        {
            if (setA.contains(B[i]))
                curr++;
            if (setB.contains(A[i]))
                curr++;
            setA.insert(A[i]);
            setB.insert(B[i]);
        }
        result[i] = curr;
    }

    return result;
}
