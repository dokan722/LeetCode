#include "problem_1276.h"

bool problem_1276::test() {
    int tomatoSlices = 4;
    int cheeseSlices = 17;

    std::vector<int> expected;

    auto result = numOfBurgers(tomatoSlices, cheeseSlices);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_1276::numOfBurgers(int tomatoSlices, int cheeseSlices) {
    int doubleSlices = cheeseSlices * 2;
    int leftover = tomatoSlices - doubleSlices;
    if (doubleSlices > tomatoSlices || leftover % 2 == 1 || leftover > doubleSlices)
        return {};
    int jumbo = leftover / 2;
    return std::vector { jumbo, cheeseSlices - jumbo };
}
