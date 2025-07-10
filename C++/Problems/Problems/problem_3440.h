#ifndef PROBLEM_3440_H
#define PROBLEM_3440_H

#include "../problem.h"
#include <vector>

class problem_3440 : public problem {
public:
    bool test() override;

    int maxFreeTime(int eventTime, std::vector<int>& startTime, std::vector<int>& endTime);
private:
    int getGapLength(int i, std::vector<int>& startTime, std::vector<int>& endTime, int eventTime);
};



#endif //PROBLEM_3440_H
