#include "problem_1394.h"

#include <iostream>
#include <unordered_map>
#include <bits/ostream.tcc>

bool problem_1394::test() {
    std::vector arr  { 2, 2, 3, 4 };

    auto expected = 2;

    auto result = findLucky(arr);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1394::findLucky(std::vector<int> &arr) {
    std::pmr::unordered_map<int, int> dic;

    for (auto num : arr)
    {
        if (dic.contains(num))
            dic[num]++;
        else
            dic[num] = 1;
    }
    auto result = -1;
    for (auto pair : dic)
    {
        if (pair.first == pair.second && pair.first > result)
            result = pair.first;
    }

    return result;
}
