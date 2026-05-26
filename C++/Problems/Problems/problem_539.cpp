#include "problem_539.h"

bool problem_539::test() {
    std::vector<std::string> timePoints { "23:59", "00:00" };

    int expected = 1;

    auto result = findMinDifference(timePoints);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_539::findMinDifference(std::vector<std::string> &timePoints) {
    int total = 24 * 60;
    std::vector pres(total, false);
    for (auto t : timePoints)
    {
        int minutes = 600 * (t[0] - '0') + 60 * (t[1] - '0') + 10 * (t[3] - '0') + (t[4] - '0');
        if (pres[minutes])
            return 0;
        pres[minutes] = true;
    }
    int l = 0;
    while (!pres[l])
        l++;
    int r = total - 1;
    while (!pres[r])
        r--;
    int result = l + total - r;
    int prev = l;
    for (int i = l + 1; i <= r; ++i)
    {
        if (pres[i])
        {
            result = std::min(result, i - prev);
            prev = i;
        }
    }

    return result;
}
