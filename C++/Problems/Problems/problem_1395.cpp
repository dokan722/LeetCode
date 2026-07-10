#include "problem_1395.h"

bool problem_1395::test() {
    std::vector rating { 2, 5, 3, 4, 1 };

    int expected = 3;

    auto result = numTeams(rating);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1395::numTeams(std::vector<int> &rating) {
    int n = rating.size();
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        int smaller1 = 0;
        int bigger1 = 0;
        for (int j = 0; j < i; ++j)
        {
            if (rating[j] < rating[i])
                smaller1++;
            if (rating[j] > rating[i])
                bigger1++;
        }
        int smaller2 = 0;
        int bigger2 = 0;
        for (int j = i + 1; j < n; ++j)
        {
            if (rating[j] < rating[i])
                smaller2++;
            if (rating[j] > rating[i])
                bigger2++;
        }
        result += smaller1 * bigger2 + smaller2 * bigger1;
    }

    return result;
}
