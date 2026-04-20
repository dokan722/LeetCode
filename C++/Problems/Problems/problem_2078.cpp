#include "problem_2078.h"

bool problem_2078::test() {
    std::vector colors { 1, 1, 1, 6, 1, 1, 1 };

    int expected = 3;

    auto result = maxDistance(colors);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_2078::maxDistance(std::vector<int> &colors) {
    int n = colors.size();
    int lastDif = n - 1;
    while (colors[lastDif] == colors[0])
        lastDif--;
    int firstDif = 0;
    while (colors[firstDif] == colors[n - 1])
        firstDif++;

    return std::max(lastDif, n - firstDif - 1);
}
