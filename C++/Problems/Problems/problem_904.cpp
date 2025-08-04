#include "problem_904.h"

bool problem_904::test() {
    std::vector fruits { 1,0,1,4,1,4,1,2,3 };

    auto expected = 5;

    auto result = totalFruit(fruits);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_904::totalFruit(std::vector<int> &fruits) {
    int n = fruits.size();
    int start = 0;

    while (start < n && fruits[start] == fruits[0])
        start++;
    if (start >= n)
        return n;

    int firstFruit = fruits[0];
    int firstCount = start;
    int secondFruit = fruits[start];
    int secondCount = 1;

    int lastSwap = start;
    int result = 0;
    int prev = fruits[start];

    for (int i = start + 1; i < n; ++i)
    {
        if (fruits[i] != firstFruit && fruits[i] != secondFruit)
        {
            if (firstCount + secondCount > result)
                result = firstCount + secondCount;
            if (fruits[i - 1] == firstFruit)
            {
                secondFruit = fruits[i];
                secondCount = 1;
                firstCount = i - lastSwap;
            }
            else
            {
                firstFruit = fruits[i];
                firstCount = 1;
                secondCount = i - lastSwap;
            }

        }
        else if (fruits[i] == firstFruit)
            firstCount++;
        else
            secondCount++;

        if (fruits[i] != prev)
        {
            prev = fruits[i];
            lastSwap = i;
        }
    }

    if (firstCount + secondCount > result)
        result = firstCount + secondCount;

    return result;
}
