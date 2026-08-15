#include "problem_3137.h"

bool problem_3137::test() {
    std::string word = "leetcodeleet";
    int k = 4;

    int expected = 1;

    auto result = minimumOperationsToMakeKPeriodic(word, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3137::minimumOperationsToMakeKPeriodic(std::string word, int k) {
    int n = word.size();
    std::unordered_map<std::string, int> counts;
    int most = 0;
    for (int i = 0; i < n; i += k)
    {
        std::string cur = word.substr(i, k);
        if (counts.contains(cur))
            counts[cur]++;
        else
            counts[cur] = 1;
        most = std::max(most, counts[cur]);
    }
    return (n / k) - most;
}
