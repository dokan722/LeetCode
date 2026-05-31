#include "problem_2126.h"

bool problem_2126::test() {
    int mass = 10;
    std::vector asteroids { 3, 9, 19, 5, 21 };

    bool expected = true;

    auto result = asteroidsDestroyed(mass, asteroids);

    return result == expected;
}

bool problem_2126::asteroidsDestroyed(int mass, std::vector<int> &asteroids) {
    long long curMass = mass;
    std::sort(asteroids.begin(), asteroids.end());
    for (auto a : asteroids)
    {
        if (a > curMass)
            return false;
        curMass += a;
    }

    return true;
}
