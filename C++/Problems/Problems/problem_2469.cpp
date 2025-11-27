#include "problem_2469.h"

bool problem_2469::test() {
    double celsius = 36.50;

    std::vector<double> expected { 309.65000, 97.70000 };

    auto result = convertTemperature(celsius);

    print1DVector(result);

    return result == expected;
}

std::vector<double> problem_2469::convertTemperature(double celsius) {
    return { celsius + 273.15, celsius * 1.8 + 32 };
}
