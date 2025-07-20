#ifndef PROBLEM_1732_H
#define PROBLEM_1732_H

#include "../problem.h"
#include <vector>
#include <string>

class problem_1732 : public problem {
public:
    bool test() override;

    int largestAltitude(std::vector<int>& gain) ;
};



#endif //PROBLEM_1732_H
