#include "problem_869.h"

#include <algorithm>

const std::vector<std::string> sortedPowers {"1",
"2",
"4",
"8",
"16",
"23",
"46",
"128",
"256",
"125",
"0124",
"0248",
"0469",
"1289",
"13468",
"23678",
"35566",
"011237",
"122446",
"224588",
"0145678",
"0122579",
"0134449",
"0368888",
"11266777",
"23334455",
"01466788",
"112234778",
"234455668",
"012356789",
"0112344778"};

bool problem_869::test() {
    auto n = 10;

    auto expected = false;

    auto result = reorderedPowerOf2(n);

    return result == expected;
}

bool problem_869::reorderedPowerOf2(int n) {
    std::string sorted = std::to_string(n);
    std::sort(sorted.begin(), sorted.end());
    return std::find(sortedPowers.begin(), sortedPowers.end(), sorted) != sortedPowers.end();
}


