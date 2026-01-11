#ifndef PROBLEM_3184_H
#define PROBLEM_3184_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3184 : public problem {
public:
    bool test() override;

    int countCompleteDayPairs(std::vector<int>& hours);
};

#endif //PROBLEM_3184_H
