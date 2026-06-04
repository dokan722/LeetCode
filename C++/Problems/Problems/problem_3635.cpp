#include "problem_3635.h"

bool problem_3635::test() {
    std::vector landStartTime  { 2, 8 };
    std::vector landDuration { 4, 1 };
    std::vector waterStartTime { 6 };
    std::vector waterDuration { 3 };

    int expected = 9;

    auto result = earliestFinishTime(landStartTime, landDuration, waterStartTime, waterDuration);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3635::earliestFinishTime(std::vector<int> &landStartTime, std::vector<int> &landDuration,
    std::vector<int> &waterStartTime, std::vector<int> &waterDuration) {
    int nl = landStartTime.size();
    int nw = waterStartTime.size();
    int li = 0;
    int wi = 0;
    for (int i = 1; i < nl; ++i)
    {
        if (landStartTime[i] + landDuration[i] < landStartTime[li] + landDuration[li])
            li = i;
    }
    for (int i = 1; i < nw; ++i)
    {
        if (waterStartTime[i] + waterDuration[i] < waterStartTime[wi] + waterDuration[wi])
            wi = i;
    }
    int lf = INT_MAX;
    for (int i = 0; i < nw; ++i)
    {
        int end = std::max(landStartTime[li] + landDuration[li], waterStartTime[i]) + waterDuration[i];
        lf = std::min(lf, end);
    }
    int wf = INT_MAX;
    for (int i = 0; i < nl; ++i)
    {
        int end = std::max(waterStartTime[wi] + waterDuration[wi], landStartTime[i]) + landDuration[i];
        wf = std::min(wf, end);
    }

    return std::min(lf, wf);
}
