#ifndef PROBLEM_451_H
#define PROBLEM_451_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_451 : public problem {
public:
    bool test() override;

    std::string frequencySort(std::string s);
};



#endif //PROBLEM_451_H
