#include "problem_2491.h"

#include <unordered_map>

bool problem_2491::test() {
    std::vector skill { 3, 2, 5, 1, 3, 4 };

    int expected = 22;

    auto result = dividePlayers(skill);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2491::dividePlayers(std::vector<int> &skill) {
    int n = skill.size();
    long long sum = 0;
    std::pmr::unordered_map<int, int> skills;
    for (auto s : skill)
    {
        if (skills.contains(s))
            skills[s]++;
        else
            skills[s] = 1;
        sum += s;
    }
    if (sum % (n / 2) != 0)
        return -1;
    int target = (int)(sum / (n / 2));
    long result = 0;
    for (auto s : skill)
    {
        int req = target - s;
        if (!skills.contains(req) || skills[req] != skills[s])
            return -1;
        result += s * req;
    }

    return result / 2;
}
