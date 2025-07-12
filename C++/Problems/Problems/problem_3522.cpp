#include "problem_3522.h"

bool problem_3522::test() {
    std::vector<std::string> instructions {"jump", "add", "add", "jump", "add", "jump"};

    std::vector<int> values { 2, 1, 3, 1, -2, -3 };

    auto expected = 1;

    auto result = calculateScore(instructions, values);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3522::calculateScore(std::vector<std::string> &instructions, std::vector<int> &values) {
    int i = 0;
    int n = instructions.size();
    std::vector<bool> visited(n);
    long score = 0;
    while (i >= 0 && i < n && !visited[i])
    {
        if (instructions[i] == "add")
        {
            visited[i] = true;
            score += values[i];
            i++;
        }
        else
        {
            visited[i] = true;
            i += values[i];
        }
    }

    return score;
}
