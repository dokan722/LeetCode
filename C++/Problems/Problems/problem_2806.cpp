#include "problem_2806.h"

bool problem_2806::test() {
    int purchaseAmount = 9;

    int expected = 90;

    auto result = accountBalanceAfterPurchase(purchaseAmount);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2806::accountBalanceAfterPurchase(int purchaseAmount) {
    return 100 - (purchaseAmount + 5) / 10 * 10;
}
