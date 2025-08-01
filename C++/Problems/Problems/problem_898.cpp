#include "problem_898.h"

#include <unordered_set>

bool problem_898::test() {
    std::vector arr { 1, 2, 4 };

    auto expected = 6;

    auto result = subarrayBitwiseORs(arr);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_898::subarrayBitwiseORs(std::vector<int> &arr) {
    std::unordered_set<int> result;
    std::unordered_set partial{0};
    for (auto num : arr)
    {
        std::unordered_set<int> tmp;
        for (auto prev : partial)
            tmp.insert(num | prev);
        tmp.insert(num);
        for (auto value : tmp)
            result.insert(value);
        partial = tmp;
    }

    return result.size();
}
