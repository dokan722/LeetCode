#include "problem_1865.h"

#include <unordered_map>

class FindSumPairs {
public:
    FindSumPairs(std::vector<int>& nums1, std::vector<int>& nums2) {
        _nums1 = nums1;
        _nums2 = nums2;
        std::unordered_map<int, int> map;
        _numsDic = map;
        for (int i = 0; i < nums2.size(); ++i)
        {
            if (_numsDic.contains(nums2[i]))
                _numsDic[nums2[i]] += 1;
            else
                _numsDic[nums2[i]] = 1;
        }
    }

    void add(int index, int val) {
        _numsDic[_nums2[index]] -= 1;
        _nums2[index] += val;
        if (_numsDic.contains(_nums2[index]))
            _numsDic[_nums2[index]] += 1;
        else
            _numsDic[_nums2[index]] = 1;
    }

    int count(int tot) {
        auto result = 0;
        for (int val : _nums1)
        {
            auto com = tot - val;
            if (_numsDic.contains(com))
                result += _numsDic[com];
        }

        return result;
    }
private:
    std::vector<int> _nums1;
    std::vector<int> _nums2;
    std::unordered_map<int, int> _numsDic;
};

bool problem_1865::test() {
    std::vector nums1 = {1, 1, 2, 2, 2, 3};
    std::vector nums2 = {1, 4, 5, 2, 5, 4};
    FindSumPairs findSumPairs(nums1,  nums2);
    auto result = findSumPairs.count(7);
    if (result != 8)
        return false;
    findSumPairs.add(3, 2);
    result = findSumPairs.count(8);
    if (result != 2)
        return false;
    result = findSumPairs.count(4);
    if (result != 1)
        return false;
    findSumPairs.add(0, 1);
    findSumPairs.add(1, 1);
    result = findSumPairs.count(7);
    if (result != 11)
        return false;
    return true;
}
