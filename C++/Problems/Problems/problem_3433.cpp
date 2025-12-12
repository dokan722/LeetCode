#include "problem_3433.h"

#include <algorithm>

bool problem_3433::test() {
    int numberOfUsers = 2;
    std::vector<std::vector<std::string>> events { {"MESSAGE", "10", "id1 id0"}, { "OFFLINE", "11", "0"}, { "MESSAGE", "71", "HERE"}};

    std::vector expected { 2, 2 };

    auto result = countMentions(numberOfUsers, events);

    print1DVector(result);

    return result == expected;
}

std::vector<int> problem_3433::countMentions(int numberOfUsers, std::vector<std::vector<std::string>> &events) {
    std::vector online(numberOfUsers, 0);
    std::sort(events.begin(), events.end(), [](const std::vector<std::string> &a, const std::vector<std::string> &b)
        { return a[1] == b[1] ? a[0] > b[0] : std::stoi(a[1]) < std::stoi(b[1]); });
    std::vector result(numberOfUsers, 0);
    int alls = 0;
    for (auto& e : events)
    {
        if (e[0][0] == 'O')
        {
            int ts = std::stoi(e[1]);
            int id = std::stoi(e[2]);
            online[id] = ts + 60;
        }
        else
        {
            if (e[2][0] == 'A')
                alls += 1;
            else if (e[2][0] == 'H')
            {
                int ts = std::stoi(e[1]);
                for (int i = 0; i < numberOfUsers; ++i)
                {
                    if (online[i] <= ts)
                        result[i]++;
                }
            }
            else
            {
                int idx = 0;
                for (int i = 0; i < e[2].size(); i++)
                {
                    if (isdigit(e[2][i]))
                    {
                        idx = idx * 10 + (e[2][i] - '0');
                    }
                    if (i + 1 == e[2].size() || e[2][i + 1] == ' ')
                    {
                        result[idx]++;
                        idx = 0;
                    }
                }
            }
        }
    }
    if (alls > 0)
        for (int i = 0; i < numberOfUsers; ++i)
            result[i] += alls;

    return result;
}
