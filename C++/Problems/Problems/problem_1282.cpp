#include "problem_1282.h"

#include <unordered_map>

bool problem_1282::test() {
    std::vector groupSizes { 3, 3, 3, 3, 3, 1, 3 };

    std::vector<std::vector<int>> expected { { 0, 1, 2 },  {5}, {3, 4, 6}};

    auto result = groupThePeople(groupSizes);

    return expected == result;
}

std::vector<std::vector<int>> problem_1282::groupThePeople(std::vector<int> &groupSizes) {
    int n = groupSizes.size();
    std::unordered_map<int, std::vector<int>> lists;
    std::vector<std::vector<int>> result;
    for (int i = 0; i < n; ++i)
    {
        int size = groupSizes[i];
        if (!lists.contains(size))
            lists[size] = std::vector<int>();
        if (lists[size].size() == size - 1)
        {
            lists[size].push_back(i);
            result.push_back(lists[size]);
            lists.erase(size);
        }
        else
            lists[size].push_back(i);
    }

    return result;
}

