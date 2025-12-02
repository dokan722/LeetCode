#include "problem_3623.h"

#include <unordered_map>

bool problem_3623::test() {
    std::vector<std::vector<int>> points { { 1, 0 }, { 2, 0 }, { 3, 0 }, { 2, 2 }, { 3, 2 } };

    int expected = 3;

    auto result = countTrapezoids(points);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3623::countTrapezoids(std::vector<std::vector<int>> &points) {
    std::unordered_map<int, long long> counts;
    int mod = 1000000007;
    for (auto point : points)
    {
        if (counts.contains(point[1]))
            counts[point[1]]++;
        else
            counts[point[1]] = 1;
    }

    long s = 0;
    long result = 0;
    for (auto count : counts)
    {
        long pairs = count.second * (count.second - 1) / 2;
        result = (result + pairs * s) % mod;
        s = (s + pairs) % mod;
    }

    return (int)result;
}
