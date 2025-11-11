#include "problem_2244.h"

#include <unordered_map>

bool problem_2244::test() {
    std::vector tasks { 2, 2, 3, 3, 2, 4, 4, 4, 4, 4 };

    int expected = 4;

    auto result = minimumRounds(tasks);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2244::minimumRounds(std::vector<int> &tasks) {
    std::unordered_map<int, int> counts;
    for (auto task : tasks)
    {
        if (counts.contains(task))
            counts[task]++;
        else
            counts[task] = 1;
    }

    int result = 0;
    for (auto count : counts)
    {
        if (count.second == 1)
            return -1;
        int mod = count.second % 3;
        if (mod == 0)
            result += count.second / 3;
        else
            result += count.second / 3 + 1;
    }

    return result;
}
