#include "problem_2073.h"

bool problem_2073::test() {
    std::vector tickets { 5, 1, 1, 1 };
    int k = 0;

    int expected = 8;

    auto result = timeRequiredToBuy(tickets, k);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_2073::timeRequiredToBuy(std::vector<int> &tickets, int k) {
    int n = tickets.size();
    int bar = tickets[k];
    int result = bar;
    for (int i = 0; i < k; ++i)
        result += std::min(tickets[i], bar);
    for (int i = k + 1; i < n; ++i)
        result += std::min(tickets[i], bar - 1);

    return result;
}
