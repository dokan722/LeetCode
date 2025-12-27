#ifndef PROBLEM_2895_H
#define PROBLEM_2895_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2895 : public problem {
public:
    bool test() override;

    int minProcessingTime(std::vector<int>& processorTime, std::vector<int>& tasks);
};

#endif //PROBLEM_2895_H
