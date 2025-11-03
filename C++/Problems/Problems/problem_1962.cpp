#include "problem_1962.h"

#include <queue>

bool problem_1962::test() {
    std::vector piles { 4, 3, 6, 7 };
    int k = 3;

    int expected = 12;

    auto result = minStoneSum(piles, k);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1962::minStoneSum(std::vector<int> &piles, int k) {
    int n = piles.size();
    std::priority_queue<int> que;
    int sum = 0;
    for (int pile : piles)
    {
        que.push(pile);
        sum += pile;
    }

    for (int i = 0; i < k; ++i)
    {
        int next = que.top();
        que.pop();
        int toRemove =  next / 2;
        if (toRemove == 0)
            break;
        sum -= toRemove;
        int newPile = next - toRemove;
        que.push(newPile);
    }

    return sum;
}
