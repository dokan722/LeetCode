#include "problem_1577.h"

#include <unordered_map>

bool problem_1577::test() {
    std::vector nums1 { 7, 4 };
    std::vector nums2 { 5, 2, 8, 9 };

    int expected = 1;

    int result = numTriplets(nums1, nums2);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1577::numTriplets(std::vector<int> &nums1, std::vector<int> &nums2) {
    std::unordered_map<int, int> counts1;
    std::unordered_map<int, int> counts2;
    int n1 = nums1.size();
    int n2 = nums2.size();
    for (int i = 0; i < n1; ++i)
    {
        if (counts1.contains(nums1[i]))
            counts1[nums1[i]]++;
        else
            counts1[nums1[i]] = 1;
    }

    for (int i = 0; i < n2; ++i)
    {
        if (counts2.contains(nums2[i]))
            counts2[nums2[i]]++;
        else
            counts2[nums2[i]] = 1;
    }

    auto result = 0.0;

    for (int i = 0; i < n1; ++i)
    {
        auto num = (long long)nums1[i] * nums1[i];
        for (auto key : counts2)
        {
            if (num % key.first != 0)
                continue;
            int req = (int)(num / key.first);
            if (counts2.contains(req))
            {
                if (req == key.first)
                    result += (counts2[key.first] * (counts2[req] - 1)) / 2;
                else
                    result += (counts2[key.first] * counts2[req]) / 2.0;
            }
        }
    }

    for (int i = 0; i < n2; ++i)
    {
        auto num = (long long)nums2[i] * nums2[i];
        for (auto key : counts1)
        {
            if (num % key.first != 0)
                continue;
            auto req = (int)(num / key.first);
            if (counts1.contains(req))
            {
                if (req == key.first)
                    result += (counts1[key.first] * (counts1[req] - 1)) / 2;
                else
                    result += (counts1[key.first] * counts1[req]) / 2.0;
            }
        }
    }

    return (int)result;
}
