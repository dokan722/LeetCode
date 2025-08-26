#include "problem_3000.h"

bool problem_3000::test() {
    std::vector<std::vector<int>> dimensions { { 9, 3 }, { 8, 6 } };

    auto expected = 48;

    auto result = areaOfMaxDiagonal(dimensions);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_3000::areaOfMaxDiagonal(std::vector<std::vector<int>> &dimensions) {
    auto maxDia = 0;
    auto maxArea = 0;
    for (int i = 0; i < dimensions.size(); ++i)
    {
        int dia = dimensions[i][0] * dimensions[i][0] + dimensions[i][1] * dimensions[i][1];
        if (dia > maxDia)
        {
            maxDia = dia;
            maxArea = dimensions[i][0] * dimensions[i][1];
        }
        else if (dia == maxDia)
            maxArea = std::max(maxArea, dimensions[i][0] * dimensions[i][1]);
    }

    return maxArea;
}
