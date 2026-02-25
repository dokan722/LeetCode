#include "problem_881.h"

bool problem_881::test() {
    std::vector people { 3, 2, 2, 1 };
    int limit = 3;

    int expected = 3;

    auto result = numRescueBoats(people, limit);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_881::numRescueBoats(std::vector<int> &people, int limit) {
    std::sort(people.begin(), people.end());
    int l = 0;
    int r = people.size() - 1;
    int result = 0;
    while (l < r)
    {
        if (people[l] + people[r] <= limit)
        {
            l++;
            r--;
        }
        else
            r--;
        result++;
    }
    if (l == r)
        result++;
    return result;
}
