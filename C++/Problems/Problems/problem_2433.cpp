#include "problem_2433.h"

bool problem_2433::test() {
    std::vector pref { 5, 2, 0, 3, 1 };

    std::vector expected { 5, 7, 2, 3, 2 };

    auto result = findArray(pref);

    return result == expected;
}

std::vector<int> problem_2433::findArray(std::vector<int> &pref) {
    int prev = pref[0];
    for (int i = 1; i < pref.size(); i++)
    {
        int tmp = pref[i];
        pref[i] = prev ^ pref[i];
        prev = tmp;
    }

    return pref;
}
