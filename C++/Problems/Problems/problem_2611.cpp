#include "problem_2611.h"

bool problem_2611::test() {
    std::vector reward1 { 1, 1, 3, 4 };
    std::vector reward2 { 4, 4, 1, 1 };
    int k = 2;

    int expected = 15;

    auto result = miceAndCheese(reward1, reward2, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2611::miceAndCheese(std::vector<int> &reward1, std::vector<int> &reward2, int k) {
    int n = reward1.size();
    std::vector<int> ids;
    std::vector<int> diffs;
    for (int i = 0; i < n; i++)
    {
        ids.push_back(i);
        diffs.push_back(reward1[i] - reward2[i]);
    }
    std::sort(ids.begin(), ids.end(), [&](int a, int b) { return diffs[a] > diffs[b]; });
    int result = 0;
    for (int i = 0; i < k; ++i)
        result += reward1[ids[i]];
    for (int i = k; i < n; ++i)
        result += reward2[ids[i]];
    return result;
}
