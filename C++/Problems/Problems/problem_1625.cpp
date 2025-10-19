#include "problem_1625.h"

bool problem_1625::test() {
    std::string s = "5525";
    int a = 9;
    int b = 2;

    std::string expected = "2050";

    auto result = findLexSmallestString(s, a, b);

    std::cout << result << std::endl;

    return expected == result;
}

std::string problem_1625::findLexSmallestString(std::string s, int a, int b) {
    std::set<std::string> present;
    findRec(s, a, b, present);

    return *present.begin();
}

void problem_1625::findRec(std::string s, int a, int b, std::set<std::string>& present) {
    if (present.contains(s))
        return;
    present.insert(s);

    int n = s.size();
    std::string added;
    for (int i = 0; i < n; i++)
    {
        if (i % 2 == 0)
            added += s[i];
        else
            added += (char)('0' + (s[i] - '0' + a) % 10);
    }

    std::string rotated = s.substr(n - b, b) + s.substr(0, n - b);
    findRec(added, a, b, present);
    findRec(rotated, a, b, present);
}
