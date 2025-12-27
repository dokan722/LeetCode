#include "problem_167.h"

bool problem_167::test() {
    std::vector numbers { 2, 7, 11, 15 };
    int target = 9;

    std::vector expected { 1, 2 };

    auto result = twoSum(numbers, target);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_167::twoSum(std::vector<int> &numbers, int target) {
    int left = 0;
    int right = numbers.size() - 1;
    while (left < right)
    {
        if (target < numbers[left] + numbers[right])
            right--;
        else if (target > numbers[left] + numbers[right])
            left++;
        else
            return std::vector{ left + 1, right + 1 };
    }

    return std::vector<int>();
}
