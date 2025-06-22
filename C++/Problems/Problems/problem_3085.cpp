#include "problem_3085.h"

#include <algorithm>
#include <iostream>
#include <ostream>

bool problem_3085::test() {
    auto word = "itatwtiwwi";

    auto k = 1;

    auto expected = 1;

    auto result = minimumDeletions(word, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3085::minimumDeletions(std::string word, int k) {
    int counts[26] = {0};
    for (auto c : word)
    {
        counts[c - 'a'] += 1;
    }

    std::ranges::sort(counts);

    auto start = 0;
    while (counts[start] == 0)
        start++;

    if (std::abs(counts[start] - counts[25]) <= k)
        return 0;

    auto result = INT_MAX;
    for (int i = start; i < 26; ++i)
    {
        auto currMin = counts[i];
        auto count = 0;
        for (int j = start; j < 26; ++j)
        {
            if (counts[j] < currMin)
                count += counts[j];
            else if (std::abs(counts[j] - currMin) > k)
                count += counts[j] - (currMin + k);
        }
        if (count < result)
            result = count;
    }


    return result;
}
