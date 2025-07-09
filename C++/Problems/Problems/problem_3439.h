#ifndef PROBLEM_3439_H
#define PROBLEM_3439_H

#include "../problem.h"
#include <vector>

class problem_3439 : public problem {
public:
    bool test() override;

    int maxFreeTime(int eventTime, int k, std::vector<int>& startTime, std::vector<int>& endTime);
private:
    int getGapLength(int i, std::vector<int>& startTime, std::vector<int>& endTime, int eventTime);
};



#endif //PROBLEM_3439_H
