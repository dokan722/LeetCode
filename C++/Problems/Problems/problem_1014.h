#ifndef PROBLEM_1014_H
#define PROBLEM_1014_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1014 : public problem {
public:
    bool test() override;

    int maxScoreSightseeingPair(std::vector<int>& values);
};



#endif //PROBLEM_1014_H
