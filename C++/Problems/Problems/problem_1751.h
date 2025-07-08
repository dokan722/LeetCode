#ifndef PROBLEM_1751_H
#define PROBLEM_1751_H

#include "../problem.h"
#include <vector>

class problem_1751 : public problem {
public:
    bool test() override;

    int maxValue(std::vector<std::vector<int>>& events, int k);
private:
    int checkScheduleRec(std::vector<std::vector<int>>& events, std::vector<std::vector<int>>& memory, int currEvent, int k);
};



#endif //PROBLEM_1751_H
