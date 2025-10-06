#include "problem_2053.h"

#include <unordered_map>

bool problem_2053::test() {
    std::vector<std::string> arr { "d", "b", "c", "b", "c", "a" };
    int k = 2;

    std::string expected = "a";

    auto result = kthDistinct(arr, k);

    std::cout << result << std::endl;

    return expected == result;
}

std::string problem_2053::kthDistinct(std::vector<std::string> &arr, int k) {
    std::unordered_map<std::string, int> present;
    for (auto s : arr)
    {
        if (present.contains(s))
            present[s]++;
        else
            present[s] = 1;
    }
    int num = 0;
    for (auto s : arr)
    {
        if (present[s] > 1)
            continue;
        num++;
        if (num == k)
            return s;
    }

    return "";
}
