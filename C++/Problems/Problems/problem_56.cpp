#include "problem_56.h"

bool problem_56::test() {
    std::vector<std::vector<int>> intervals {  { 1, 3 },  { 2, 6 },  { 8, 10 },  { 15, 18 } };

    std::vector<std::vector<int>> expected = {  { 1, 6 },  { 8, 10 },  { 15, 18 } };

    auto result = merge(intervals);


    return result == expected;
}

std::vector<std::vector<int>> problem_56::merge(std::vector<std::vector<int>> &intervals) {
    auto maxLen = 10001;
    std::vector overlaps(maxLen, 0);
    std::vector oneDays(maxLen, false);
    auto first = INT_MAX;
    auto last = INT_MIN;
    for (auto interval : intervals)
    {
        if (interval[0] == interval[1])
            oneDays[interval[0]] = true;
        if (interval[0] < first)
            first = interval[0];
        if (interval[1] > last)
            last = interval[1];
        overlaps[interval[0]]++;
        overlaps[interval[1]]--;
    }

    std::vector<std::vector<int>> result;
    auto start = first;
    auto runningSum = 0;
    auto inside = overlaps[first] != 0;
    for (int i = first; i <= last; ++i)
    {
        runningSum += overlaps[i];
        if (inside)
        {
            if (runningSum == 0)
            {
                result.push_back( {start, i});
                inside = false;
            }
        }
        else
        {
            if (runningSum != 0)
            {
                start = i;
                inside = true;
            }
        }
        if (runningSum == 0 && overlaps[i] == 0 && oneDays[i])
            result.push_back( { i, i });

    }


    return result;
}
